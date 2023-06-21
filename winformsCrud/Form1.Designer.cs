namespace winformsCrud
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnSave = new Button();
            dgCustomer = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            dgFname = new DataGridViewTextBoxColumn();
            dgLname = new DataGridViewTextBoxColumn();
            dgCity = new DataGridViewTextBoxColumn();
            TextLn = new TextBox();
            LName = new Label();
            TextFn = new TextBox();
            FName = new Label();
            TextCity = new TextBox();
            City = new Label();
            btnDelete = new Button();
            btnCancel = new Button();
            TextAdress = new TextBox();
            Adress = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(86, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.AllowUserToDeleteRows = false;
            dgCustomer.BackgroundColor = Color.White;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { Id, dgFname, dgLname, dgCity });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            dgCustomer.Location = new Point(455, 12);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.ReadOnly = true;
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
            dgCustomer.RowTemplate.DefaultCellStyle.ForeColor = Color.Red;
            dgCustomer.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 0);
            dgCustomer.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(192, 0, 0);
            dgCustomer.RowTemplate.Height = 30;
            dgCustomer.Size = new Size(562, 452);
            dgCustomer.TabIndex = 1;
            dgCustomer.CellContentClick += dgCustomer_CellContentClick;
            dgCustomer.DoubleClick += dgCustomer_DoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // dgFname
            // 
            dgFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgFname.DataPropertyName = "FirstName";
            dgFname.HeaderText = "First Name";
            dgFname.MinimumWidth = 6;
            dgFname.Name = "dgFname";
            dgFname.ReadOnly = true;
            // 
            // dgLname
            // 
            dgLname.DataPropertyName = "LastName";
            dgLname.HeaderText = "Last Name";
            dgLname.MinimumWidth = 6;
            dgLname.Name = "dgLname";
            dgLname.ReadOnly = true;
            dgLname.Width = 125;
            // 
            // dgCity
            // 
            dgCity.DataPropertyName = "City";
            dgCity.HeaderText = "City";
            dgCity.MinimumWidth = 6;
            dgCity.Name = "dgCity";
            dgCity.ReadOnly = true;
            dgCity.Width = 125;
            // 
            // TextLn
            // 
            TextLn.Location = new Point(105, 77);
            TextLn.Name = "TextLn";
            TextLn.Size = new Size(263, 27);
            TextLn.TabIndex = 2;
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.Location = new Point(13, 87);
            LName.Name = "LName";
            LName.Size = new Size(79, 20);
            LName.TabIndex = 3;
            LName.Text = "Last Name";
            // 
            // TextFn
            // 
            TextFn.Location = new Point(105, 33);
            TextFn.Name = "TextFn";
            TextFn.Size = new Size(263, 27);
            TextFn.TabIndex = 2;
            // 
            // FName
            // 
            FName.AutoSize = true;
            FName.Location = new Point(12, 36);
            FName.Name = "FName";
            FName.Size = new Size(80, 20);
            FName.TabIndex = 3;
            FName.Text = "First Name";
            // 
            // TextCity
            // 
            TextCity.Location = new Point(105, 123);
            TextCity.Name = "TextCity";
            TextCity.Size = new Size(263, 27);
            TextCity.TabIndex = 2;
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(58, 133);
            City.Name = "City";
            City.Size = new Size(34, 20);
            City.TabIndex = 3;
            City.Text = "City";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(286, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // TextAdress
            // 
            TextAdress.Location = new Point(105, 167);
            TextAdress.Multiline = true;
            TextAdress.Name = "TextAdress";
            TextAdress.Size = new Size(263, 77);
            TextAdress.TabIndex = 2;
            // 
            // Adress
            // 
            Adress.AutoSize = true;
            Adress.Location = new Point(39, 177);
            Adress.Name = "Adress";
            Adress.Size = new Size(53, 20);
            Adress.TabIndex = 3;
            Adress.Text = "Adress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 481);
            Controls.Add(FName);
            Controls.Add(Adress);
            Controls.Add(City);
            Controls.Add(LName);
            Controls.Add(TextAdress);
            Controls.Add(TextCity);
            Controls.Add(TextFn);
            Controls.Add(TextLn);
            Controls.Add(dgCustomer);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crud Train";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DataGridView dgCustomer;
        private TextBox TextLn;
        private Label LName;
        private TextBox TextFn;
        private Label FName;
        private TextBox TextCity;
        private Label City;
        private Button btnDelete;
        private Button btnCancel;
        private TextBox TextAdress;
        private Label Adress;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dgFname;
        private DataGridViewTextBoxColumn dgLname;
        private DataGridViewTextBoxColumn dgCity;
    }
}