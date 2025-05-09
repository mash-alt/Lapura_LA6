using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;
using System.Drawing;

namespace LA_6_Final
{
    partial class MenuPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            panel1 = new Panel();
            lblHeader = new Label();
            panelForm = new Panel();
            btnCreateStudent = new Button();
            txtStudentID = new TextBox();
            lblStudentID = new Label();
            lstDetails = new ListBox();
            btnCreatePerson = new Button();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblAge = new Label();
            lblAddress = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 80);
            panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = System.Drawing.Color.White;
            lblHeader.Location = new Point(25, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(294, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Person Registration";
            // 
            // panelForm
            // 
            panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            panelForm.Controls.Add(btnCreateStudent);
            panelForm.Controls.Add(txtStudentID);
            panelForm.Controls.Add(lblStudentID);
            panelForm.Controls.Add(lstDetails);
            panelForm.Controls.Add(btnCreatePerson);
            panelForm.Controls.Add(txtAge);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(txtName);
            panelForm.Controls.Add(lblAge);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(lblName);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 80);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(30);
            panelForm.Size = new Size(900, 470);
            panelForm.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            lblName.Location = new Point(35, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            lblAddress.Location = new Point(35, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 28);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            lblAge.Location = new Point(35, 100);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(49, 28);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(170, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 34);
            txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = System.Drawing.Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(170, 160);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 34);
            txtAddress.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.BackColor = System.Drawing.Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new System.Drawing.Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(170, 100);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 34);
            txtAge.TabIndex = 5;
            // 
            // btnCreatePerson
            // 
            btnCreatePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            btnCreatePerson.FlatAppearance.BorderSize = 0;
            btnCreatePerson.FlatStyle = FlatStyle.Flat;
            btnCreatePerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatePerson.ForeColor = System.Drawing.Color.White;
            btnCreatePerson.Location = new Point(520, 220);
            btnCreatePerson.Name = "btnCreatePerson";
            btnCreatePerson.Size = new Size(200, 40);
            btnCreatePerson.TabIndex = 6;
            btnCreatePerson.Text = "Create Person";
            btnCreatePerson.UseVisualStyleBackColor = false;
            btnCreatePerson.Click += CreatePerson_Click;
            // 
            // lstDetails
            // 
            lstDetails.BackColor = System.Drawing.Color.White;
            lstDetails.BorderStyle = BorderStyle.FixedSingle;
            lstDetails.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            lstDetails.FormattingEnabled = true;
            lstDetails.ItemHeight = 28;
            lstDetails.Location = new Point(35, 330);
            lstDetails.Name = "lstDetails";
            lstDetails.Size = new Size(830, 114);
            lstDetails.TabIndex = 7;
            lstDetails.DoubleClick += lstDetails_DoubleClick;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = System.Drawing.Color.White;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentID.Location = new Point(170, 220);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(200, 34);
            txtStudentID.TabIndex = 9;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            lblStudentID.Location = new Point(35, 220);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(109, 28);
            lblStudentID.TabIndex = 8;
            lblStudentID.Text = "Student ID";
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(192)))));
            btnCreateStudent.FlatAppearance.BorderSize = 0;
            btnCreateStudent.FlatStyle = FlatStyle.Flat;
            btnCreateStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateStudent.ForeColor = System.Drawing.Color.White;
            btnCreateStudent.Location = new Point(520, 270);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(200, 40);
            btnCreateStudent.TabIndex = 10;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = false;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // 
            // MenuPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panelForm);
            Controls.Add(panel1);
            Name = "MenuPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Registration System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Panel panelForm;
        private Button btnCreateStudent;
        private TextBox txtStudentID;
        private Label lblStudentID;
        private ListBox lstDetails;
        private Button btnCreatePerson;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblAge;
        private Label lblAddress;
        private Label lblName;
    }
}

