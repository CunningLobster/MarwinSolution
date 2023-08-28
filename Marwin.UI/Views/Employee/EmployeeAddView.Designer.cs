namespace Marwin.UI.Views.Employee
{
    partial class EmployeeAddView
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TINText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.TINLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ThirdNameText = new System.Windows.Forms.TextBox();
            this.ThirdName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.CausesValidation = false;
            this.CancelButton.Location = new System.Drawing.Point(296, 284);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(102, 57);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(109, 284);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 57);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(546, 30);
            this.HeaderLabel.TabIndex = 19;
            this.HeaderLabel.Text = "Добавить нового сотрудника";
            // 
            // TINText
            // 
            this.TINText.Location = new System.Drawing.Point(246, 213);
            this.TINText.MaximumSize = new System.Drawing.Size(284, 22);
            this.TINText.MinimumSize = new System.Drawing.Size(284, 22);
            this.TINText.Name = "TINText";
            this.TINText.Size = new System.Drawing.Size(284, 22);
            this.TINText.TabIndex = 17;
            this.TINText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TINText_KeyPress);
            this.TINText.Validating += new System.ComponentModel.CancelEventHandler(this.TINText_Validating);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(246, 113);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(284, 22);
            this.FirstNameText.TabIndex = 16;
            this.FirstNameText.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameText_Validating);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(246, 60);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(284, 22);
            this.LastNameText.TabIndex = 15;
            this.LastNameText.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameText_Validating);
            // 
            // TINLabel
            // 
            this.TINLabel.AutoSize = true;
            this.TINLabel.Location = new System.Drawing.Point(13, 219);
            this.TINLabel.Name = "TINLabel";
            this.TINLabel.Size = new System.Drawing.Size(37, 16);
            this.TINLabel.TabIndex = 14;
            this.TINLabel.Text = "ИИН";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 119);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(33, 16);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 60);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 16);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // ThirdNameText
            // 
            this.ThirdNameText.Location = new System.Drawing.Point(245, 162);
            this.ThirdNameText.Name = "ThirdNameText";
            this.ThirdNameText.Size = new System.Drawing.Size(284, 22);
            this.ThirdNameText.TabIndex = 23;
            // 
            // ThirdName
            // 
            this.ThirdName.AutoSize = true;
            this.ThirdName.Location = new System.Drawing.Point(12, 168);
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.Size = new System.Drawing.Size(70, 16);
            this.ThirdName.TabIndex = 22;
            this.ThirdName.Text = "Отчество";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 364);
            this.ControlBox = false;
            this.Controls.Add(this.ThirdNameText);
            this.Controls.Add(this.ThirdName);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.TINText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.TINLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "EmployeeAddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TINText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label TINLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox ThirdNameText;
        private System.Windows.Forms.Label ThirdName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}