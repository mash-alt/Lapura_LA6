using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LA_6_Final
{
    public partial class UpdateForm : Form
    {
        private readonly string connectionString;
        private int studentId;

        public UpdateForm(string connStr, int id, string name, int age, string address)
        {
            InitializeComponent();
            connectionString = connStr;
            studentId = id;
            txtName.Text = name;
            txtAge.Text = age.ToString();
            txtAddress.Text = address;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show("Please enter a valid non-negative age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            try
            {
                string name = txtName.Text.Trim();
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text.Trim();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Students SET Name = @Name, Age = @Age, Address = @Address WHERE Id = @Id";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Id", studentId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
