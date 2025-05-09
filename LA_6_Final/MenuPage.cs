using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA_6_Final
{
    public partial class MenuPage : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\zach\Documents\Students.accdb; Persist Security Info=True;";

        public MenuPage()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is initialized
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text;

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (Name, Age, Address) VALUES (@Name, @Age, @Address)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Person added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstDetails.SelectedItem == null)
                {
                    MessageBox.Show("Please select a record to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] selectedData = lstDetails.SelectedItem.ToString().Split(',');
                int id = int.Parse(selectedData[0]); // Assuming ID is the first column
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text;

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Students SET Name = @Name, Age = @Age, Address = @Address WHERE Id = @Id";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstDetails.SelectedItem == null)
                {
                    MessageBox.Show("Please select a record to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] selectedData = lstDetails.SelectedItem.ToString().Split(',');
                int id = int.Parse(selectedData[0]); // Assuming ID is the first column

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Students WHERE Id = @Id";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                lstDetails.Items.Clear();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Students";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lstDetails.Items.Add($"{reader["Id"]}, {reader["Name"]}, {reader["Age"]}, {reader["Address"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string address = txtAddress.Text;
                int studentId;
                if (!int.TryParse(txtStudentID.Text, out studentId))
                {
                    MessageBox.Show("Please enter a valid Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (Id, Name, Age, Address) VALUES (@Id, @Name, @Age, @Address)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", studentId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Address", address);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CREATE using DataAdapter and CommandBuilder
        private void CreateWithAdapter(string name, int age, string address)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Students";
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Students");
                DataRow row = ds.Tables["Students"].NewRow();
                row["Name"] = name;
                row["Age"] = age;
                row["Address"] = address;
                ds.Tables["Students"].Rows.Add(row);
                adapter.Update(ds, "Students");
            }
        }

        // READ using DataReader
        private void ReadWithDataReader()
        {
            lstDetails.Items.Clear();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Students";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstDetails.Items.Add($"{reader["Id"]}, {reader["Name"]}, {reader["Age"]}, {reader["Address"]}");
                    }
                }
            }
        }

        // UPDATE using DataAdapter and CommandBuilder
        private void UpdateWithAdapter(int id, string name, int age, string address)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM Students WHERE Id = {id}";
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Students");
                if (ds.Tables["Students"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Students"].Rows[0];
                    row["Name"] = name;
                    row["Age"] = age;
                    row["Address"] = address;
                    adapter.Update(ds, "Students");
                }
            }
        }

        // DELETE using DataAdapter and CommandBuilder
        private void DeleteWithAdapter(int id)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM Students WHERE Id = {id}";
                OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Students");
                if (ds.Tables["Students"].Rows.Count > 0)
                {
                    ds.Tables["Students"].Rows[0].Delete();
                    adapter.Update(ds, "Students");
                }
            }
        }

        private void lstDetails_DoubleClick(object sender, EventArgs e)
        {
            if (lstDetails.SelectedItem != null)
            {
                string[] selectedData = lstDetails.SelectedItem.ToString().Split(',');
                int id = int.Parse(selectedData[0]);
                string name = selectedData[1].Trim();
                int age = int.Parse(selectedData[2]);
                string address = selectedData[3].Trim();
                var updateForm = new UpdateForm(connectionString, id, name, age, address);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }

}
