using System;
using System.Data.SQLite;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using RepairSystem.Models;

namespace RepairSystem.Helpers
{
    public class DatabaseHelper
    {
        private static readonly string _dataPath = Path.Combine(Application.StartupPath, "Data");
        private static readonly string _dbPath = Path.Combine(_dataPath, "RepairSystem.db");
        private static readonly string _connectionString = $"Data Source={_dbPath};Version=3;";
        private static DatabaseHelper _instance;
        private static readonly object _lock = new object();

        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new DatabaseHelper();
                    }
                }
                return _instance;
            }
        }

        private DatabaseHelper()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!Directory.Exists(_dataPath))
            {
                Directory.CreateDirectory(_dataPath);
            }

            if (!File.Exists(_dbPath))
            {
                CreateDatabase();
            }
        }

        private void CreateDatabase()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string[] createTableQueries =
                {
                    @"CREATE TABLE IF NOT EXISTS SystemConfig (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ConfigKey TEXT NOT NULL UNIQUE,
                        ConfigValue TEXT,
                        UpdatedTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    )",
                    @"CREATE TABLE IF NOT EXISTS Customer (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CustomerName TEXT NOT NULL,
                        TaxId TEXT,
                        Phone TEXT,
                        ZipCode TEXT,
                        Address TEXT,
                        Email TEXT,
                        CreatedTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    )",
                    @"CREATE TABLE IF NOT EXISTS RepairType (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        TypeName TEXT NOT NULL UNIQUE,
                        CreatedTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    )",
                    @"CREATE TABLE IF NOT EXISTS FaultType (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FaultName TEXT NOT NULL UNIQUE,
                        CreatedTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    )",
                    @"CREATE TABLE IF NOT EXISTS RepairOrder (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Type TEXT NOT NULL,
                        CustomerName TEXT NOT NULL,
                        ContactName TEXT,
                        Phone TEXT,
                        StartTime DATETIME NOT NULL,
                        EndTime DATETIME,
                        Model TEXT,
                        FaultDescription TEXT,
                        WorkRecord TEXT,
                        HardwareSpecs TEXT,
                        Engineer TEXT,
                        CreatedTime DATETIME DEFAULT CURRENT_TIMESTAMP
                    )"
                };

                foreach (var query in createTableQueries)
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                InsertDefaultData(connection);
            }
        }

        private void InsertDefaultData(SQLiteConnection connection)
        {
            string[] defaultTypes = { "叫修", "協助", "教學", "其他" };
            foreach (string type in defaultTypes)
            {
                string insertType = "INSERT OR IGNORE INTO RepairType (TypeName) VALUES (@TypeName)";
                using (var command = new SQLiteCommand(insertType, connection))
                {
                    command.Parameters.AddWithValue("@TypeName", type);
                    command.ExecuteNonQuery();
                }
            }

            string[] defaultFaults = { "無法開機", "當機", "連線異常", "列印問題", "其他" };
            foreach (string fault in defaultFaults)
            {
                string insertFault = "INSERT OR IGNORE INTO FaultType (FaultName) VALUES (@FaultName)";
                using (var command = new SQLiteCommand(insertFault, connection))
                {
                    command.Parameters.AddWithValue("@FaultName", fault);
                    command.ExecuteNonQuery();
                }
            }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }

        public void ResetDatabase()
        {
            if (File.Exists(_dbPath))
            {
                File.Delete(_dbPath);
            }

            InitializeDatabase();
        }

        public void SetConfig(string key, string value)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = @"INSERT OR REPLACE INTO SystemConfig (ConfigKey, ConfigValue, UpdatedTime) 
                              VALUES (@Key, @Value, @UpdatedTime)";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Key", key);
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.AddWithValue("@UpdatedTime", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetConfig(string key)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string sql = "SELECT ConfigValue FROM SystemConfig WHERE ConfigKey = @Key";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Key", key);
                    var result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public bool IsFirstTimeSetup()
        {
            string uniName = GetConfig("UniName");
            return string.IsNullOrEmpty(uniName);
        }
    }
}