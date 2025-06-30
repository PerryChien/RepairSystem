using System;
using System.Data;
using System.Windows.Forms;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            SetupForm();
            LoadCustomerData();
        }

        private void SetupForm()
        {
            buttonAdd.Click += ButtonAdd_Click;
            buttonCancel.Click += (s, e) => this.Close();

            // 讓 DataGridView 自動產生欄位
            dataGridViewCustomer.AutoGenerateColumns = true;
            dataGridViewCustomer.Columns.Clear();
            dataGridViewCustomer.CellClick += DataGridViewCustomer_CellClick;
        }

        private void LoadCustomerData()
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer ORDER BY CustomerName ASC";

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // 先清除所有欄位
                        dataGridViewCustomer.Columns.Clear();
                        dataGridViewCustomer.AutoGenerateColumns = false;

                        // 添加資料欄位
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "CustomerName",
                            HeaderText = "客戶名稱",
                            DataPropertyName = "CustomerName",
                            Width = 150
                        });
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "TaxId",
                            HeaderText = "統一編號",
                            DataPropertyName = "TaxId",
                            Width = 120
                        });
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "Phone",
                            HeaderText = "連絡電話",
                            DataPropertyName = "Phone",
                            Width = 120
                        });
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "ZipCode",
                            HeaderText = "郵遞區號",
                            DataPropertyName = "ZipCode",
                            Width = 100
                        });
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "Address",
                            HeaderText = "聯絡地址",
                            DataPropertyName = "Address",
                            Width = 200
                        });
                        dataGridViewCustomer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "Email",
                            HeaderText = "電子郵件",
                            DataPropertyName = "Email",
                            Width = 150
                        });

                        // 添加按鈕欄位
                        var editButton = new DataGridViewButtonColumn();
                        editButton.Name = "Edit";
                        editButton.HeaderText = "修改";
                        editButton.Text = "修改";
                        editButton.UseColumnTextForButtonValue = true;
                        editButton.Width = 80;
                        editButton.FlatStyle = FlatStyle.Flat;
                        editButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        editButton.DefaultCellStyle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular);
                        editButton.HeaderCell.Style.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
                        editButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridViewCustomer.Columns.Add(editButton);

                        var deleteButton = new DataGridViewButtonColumn();
                        deleteButton.Name = "Delete";
                        deleteButton.HeaderText = "刪除";
                        deleteButton.Text = "刪除";
                        deleteButton.UseColumnTextForButtonValue = true;
                        deleteButton.Width = 80;
                        deleteButton.FlatStyle = FlatStyle.Flat;
                        deleteButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        deleteButton.DefaultCellStyle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular);
                        deleteButton.HeaderCell.Style.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
                        deleteButton.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridViewCustomer.Columns.Add(deleteButton);

                        // 設置所有資料欄位的樣式
                        foreach (DataGridViewColumn column in dataGridViewCustomer.Columns)
                        {
                            if (column is DataGridViewTextBoxColumn)
                            {
                                column.DefaultCellStyle.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular);
                                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                column.HeaderCell.Style.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
                                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            }
                        }

                        // 設置資料來源
                        dataGridViewCustomer.DataSource = dt;

                        // 確保按鈕文字顯示
                        foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
                        {
                            row.Cells["Edit"].Value = "修改";
                            row.Cells["Delete"].Value = "刪除";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入客戶資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string zipCode = textBoxZipCode.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string taxId = textBoxTaxId.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("客戶名稱不可為空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Customer (CustomerName, TaxId, Phone, ZipCode, Address, Email)
                        VALUES (@CustomerName, @TaxId, @Phone, @ZipCode, @Address, @Email)";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@TaxId", taxId);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@ZipCode", zipCode);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("客戶已新增！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增客戶失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否點擊了有效的儲存格（非標頭列）
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dataGridViewCustomer.Rows[e.RowIndex];
            if (!dataGridViewCustomer.Columns.Contains("CustomerName") || row.Cells["CustomerName"].Value == null)
            {
                MessageBox.Show("找不到客戶名稱資料，請檢查資料表結構與欄位名稱。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 取得點擊的欄位名稱
            string columnName = dataGridViewCustomer.Columns[e.ColumnIndex].Name;
            string customerName = row.Cells["CustomerName"].Value.ToString();

            // 根據點擊的按鈕執行相應操作
            if (columnName == "Edit")
            {
                EditCustomer(customerName);
            }
            else if (columnName == "Delete")
            {
                DeleteCustomer(customerName);
            }
        }

        private void EditCustomer(string customerName)
        {
            using (var updateForm = new CustomerUpdateForm(customerName))
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerData();
                }
            }
        }

        private void DeleteCustomer(string customerName)
        {
            if (MessageBox.Show($"確定要刪除 {customerName} 嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var connection = DatabaseHelper.Instance.GetConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM Customer WHERE CustomerName = @CustomerName";

                        using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerName", customerName);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("客戶已刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"刪除客戶失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 新增一個方法：同步更新 RepairOrder 的 CustomerName
        private void UpdateCustomerNameEverywhere(string oldName, string newName)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                // 更新 Customer
                string updateCustomer = "UPDATE Customer SET CustomerName = @NewName WHERE CustomerName = @OldName";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(updateCustomer, connection))
                {
                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@OldName", oldName);
                    cmd.ExecuteNonQuery();
                }
                // 同步更新 RepairOrder
                string updateRepairOrder = "UPDATE RepairOrder SET CustomerName = @NewName WHERE CustomerName = @OldName";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(updateRepairOrder, connection))
                {
                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@OldName", oldName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void textBoxTaxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允許數字與控制鍵（如Backspace）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}