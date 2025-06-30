using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using RepairSystem.Helpers;
using Microsoft.VisualBasic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.Util;
using System.Data.SQLite;

namespace RepairSystem.Forms
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            buttonSave.Click += ButtonSave_Click;
            buttonAddType.Click += ButtonAddType_Click;
            buttonAddFaultDescription.Click += ButtonAddFaultDescription_Click;
            buttonDbBackup.Click += ButtonDbBackup_Click;
            buttonDbImport.Click += ButtonDbImport_Click;
            buttonExcelImport.Click += ButtonExcelImport_Click;
            buttonCustomerExcelImport.Click += ButtonCustomerExcelImport_Click;
            buttonRecovery.Click += ButtonRecovery_Click;

            SetupDataGrid(dataGridViewType, "RepairType", "TypeName");
            SetupDataGrid(dataGridViewFaultDescription, "FaultType", "FaultName");

            dataGridViewType.CellClick += DataGridViewType_CellClick;
            dataGridViewFaultDescription.CellClick += DataGridViewFaultDescription_CellClick;
        }

        private void SetupDataGrid(DataGridView grid, string tableName, string columnName)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();

            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "編號",
                DataPropertyName = "Id",
                ReadOnly = true
            };

            var nameColumn = new DataGridViewTextBoxColumn
            {
                Name = columnName,
                HeaderText = columnName == "TypeName" ? "類型" : "故障現象",
                DataPropertyName = columnName,
                ReadOnly = true
            };

            var editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "修改",
                Text = "修改",
                UseColumnTextForButtonValue = true
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "刪除",
                Text = "刪除",
                UseColumnTextForButtonValue = true
            };

            grid.Columns.Add(idColumn);
            grid.Columns.Add(nameColumn);
            grid.Columns.Add(editButton);
            grid.Columns.Add(deleteButton);

            LoadDataGrid(grid, tableName, columnName);
        }

        private void LoadDataGrid(DataGridView grid, string tableName, string columnName)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = $"SELECT Id, {columnName} FROM {tableName} ORDER BY {columnName} ASC";

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入 {tableName} 失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string uniName = textBoxUniName.Text.Trim();

            if (string.IsNullOrWhiteSpace(uniName))
            {
                MessageBox.Show("工作單位名稱不可為空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper.Instance.SetConfig("UniName", uniName);
                MessageBox.Show("工作單位名稱已更新！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDbBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string dbPath = Path.Combine(Application.StartupPath, "Data", "RepairSystem.db");
                
                // 設定預設檔名為當前日期時間
                string defaultFileName = $"RepairSystem_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.db";
                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "選擇備份檔案儲存位置";
                    saveFileDialog.FileName = defaultFileName;
                    saveFileDialog.Filter = "SQLite 資料庫檔案|*.db";
                    saveFileDialog.DefaultExt = "db";
                    saveFileDialog.AddExtension = true;
                    
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = saveFileDialog.FileName;
                        
                        // 確保目標目錄存在
                        string directory = Path.GetDirectoryName(backupPath);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }
                        
                        // 執行備份
                        File.Copy(dbPath, backupPath, true);
                        
                        // 顯示成功訊息，包含備份路徑
                        MessageBox.Show($"資料庫已成功備份至：\n{backupPath}", 
                                      "備份成功", 
                                      MessageBoxButtons.OK, 
                                      MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"資料庫備份失敗：{ex.Message}", 
                              "備份錯誤", 
                              MessageBoxButtons.OK, 
                              MessageBoxIcon.Error);
            }
        }

        private void ButtonDbImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SQLite 資料庫 (*.db)|*.db",
                Title = "選擇要匯入的資料庫檔案"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourcePath = openFileDialog.FileName;
                    string dbPath = Path.Combine(Application.StartupPath, "Data", "RepairSystem.db");

                    File.Copy(sourcePath, dbPath, true);
                    MessageBox.Show("資料庫已成功匯入！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"資料庫匯入失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonExcelImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel 檔案 (*.xlsx)|*.xlsx",
                Title = "選擇要匯入的 Excel 檔案"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        IWorkbook workbook = new XSSFWorkbook(file);
                        ISheet sheet = workbook.GetSheetAt(0); // 取第一個工作表

                        using (var connection = DatabaseHelper.Instance.GetConnection())
                        {
                            connection.Open();
                            using (var transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // 假設第一列是標題，從第二列開始
                                    for (int row = 1; row <= sheet.LastRowNum; row++)
                                    {
                                        var excelRow = sheet.GetRow(row);
                                        if (excelRow == null) continue;

                                        // 讀取 Excel 中的資料
                                        string type = excelRow.GetCell(1)?.ToString().Trim() ?? string.Empty;
                                        string customerName = excelRow.GetCell(2)?.ToString().Trim() ?? string.Empty;
                                        string contactName = excelRow.GetCell(3)?.ToString().Trim() ?? string.Empty;
                                        string phone = excelRow.GetCell(4)?.ToString().Trim() ?? string.Empty;
                                        string model = excelRow.GetCell(7)?.ToString().Trim() ?? string.Empty;
                                        string faultDescription = excelRow.GetCell(8)?.ToString().Trim() ?? string.Empty;
                                        string workRecord = excelRow.GetCell(9)?.ToString().Trim() ?? string.Empty;
                                        string hardwareSpecs = excelRow.GetCell(10)?.ToString().Trim() ?? string.Empty;
                                        string engineer = excelRow.GetCell(11)?.ToString().Trim() ?? string.Empty;

                                        // 檢查必填欄位
                                        if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(customerName))
                                        {
                                            continue; // 跳過必填欄位為空的資料列
                                        }

                                        // 處理叫修時間 (第6欄，索引5)
                                        DateTime startTime = DateTime.Now;
                                        var startTimeCell = excelRow.GetCell(5);
                                        if (startTimeCell != null)
                                        {
                                            var parsedStartTime = ParseExcelDateTime(startTimeCell, DateTime.Now);
                                            if (parsedStartTime.HasValue)
                                            {
                                                startTime = parsedStartTime.Value;
                                            }
                                        }

                                        // 處理完修時間 (第7欄，索引6)
                                        DateTime? endTime = null;
                                        var endTimeCell = excelRow.GetCell(6);
                                        if (endTimeCell != null)
                                        {
                                            endTime = ParseExcelDateTime(endTimeCell, null);
                                        }

                                        // 插入資料到 RepairOrder 資料表
                                        string insertQuery = @"
                                            INSERT INTO RepairOrder 
                                            (Type, CustomerName, ContactName, Phone, StartTime, EndTime, 
                                             Model, FaultDescription, WorkRecord, HardwareSpecs, Engineer, CreatedTime)
                                            VALUES 
                                            (@Type, @CustomerName, @ContactName, @Phone, @StartTime, @EndTime, 
                                             @Model, @FaultDescription, @WorkRecord, @HardwareSpecs, @Engineer, @CreatedTime)";

                                        using (var command = new SQLiteCommand(insertQuery, connection, transaction))
                                        {
                                            command.Parameters.AddWithValue("@Type", type);
                                            command.Parameters.AddWithValue("@CustomerName", customerName);
                                            command.Parameters.AddWithValue("@ContactName", contactName);
                                            command.Parameters.AddWithValue("@Phone", phone);
                                            command.Parameters.AddWithValue("@StartTime", startTime);
                                            command.Parameters.AddWithValue("@EndTime", (object)endTime ?? DBNull.Value);
                                            command.Parameters.AddWithValue("@Model", model);
                                            command.Parameters.AddWithValue("@FaultDescription", faultDescription);
                                            command.Parameters.AddWithValue("@WorkRecord", workRecord);
                                            command.Parameters.AddWithValue("@HardwareSpecs", hardwareSpecs);
                                            command.Parameters.AddWithValue("@Engineer", engineer);
                                            command.Parameters.AddWithValue("@CreatedTime", DateTime.Now);

                                            command.ExecuteNonQuery();
                                        }
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Excel 匯入成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    throw new Exception($"Excel 匯入失敗：{ex.Message}");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel 匯入失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DateTime? ParseExcelDateTime(ICell cell, DateTime? defaultValue)
        {
            if (cell == null) return defaultValue;

            try
            {
                switch (cell.CellType)
                {
                    case CellType.Numeric:
                        // 處理數值型儲存格
                        if (DateUtil.IsCellDateFormatted(cell))
                        {
                            // 標準日期格式
                            return cell.DateCellValue;
                        }
                        else
                        {
                            // 可能是 OLE Automation 日期
                            try
                            {
                                return DateTime.FromOADate(cell.NumericCellValue);
                            }
                            catch
                            {
                                return defaultValue;
                            }
                        }

                    case CellType.String:
                        // 處理字串型儲存格
                        string cellValue = cell.StringCellValue.Trim();
                        if (string.IsNullOrEmpty(cellValue))
                            return defaultValue;

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

                        // 如果以上都失敗，使用一般解析
                        if (DateTime.TryParse(cellValue, out DateTime generalResult))
                        {
                            return generalResult;
                        }
                        break;

                    case CellType.Formula:
                        // 處理公式儲存格
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
                                    return defaultValue;
                                }
                            }
                        }
                        else if (cell.CachedFormulaResultType == CellType.String)
                        {
                            return ParseExcelDateTime(cell, defaultValue);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                // 記錄錯誤但不中斷程式執行
                System.Diagnostics.Debug.WriteLine($"日期解析錯誤: {ex.Message}");
            }

            return defaultValue;
        }

        private void ButtonCustomerExcelImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel 檔案 (*.xlsx)|*.xlsx",
                Title = "選擇客戶資料 Excel 檔案"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    int importedCount = 0;
                    int skippedCount = 0;

                    using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        IWorkbook workbook = new XSSFWorkbook(file);
                        ISheet sheet = workbook.GetSheetAt(0); // 取第一個工作表

                        using (var connection = DatabaseHelper.Instance.GetConnection())
                        {
                            connection.Open();
                            using (var transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // 假設第一列是標題，從第二列開始
                                    for (int row = 1; row <= sheet.LastRowNum; row++)
                                    {
                                        var excelRow = sheet.GetRow(row);
                                        if (excelRow == null) continue;

                                        // 讀取 Excel 中的客戶資料
                                        string customerName = excelRow.GetCell(1)?.ToString().Trim() ?? string.Empty; // 客戶名稱
                                        string taxId = excelRow.GetCell(2)?.ToString().Trim() ?? string.Empty; // 統一編號
                                        string phone = excelRow.GetCell(3)?.ToString().Trim() ?? string.Empty; // 電話
                                        string zipCode = excelRow.GetCell(4)?.ToString().Trim() ?? string.Empty; // 郵遞區號 
                                        string address = excelRow.GetCell(5)?.ToString().Trim() ?? string.Empty; // 地址
                                        string email = excelRow.GetCell(6)?.ToString().Trim() ?? string.Empty; // 電子郵件
                                        string createdTime = excelRow.GetCell(7)?.ToString().Trim() ?? string.Empty; // 建立時間

                                        // 檢查必填欄位
                                        if (string.IsNullOrEmpty(customerName))
                                        {
                                            skippedCount++;
                                            continue; // 跳過客戶名稱為空的資料列
                                        }


                                        // 檢查客戶是否已存在
                                        string checkQuery = "SELECT COUNT(*) FROM Customer WHERE CustomerName = @CustomerName";
                                        using (var checkCommand = new SQLiteCommand(checkQuery, connection, transaction))
                                        {
                                            checkCommand.Parameters.AddWithValue("@CustomerName", customerName);
                                            int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                            if (existingCount > 0)
                                            {
                                                // 客戶已存在，跳過或更新
                                                skippedCount++;
                                                continue;
                                            }
                                        }


                                        // 插入新客戶資料
                                        string insertQuery = @"
                                            INSERT INTO Customer 
                                            (CustomerName, TaxId, Phone,ZipCode, Address, Email, CreatedTime)
                                            VALUES 
                                            (@CustomerName, @TaxId, @Phone,@ZipCode, @Address, @Email, @CreatedTime)";

                                        using (var command = new SQLiteCommand(insertQuery, connection, transaction))
                                        {
                                            command.Parameters.AddWithValue("@CustomerName", customerName);
                                            command.Parameters.AddWithValue("@TaxId", taxId);
                                            command.Parameters.AddWithValue("@Phone", phone);
                                            command.Parameters.AddWithValue("@ZipCode", zipCode);
                                            command.Parameters.AddWithValue("@Address", address);
                                            command.Parameters.AddWithValue("@Email", email);
                                            command.Parameters.AddWithValue("@CreatedTime", DateTime.Now);
                                            command.ExecuteNonQuery();
                                            importedCount++;
                                        }
                                    }

                                    transaction.Commit();

                                    string message = $"客戶資料匯入完成！\n成功匯入: {importedCount} 筆\n已跳過: {skippedCount} 筆";
                                    MessageBox.Show(message, "匯入完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    throw new Exception($"Excel 匯入失敗：{ex.Message}");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"客戶資料匯入失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonRecovery_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要重置系統嗎？這將清空所有資料！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.Instance.ResetDatabase();
                    MessageBox.Show("系統已成功重置！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"系統重置失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridViewType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleDataGridClick(dataGridViewType, e, "RepairType", "TypeName");
        }

        private void DataGridViewFaultDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleDataGridClick(dataGridViewFaultDescription, e, "FaultType", "FaultName");
        }

        private void HandleDataGridClick(DataGridView grid, DataGridViewCellEventArgs e, string tableName, string columnName)
        {
            // 檢查是否點擊了有效的儲存格（非標頭列）
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // 檢查點擊的欄位是否是「修改」或「刪除」按鈕
            string columnNameClicked = grid.Columns[e.ColumnIndex].Name;
            if (columnNameClicked != "Edit" && columnNameClicked != "Delete") return;

            // 取得選取列的 ID
            if (grid.Rows[e.RowIndex].Cells["Id"].Value == null) return;
            int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Id"].Value);

            if (columnNameClicked == "Edit")
            {
                // 取得目前的值
                var cellValue = grid.Rows[e.RowIndex].Cells[columnName].Value;
                string currentValue = cellValue != null ? cellValue.ToString() : string.Empty;

                string newValue = Interaction.InputBox("請輸入新的值：", "修改資料", currentValue);
                if (!string.IsNullOrWhiteSpace(newValue) && newValue != currentValue)
                {
                    UpdateEntry(tableName, columnName, id, newValue);
                }
            }
            else if (columnNameClicked == "Delete")
            {
                DeleteEntry(tableName, id);
            }
        }

        private void DeleteEntry(string tableName, int id)
        {
            try
            {
                // 顯示確認對話框
                if (MessageBox.Show("確定要刪除此項目嗎？", "確認刪除",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    // 先檢查是否被其他表格引用
                    string checkQuery = "";
                    if (tableName == "RepairType")
                    {
                        checkQuery = "SELECT COUNT(*) FROM RepairRecord WHERE TypeId = @Id";
                    }
                    else if (tableName == "FaultType")
                    {
                        checkQuery = "SELECT COUNT(*) FROM RepairRecord WHERE FaultId = @Id";
                    }

                    if (!string.IsNullOrEmpty(checkQuery))
                    {
                        using (var command = new System.Data.SQLite.SQLiteCommand(checkQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("此項目已被使用，無法刪除！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }


                    // 開始交易
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 執行刪除操作
                            string deleteQuery = $"DELETE FROM {tableName} WHERE Id = @Id";
                            using (var command = new System.Data.SQLite.SQLiteCommand(deleteQuery, connection))
                            {
                                command.Transaction = transaction;
                                command.Parameters.AddWithValue("@Id", id);
                                command.ExecuteNonQuery();
                            }

                            // 提交交易
                            transaction.Commit();

                            // 重新載入對應的資料網格
                            if (tableName == "RepairType")
                            {
                                LoadDataGrid(dataGridViewType, "RepairType", "TypeName");
                            }
                            else if (tableName == "FaultType")
                            {
                                LoadDataGrid(dataGridViewFaultDescription, "FaultType", "FaultName");
                            }

                            MessageBox.Show("資料已成功刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // 如果發生錯誤，回滾交易
                            transaction.Rollback();
                            throw new Exception($"刪除操作失敗：{ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEntry(string tableName, string columnName, int id, string newValue)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = $"UPDATE {tableName} SET {columnName} = @NewValue WHERE Id = @Id";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                // 重新載入對應的資料網格
                if (tableName == "RepairType")
                {
                    LoadDataGrid(dataGridViewType, "RepairType", "TypeName");
                }
                else if (tableName == "FaultType")
                {
                    LoadDataGrid(dataGridViewFaultDescription, "FaultType", "FaultName");
                }

                MessageBox.Show("資料已更新！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAddType_Click(object sender, EventArgs e)
        {
            string newType = Interaction.InputBox("請輸入新的類型名稱：", "新增類型");
            if (!string.IsNullOrWhiteSpace(newType))
            {
                try
                {
                    using (var connection = DatabaseHelper.Instance.GetConnection())
                    {
                        connection.Open();
                        string query = "INSERT INTO RepairType (TypeName) VALUES (@TypeName)";
                        using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TypeName", newType);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("類型已成功新增！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(dataGridViewType, "RepairType", "TypeName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"新增類型失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddFaultDescription_Click(object sender, EventArgs e)
        {
            string newFaultDescription = Interaction.InputBox("輸入新的故障描述：", "新增故障描述", "");
            if (!string.IsNullOrWhiteSpace(newFaultDescription))
            {
                try
                {
                    using (var connection = DatabaseHelper.Instance.GetConnection())
                    {
                        connection.Open();
                        string query = "INSERT INTO FaultType (FaultName) VALUES (@FaultName)";
                        using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FaultName", newFaultDescription);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("故障描述已成功新增！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid(dataGridViewFaultDescription, "FaultType", "FaultName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"新增故障描述失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}