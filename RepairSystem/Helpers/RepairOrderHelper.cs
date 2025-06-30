using System;
using System.Data;
using System.Data.SQLite;
using RepairSystem.Helpers;

namespace RepairSystem.Helpers
{
    public class RepairOrderHelper
    {
        public static void AddRepairOrder(string type, string customerName, string contactName, string phone, string startTimeStr, string model, string faultDescription, string workRecord, string hardwareSpecs, string engineer)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO RepairOrder (Type, CustomerName, ContactName, Phone, StartTime, Model, FaultDescription, WorkRecord, HardwareSpecs, Engineer)
                        VALUES (@Type, @CustomerName, @ContactName, @Phone, @StartTime, @Model, @FaultDescription, @WorkRecord, @HardwareSpecs, @Engineer)";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@ContactName", contactName);
                        command.Parameters.AddWithValue("@Phone", phone);

                        // 確保日期格式正確
                        if (DateTime.TryParse(startTimeStr, out DateTime startTime))
                        {
                            command.Parameters.AddWithValue("@StartTime", startTime.ToString("yyyy-MM-dd HH:mm"));
                        }
                        else
                        {
                            throw new Exception("叫修時間格式錯誤");
                        }

                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@FaultDescription", faultDescription);
                        command.Parameters.AddWithValue("@WorkRecord", workRecord);
                        command.Parameters.AddWithValue("@HardwareSpecs", string.IsNullOrWhiteSpace(hardwareSpecs) || hardwareSpecs == "無" ? DBNull.Value : (object)hardwareSpecs);
                        command.Parameters.AddWithValue("@Engineer", engineer);

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("報修單已成功新增！");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"錯誤：{ex.Message}");
            }
        }
    }
}