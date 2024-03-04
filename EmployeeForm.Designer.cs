namespace CRUDTreeview
{
    partial class EmployeeForm
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(18, 40);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(128, 19);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Имя сотрудника:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(175, 37);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 24);
            this.name.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(71, 122);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(103, 37);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(195, 122);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 37);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(175, 74);
            this.surname.Margin = new System.Windows.Forms.Padding(4);
            this.surname.MaxLength = 50;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(165, 24);
            this.surname.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 180);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cityLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
    }
}