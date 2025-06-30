using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;

namespace RepairSystem
{
    public class FixDateTimeFormat
    {
        public static void Run()
        {
            using (var connection = Helpers.DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string selectSql = "SELECT Id, StartTime, EndTime FROM RepairOrder";
                using (var cmd = new SQLiteCommand(selectSql, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string startTime = reader.IsDBNull(1) ? null : reader.GetString(1);
                        string endTime = reader.IsDBNull(2) ? null : reader.GetString(2);
                        string newStart = FixTime(startTime);
                        string newEnd = FixTime(endTime);
                        if (newStart != startTime || newEnd != endTime)
                        {
                            UpdateTime(connection, id, newStart, newEnd);
                            Console.WriteLine($"已修正 Id={id}：StartTime={newStart}，EndTime={newEnd}");
                        }
                    }
                }
            }
            Console.WriteLine("修正完成");
        }

        private static string FixTime(string time)
        {
            if (string.IsNullOrWhiteSpace(time)) return null;
            // 去除「上午」「下午」等中文標記，並轉換為 24 小時制
            time = time.Replace("上午", "AM").Replace("下午", "PM").Replace("　", " ").Trim();
            DateTime dt;
            string[] formats = {
                "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd HH:mm", "yyyy/M/d tt hh:mm:ss", "yyyy/M/d tt hh:mm", "yyyy/M/d HH:mm:ss", "yyyy/M/d HH:mm", "yyyy-MM-dd", "yyyy/M/d"
            };
            if (DateTime.TryParseExact(time, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt) ||
                DateTime.TryParse(time, System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None, out dt) ||
                DateTime.TryParse(time, out dt))
            {
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
            return time; // 無法解析則原樣返回
        }

        private static void UpdateTime(SQLiteConnection conn, int id, string start, string end)
        {
            string sql = "UPDATE RepairOrder SET StartTime=@StartTime, EndTime=@EndTime WHERE Id=@Id";
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@StartTime", (object)start ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EndTime", (object)end ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
} 