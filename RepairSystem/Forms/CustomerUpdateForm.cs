using System;
using System.Data;
using System.Windows.Forms;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class CustomerUpdateForm : Form
    {
        private string originalCustomerName;

        public CustomerUpdateForm(string customerName)
        {
            InitializeComponent();
            originalCustomerName = customerName;
            LoadCustomerData();
            SetupForm();
        }

        private void SetupForm()
        {
            buttonCustomerUpdate.Click += ButtonCustomerUpdate_Click;
            button1.Click += (s, e) => this.Close();
            textBoxTaxId.KeyPress += TextBoxTaxId_KeyPress;
        }

        private void LoadCustomerData()
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Customer WHERE CustomerName = @CustomerName";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", originalCustomerName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxCustomerName.Text = reader["CustomerName"].ToString();
                                textBoxTaxId.Text = reader["TaxId"].ToString();
                                textBox1.Text = reader["Phone"].ToString();
                                textBoxZipCode.Text = reader["ZipCode"].ToString();
                                textBoxAddress.Text = reader["Address"].ToString();
                                textBox2.Text = reader["Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入客戶資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text.Trim();
            string taxId = textBoxTaxId.Text.Trim();
            string phone = textBox1.Text.Trim();
            string zipCode = textBoxZipCode.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string email = textBox2.Text.Trim();

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
                        UPDATE Customer 
                        SET CustomerName = @CustomerName,
                            TaxId = @TaxId,
                            Phone = @Phone,
                            ZipCode = @ZipCode,
                            Address = @Address,
                            Email = @Email
                        WHERE CustomerName = @OriginalCustomerName";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@TaxId", taxId);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@ZipCode", zipCode);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@OriginalCustomerName", originalCustomerName);
                        command.ExecuteNonQuery();
                    }

                    // 如果客戶名稱有更改，同步更新 RepairOrder 表
                    if (customerName != originalCustomerName)
                    {
                        string updateRepairOrder = "UPDATE RepairOrder SET CustomerName = @NewName WHERE CustomerName = @OldName";
                        using (var command = new System.Data.SQLite.SQLiteCommand(updateRepairOrder, connection))
                        {
                            command.Parameters.AddWithValue("@NewName", customerName);
                            command.Parameters.AddWithValue("@OldName", originalCustomerName);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("客戶資料已更新！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新客戶資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxTaxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允許數字與控制鍵（如Backspace）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
