namespace Marwin.UI
{
    partial class HomeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CompanyTableLabel = new System.Windows.Forms.Label();
            this.CompaniesGridView = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesTableLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateCompany = new System.Windows.Forms.Button();
            this.DeleteCompany = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.ImportCSVButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ExportCSVButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyTableLabel
            // 
            this.CompanyTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyTableLabel.Location = new System.Drawing.Point(13, 98);
            this.CompanyTableLabel.Name = "CompanyTableLabel";
            this.CompanyTableLabel.Size = new System.Drawing.Size(562, 30);
            this.CompanyTableLabel.TabIndex = 0;
            this.CompanyTableLabel.Text = "Компании";
            // 
            // CompaniesGridView
            // 
            this.CompaniesGridView.AllowUserToAddRows = false;
            this.CompaniesGridView.AllowUserToDeleteRows = false;
            this.CompaniesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompaniesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.BIN,
            this.Address,
            this.Note});
            this.CompaniesGridView.Location = new System.Drawing.Point(17, 131);
            this.CompaniesGridView.Name = "CompaniesGridView";
            this.CompaniesGridView.ReadOnly = true;
            this.CompaniesGridView.RowHeadersWidth = 51;
            this.CompaniesGridView.RowTemplate.Height = 24;
            this.CompaniesGridView.Size = new System.Drawing.Size(558, 253);
            this.CompaniesGridView.TabIndex = 1;
            this.CompaniesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompaniesGridView_RowEnter);
            // 
            // CompanyId
            // 
            this.CompanyId.HeaderText = "CompanyId";
            this.CompanyId.MinimumWidth = 6;
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.ReadOnly = true;
            this.CompanyId.Visible = false;
            this.CompanyId.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Наименование";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 125;
            // 
            // BIN
            // 
            this.BIN.HeaderText = "БИН";
            this.BIN.MinimumWidth = 6;
            this.BIN.Name = "BIN";
            this.BIN.ReadOnly = true;
            this.BIN.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Физический Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Примечание";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.AllowUserToAddRows = false;
            this.EmployeesGridView.AllowUserToDeleteRows = false;
            this.EmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.LastName,
            this.FirstName,
            this.ThirdName,
            this.TIN});
            this.EmployeesGridView.Location = new System.Drawing.Point(679, 131);
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.ReadOnly = true;
            this.EmployeesGridView.RowHeadersWidth = 51;
            this.EmployeesGridView.RowTemplate.Height = 24;
            this.EmployeesGridView.Size = new System.Drawing.Size(542, 253);
            this.EmployeesGridView.TabIndex = 2;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // ThirdName
            // 
            this.ThirdName.HeaderText = "Отчество";
            this.ThirdName.MinimumWidth = 6;
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            this.ThirdName.Width = 125;
            // 
            // TIN
            // 
            this.TIN.HeaderText = "ИИН";
            this.TIN.MinimumWidth = 6;
            this.TIN.Name = "TIN";
            this.TIN.ReadOnly = true;
            this.TIN.Width = 125;
            // 
            // EmployeesTableLabel
            // 
            this.EmployeesTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeesTableLabel.Location = new System.Drawing.Point(675, 98);
            this.EmployeesTableLabel.Name = "EmployeesTableLabel";
            this.EmployeesTableLabel.Size = new System.Drawing.Size(546, 30);
            this.EmployeesTableLabel.TabIndex = 3;
            this.EmployeesTableLabel.Text = "Сотрудники";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(17, 391);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(147, 51);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить компанию";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateCompany
            // 
            this.UpdateCompany.Location = new System.Drawing.Point(179, 390);
            this.UpdateCompany.Name = "UpdateCompany";
            this.UpdateCompany.Size = new System.Drawing.Size(159, 51);
            this.UpdateCompany.TabIndex = 5;
            this.UpdateCompany.Text = "Обновить компанию";
            this.UpdateCompany.UseVisualStyleBackColor = true;
            this.UpdateCompany.Click += new System.EventHandler(this.UpdateCompany_Click);
            // 
            // DeleteCompany
            // 
            this.DeleteCompany.Location = new System.Drawing.Point(428, 391);
            this.DeleteCompany.Name = "DeleteCompany";
            this.DeleteCompany.Size = new System.Drawing.Size(147, 51);
            this.DeleteCompany.TabIndex = 6;
            this.DeleteCompany.Text = "Удалить компанию";
            this.DeleteCompany.UseVisualStyleBackColor = true;
            this.DeleteCompany.Click += new System.EventHandler(this.DeleteCompany_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(1065, 391);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(156, 51);
            this.DeleteEmployeeButton.TabIndex = 9;
            this.DeleteEmployeeButton.Text = "Удалить сотрудника";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(843, 390);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(159, 51);
            this.UpdateEmployeeButton.TabIndex = 8;
            this.UpdateEmployeeButton.Text = "Обновить сотрудника";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(679, 391);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(158, 51);
            this.AddEmployeeButton.TabIndex = 7;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // ImportCSVButton
            // 
            this.ImportCSVButton.Location = new System.Drawing.Point(12, 467);
            this.ImportCSVButton.Name = "ImportCSVButton";
            this.ImportCSVButton.Size = new System.Drawing.Size(563, 51);
            this.ImportCSVButton.TabIndex = 10;
            this.ImportCSVButton.Text = "Загрузить список сотрудников из CSV файла";
            this.ImportCSVButton.UseVisualStyleBackColor = true;
            this.ImportCSVButton.Click += new System.EventHandler(this.ImportCSVButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // companyModelBindingSource
            // 
            this.companyModelBindingSource.DataSource = typeof(Marwin.UI.Models.CompanyModel);
            // 
            // companyModelBindingSource1
            // 
            this.companyModelBindingSource1.DataSource = typeof(Marwin.UI.Models.CompanyModel);
            // 
            // ExportCSVButton
            // 
            this.ExportCSVButton.Location = new System.Drawing.Point(679, 467);
            this.ExportCSVButton.Name = "ExportCSVButton";
            this.ExportCSVButton.Size = new System.Drawing.Size(542, 51);
            this.ExportCSVButton.TabIndex = 11;
            this.ExportCSVButton.Text = " Выгрузить список сотрудников в CSV файл";
            this.ExportCSVButton.UseVisualStyleBackColor = true;
            this.ExportCSVButton.Click += new System.EventHandler(this.ExportCSVButton_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 544);
            this.Controls.Add(this.ExportCSVButton);
            this.Controls.Add(this.ImportCSVButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.UpdateCompany);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EmployeesTableLabel);
            this.Controls.Add(this.EmployeesGridView);
            this.Controls.Add(this.CompaniesGridView);
            this.Controls.Add(this.CompanyTableLabel);
            this.Name = "HomeView";
            this.Text = "Companies Manager";
            this.Load += new System.EventHandler(this.HomeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CompanyTableLabel;
        private System.Windows.Forms.DataGridView CompaniesGridView;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
        private System.Windows.Forms.BindingSource companyModelBindingSource1;
        private System.Windows.Forms.DataGridView EmployeesGridView;
        private System.Windows.Forms.Label EmployeesTableLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIN;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateCompany;
        private System.Windows.Forms.Button DeleteCompany;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Button ImportCSVButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ExportCSVButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

