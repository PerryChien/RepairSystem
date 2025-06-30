using System;
using System.Data;
using System.Data.SQLite;

class Program
{
    static void Main()
    {
        string dbPath = "Data/RepairSystem.db";
        string connectionString = $"Data Source={dbPath};Version=3;";
        
        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // 檢查 RepairOrder 表格是否存在
                string checkTableSql = "SELECT name FROM sqlite_master WHERE type='table' AND name='RepairOrder';";
                using (var command = new SQLiteCommand(checkTableSql, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result == null)
                    {
                        Console.WriteLine("錯誤：RepairOrder 表格不存在");
                        return;
                    }
                }
                
                // 獲取表格結構
                string sql = "PRAGMA table_info(RepairOrder);";
                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    Console.WriteLine("RepairOrder 表格結構：");
                    Console.WriteLine("cid\tname\ttype\tnotnull\tdefault\tpk");
                    Console.WriteLine(new string('-', 50));
                    
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["cid"]}\t{reader["name"]}\t{reader["type"]}\t{reader["notnull"]}\t{reader["dflt_value"]}\t{reader["pk"]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"發生錯誤：{ex.Message}");
        }
        
        Console.WriteLine("\n按任意鍵結束...");
        Console.ReadKey();
    }
}
