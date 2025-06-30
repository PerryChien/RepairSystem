using System;
using System.Data;
using System.Windows.Forms;
using RepairSystem.Helpers;

namespace RepairSystem.Forms
{
    public partial class RepairUpdateForm : Form
    {
        private int repairId = -1;

        public RepairUpdateForm(int id = -1)
        {
            InitializeComponent();
            repairId = id;
            LoadRepairData();
        }

        private void LoadRepairData()
        {
            if (repairId <= 0) return;

            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM RepairOrder WHERE Id = @Id";
                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", repairId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 載入資料到表單控制項
                                comboBoxType.Text = reader["Type"].ToString();
                                textBoxCustomerName.Text = reader["CustomerName"].ToString();
                                textBox1.Text = reader["ContactName"].ToString();
                                textBoxPhone.Text = reader["Phone"].ToString();
                                
                                if (DateTime.TryParse(reader["StartTime"].ToString(), out DateTime startTime))
                                    dateTimePickerStartTime.Value = startTime;
                                    
                                if (DateTime.TryParse(reader["EndTime"].ToString(), out DateTime endTime) && endTime > DateTime.MinValue)
                                    dateTimePickerEndTime.Value = endTime;
                                
                                checkBoxFinish.Checked = !string.IsNullOrEmpty(reader["EndTime"].ToString());
                                textBoxModel.Text = reader["Model"].ToString();
                                comboBoxFaultDescription.Text = reader["FaultDescription"].ToString();
                                textBoxWorkRecord.Text = reader["WorkRecord"].ToString();
                                textBoxHardwareSpecs.Text = reader["HardwareSpecs"].ToString();
                                textBoxEngineer.Text = reader["Engineer"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入報修單資料失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveRepairData()
        {
            try
            {
                using (var connection = DatabaseHelper.Instance.GetConnection())
                {
                    connection.Open();
                    string query = @"
                        UPDATE RepairOrder SET
                            Type = @Type,
                            CustomerName = @CustomerName,
                            ContactName = @ContactName,
                            Phone = @Phone,
                            StartTime = @StartTime,
                            EndTime = @EndTime,
                            Model = @Model,
                            FaultDescription = @FaultDescription,
                            WorkRecord = @WorkRecord,
                            HardwareSpecs = @HardwareSpecs,
                            Engineer = @Engineer
                        WHERE Id = @Id";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", repairId);
                        command.Parameters.AddWithValue("@Type", comboBoxType.Text);
                        command.Parameters.AddWithValue("@CustomerName", textBoxCustomerName.Text);
                        command.Parameters.AddWithValue("@ContactName", textBox1.Text);
                        command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        command.Parameters.AddWithValue("@StartTime", dateTimePickerStartTime.Value);
                        command.Parameters.AddWithValue("@EndTime", checkBoxFinish.Checked ? dateTimePickerEndTime.Value : (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Model", textBoxModel.Text);
                        command.Parameters.AddWithValue("@FaultDescription", comboBoxFaultDescription.Text);
                        command.Parameters.AddWithValue("@WorkRecord", textBoxWorkRecord.Text);
                        command.Parameters.AddWithValue("@HardwareSpecs", textBoxHardwareSpecs.Text);
                        command.Parameters.AddWithValue("@Engineer", textBoxEngineer.Text);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("報修單更新成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("更新失敗，請稍後再試。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存報修單失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (SaveRepairData())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
