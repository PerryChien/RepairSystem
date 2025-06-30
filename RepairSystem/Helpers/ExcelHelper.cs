using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;

namespace RepairSystem.Helpers
{
    public class ExcelHelper
    {
        public static DataTable ImportExcel(string filePath)
        {
            DataTable dt = new DataTable();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(fs);
                    ISheet sheet = workbook.GetSheetAt(0);

                    // 讀取標題列
                    IRow headerRow = sheet.GetRow(0);
                    foreach (ICell cell in headerRow.Cells)
                    {
                        dt.Columns.Add(cell.ToString());
                    }

                    // 讀取資料列
                    for (int i = 1; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        DataRow dataRow = dt.NewRow();

                        for (int j = 0; j < headerRow.LastCellNum; j++)
                        {
                            if (row?.GetCell(j) != null)
                            {
                                // 特殊處理 Excel 日期欄位，只保留到「分鐘」
                                if (j == 4 || j == 5) // 假設第 5、6 欄是叫修時間與完修時間
                                {
                                    var dateTime = ParseExcelDateTime(row.GetCell(j));
                                    if (dateTime.HasValue)
                                    {
                                        dataRow[j] = dateTime.Value.ToString("yyyy-MM-dd HH:mm");
                                    }
                                    else
                                    {
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                }
                                else
                                {
                                    dataRow[j] = row.GetCell(j).ToString();
                                }
                            }
                        }

                        dt.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"匯入 Excel 失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        private static DateTime? ParseExcelDateTime(ICell cell)
        {
            if (cell == null) return null;

            try
            {
                switch (cell.CellType)
                {
                    case CellType.Numeric:
                        if (DateUtil.IsCellDateFormatted(cell))
                        {
                            return cell.DateCellValue;
                        }
                        else
                        {
                            try
                            {
                                return DateTime.FromOADate(cell.NumericCellValue);
                            }
                            catch
                            {
                                return null;
                            }
                        }

                    case CellType.String:
                        string cellValue = cell.StringCellValue.Trim();
                        if (string.IsNullOrEmpty(cellValue))
                            return null;

                        // 嘗試多種日期格式
                        string[] formats = {
                            "yyyy/M/d H:mm",
                            "yyyy/M/d HH:mm",
                            "yyyy/MM/dd H:mm",
                            "yyyy/MM/dd HH:mm",
                            "yyyy-M-d H:mm",
                            "yyyy-M-d HH:mm",
                            "yyyy-MM-dd H:mm",
                            "yyyy-MM-dd HH:mm",
                            "M/d/yyyy H:mm",
                            "M/d/yyyy HH:mm",
                            "MM/dd/yyyy H:mm",
                            "MM/dd/yyyy HH:mm",
                            "yyyy/M/d",
                            "yyyy/MM/dd",
                            "yyyy-M-d",
                            "yyyy-MM-dd"
                        };

                        foreach (string format in formats)
                        {
                            if (DateTime.TryParseExact(cellValue, format,
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None, out DateTime result))
                            {
                                return result;
                            }
                        }

                        if (DateTime.TryParse(cellValue, out DateTime generalResult))
                        {
                            return generalResult;
                        }
                        break;

                    case CellType.Formula:
                        if (cell.CachedFormulaResultType == CellType.Numeric)
                        {
                            if (DateUtil.IsCellDateFormatted(cell))
                            {
                                return cell.DateCellValue;
                            }
                            else
                            {
                                try
                                {
                                    return DateTime.FromOADate(cell.NumericCellValue);
                                }
                                catch
                                {
                                    return null;
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"日期解析錯誤: {ex.Message}");
            }

            return null;
        }
    }
}