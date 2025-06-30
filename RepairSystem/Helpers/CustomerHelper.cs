using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using RepairSystem.Models;

namespace RepairSystem.Helpers
{
    public class CustomerHelper
    {
        private static CustomerHelper _instance;
        private static readonly object _lock = new object();

        public static CustomerHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new CustomerHelper();
                    }
                }
                return _instance;
            }
        }

        // 新增客戶
        public bool AddCustomer(Customer customer)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    // 檢查客戶名稱是否已存在
                    string checkSql = "SELECT COUNT(*) FROM Customer WHERE CustomerName = @CustomerName";
                    using (var checkCommand = new SQLiteCommand(checkSql, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            throw new Exception("客戶名稱已存在！");
                        }
                    }

                    string sql = @"INSERT INTO Customer 
                                  (CustomerName, Phone, ZipCode, Address, Email, CreatedTime) 
                                  VALUES 
                                  (@CustomerName, @Phone, @ZipCode, @Address, @Email, @CreatedTime)";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customer.CustomerName ?? "");
                        command.Parameters.AddWithValue("@Phone", customer.Phone ?? "");
                        command.Parameters.AddWithValue("@ZipCode", customer.ZipCode ?? "");
                        command.Parameters.AddWithValue("@Address", customer.Address ?? "");
                        command.Parameters.AddWithValue("@Email", customer.Email ?? "");
                        command.Parameters.AddWithValue("@CreatedTime", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"新增客戶失敗：{ex.Message}");
            }
        }

        // 更新客戶
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    // 檢查客戶名稱是否已被其他客戶使用
                    string checkSql = "SELECT COUNT(*) FROM Customer WHERE CustomerName = @CustomerName AND Id != @Id";
                    using (var checkCommand = new SQLiteCommand(checkSql, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                        checkCommand.Parameters.AddWithValue("@Id", customer.Id);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            throw new Exception("客戶名稱已存在！");
                        }
                    }

                    string sql = @"UPDATE Customer SET 
                                  CustomerName = @CustomerName, Phone = @Phone, ZipCode = @ZipCode, 
                                  Address = @Address, Email = @Email 
                                  WHERE Id = @Id";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", customer.Id);
                        command.Parameters.AddWithValue("@CustomerName", customer.CustomerName ?? "");
                        command.Parameters.AddWithValue("@Phone", customer.Phone ?? "");
                        command.Parameters.AddWithValue("@ZipCode", customer.ZipCode ?? "");
                        command.Parameters.AddWithValue("@Address", customer.Address ?? "");
                        command.Parameters.AddWithValue("@Email", customer.Email ?? "");

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"更新客戶失敗：{ex.Message}");
            }
        }

        // 刪除客戶
        public bool DeleteCustomer(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    // 檢查是否有相關的報修單
                    string checkSql = "SELECT COUNT(*) FROM RepairOrder WHERE CustomerName = (SELECT CustomerName FROM Customer WHERE Id = @Id)";
                    using (var checkCommand = new SQLiteCommand(checkSql, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Id", id);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            throw new Exception("此客戶有相關報修單，無法刪除！");
                        }
                    }

                    string sql = "DELETE FROM Customer WHERE Id = @Id";
                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"刪除客戶失敗：{ex.Message}");
            }
        }

        // 根據ID取得客戶
        public Customer GetCustomerById(int id)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customer WHERE Id = @Id";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")), // 修正此行
                                    CustomerName = reader["CustomerName"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    ZipCode = reader["ZipCode"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString())
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"取得客戶資料失敗：{ex.Message}");
            }
        }

        // 根據客戶名稱取得客戶
        public Customer GetCustomerByName(string customerName)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customer WHERE CustomerName = @CustomerName";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Customer
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")), // 修正此行
                                    CustomerName = reader["CustomerName"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    ZipCode = reader["ZipCode"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString())
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"取得客戶資料失敗：{ex.Message}");
            }
        }

        // 查詢客戶
        public DataTable SearchCustomers(Dictionary<string, object> searchParams)
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();

                    string sql = "SELECT * FROM Customer WHERE 1=1";
                    var parameters = new List<SQLiteParameter>();

                    // 建立查詢條件
                    if (searchParams.ContainsKey("CustomerName") && !string.IsNullOrEmpty(searchParams["CustomerName"].ToString()))
                    {
                        sql += " AND CustomerName LIKE @CustomerName";
                        parameters.Add(new SQLiteParameter("@CustomerName", $"%{searchParams["CustomerName"]}%"));
                    }

                    if (searchParams.ContainsKey("Phone") && !string.IsNullOrEmpty(searchParams["Phone"].ToString()))
                    {
                        sql += " AND Phone LIKE @Phone";
                        parameters.Add(new SQLiteParameter("@Phone", $"%{searchParams["Phone"]}%"));
                    }

                    if (searchParams.ContainsKey("Address") && !string.IsNullOrEmpty(searchParams["Address"].ToString()))
                    {
                        sql += " AND Address LIKE @Address";
                        parameters.Add(new SQLiteParameter("@Address", $"%{searchParams["Address"]}%"));
                    }

                    if (searchParams.ContainsKey("Email") && !string.IsNullOrEmpty(searchParams["Email"].ToString()))
                    {
                        sql += " AND Email LIKE @Email";
                        parameters.Add(new SQLiteParameter("@Email", $"%{searchParams["Email"]}%"));
                    }

                    sql += " ORDER BY CustomerName";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());

                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"查詢客戶失敗：{ex.Message}");
            }
        }

        // 取得所有客戶
        public DataTable GetAllCustomers()
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM Customer ORDER BY CustomerName";

                    using (var adapter = new SQLiteDataAdapter(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"取得客戶列表失敗：{ex.Message}");
            }
        }

        // 取得客戶名稱列表
        public List<string> GetCustomerNames()
        {
            List<string> names = new List<string>();
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT CustomerName FROM Customer ORDER BY CustomerName";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                names.Add(reader["CustomerName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"取得客戶名稱列表失敗：{ex.Message}");
            }
            return names;
        }
    }
}