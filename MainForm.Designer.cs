namespace CRUDTreeview
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.load_btn = new System.Windows.Forms.Button();
            this.dropDown = new System.Windows.Forms.Button();
            this.rollUp = new System.Windows.Forms.Button();
            this.officeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьОфисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьОфисToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьКомандуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьДанныеОСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНазваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addOfficeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.Label();
            this.addOffice_another = new System.Windows.Forms.Button();
            this.officeMenu.SuspendLayout();
            this.teamMenu.SuspendLayout();
            this.employeeMenu.SuspendLayout();
            this.commonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Enabled = false;
            this.treeView.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(-1, -1);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(558, 415);
            this.treeView.TabIndex = 0;
            // 
            // load_btn
            // 
            this.load_btn.BackColor = System.Drawing.Color.Lime;
            this.load_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_btn.Location = new System.Drawing.Point(406, 424);
            this.load_btn.Margin = new System.Windows.Forms.Padding(4);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(134, 42);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Загрузить";
            this.load_btn.UseVisualStyleBackColor = false;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // dropDown
            // 
            this.dropDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropDown.Location = new System.Drawing.Point(100, 424);
            this.dropDown.Margin = new System.Windows.Forms.Padding(4);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(145, 42);
            this.dropDown.TabIndex = 2;
            this.dropDown.Text = "Раскрыть все";
            this.dropDown.UseVisualStyleBackColor = true;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // rollUp
            // 
            this.rollUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollUp.Location = new System.Drawing.Point(253, 424);
            this.rollUp.Margin = new System.Windows.Forms.Padding(4);
            this.rollUp.Name = "rollUp";
            this.rollUp.Size = new System.Drawing.Size(145, 42);
            this.rollUp.TabIndex = 3;
            this.rollUp.Text = "Свернуть все";
            this.rollUp.UseVisualStyleBackColor = true;
            this.rollUp.Click += new System.EventHandler(this.rollUp_Click);
            // 
            // officeMenu
            // 
            this.officeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.officeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОфисToolStripMenuItem,
            this.changeCity,
            this.toolStripMenuItem1,
            this.удалитьОфисToolStripMenuItem1});
            this.officeMenu.Name = "officeMenu";
            this.officeMenu.Size = new System.Drawing.Size(227, 76);
            // 
            // добавитьОфисToolStripMenuItem
            // 
            this.добавитьОфисToolStripMenuItem.Name = "добавитьОфисToolStripMenuItem";
            this.добавитьОфисToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.добавитьОфисToolStripMenuItem.Text = "Добавить команду в офис...";
            this.добавитьОфисToolStripMenuItem.Click += new System.EventHandler(this.addTeam);
            // 
            // changeCity
            // 
            this.changeCity.Name = "changeCity";
            this.changeCity.Size = new System.Drawing.Size(226, 22);
            this.changeCity.Text = "Изменить город...";
            this.changeCity.Click += new System.EventHandler(this.editoffice);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // удалитьОфисToolStripMenuItem1
            // 
            this.удалитьОфисToolStripMenuItem1.Name = "удалитьОфисToolStripMenuItem1";
            this.удалитьОфисToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.удалитьОфисToolStripMenuItem1.Text = "Удалить офис";
            this.удалитьОфисToolStripMenuItem1.Click += new System.EventHandler(this.deleteOffice);
            // 
            // teamMenu
            // 
            this.teamMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teamMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКомандуToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.удалитьКомандуToolStripMenuItem});
            this.teamMenu.Name = "teamMenu";
            this.teamMenu.Size = new System.Drawing.Size(256, 76);
            // 
            // добавитьКомандуToolStripMenuItem
            // 
            this.добавитьКомандуToolStripMenuItem.Name = "добавитьКомандуToolStripMenuItem";
            this.добавитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.добавитьКомандуToolStripMenuItem.Text = "Добавить работника в команду...";
            this.добавитьКомандуToolStripMenuItem.Click += new System.EventHandler(this.addEmployee);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.удалитьToolStripMenuItem.Text = "Изменить название...";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.editTeam);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(252, 6);
            // 
            // удалитьКомандуToolStripMenuItem
            // 
            this.удалитьКомандуToolStripMenuItem.Name = "удалитьКомандуToolStripMenuItem";
            this.удалитьКомандуToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.удалитьКомандуToolStripMenuItem.Text = "Удалить команду";
            this.удалитьКомандуToolStripMenuItem.Click += new System.EventHandler(this.deleteTeam);
            // 
            // employeeMenu
            // 
            this.employeeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьДанныеОСотрудникеToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.удалитьСотрудникаToolStripMenuItem});
            this.employeeMenu.Name = "employeeMenu";
            this.employeeMenu.Size = new System.Drawing.Size(258, 54);
            // 
            // изменитьДанныеОСотрудникеToolStripMenuItem
            // 
            this.изменитьДанныеОСотрудникеToolStripMenuItem.Name = "изменитьДанныеОСотрудникеToolStripMenuItem";
            this.изменитьДанныеОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.изменитьДанныеОСотрудникеToolStripMenuItem.Text = "Изменить данные о сотруднике...";
            this.изменитьДанныеОСотрудникеToolStripMenuItem.Click += new System.EventHandler(this.editEmployee);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // удалитьСотрудникаToolStripMenuItem
            // 
            this.удалитьСотрудникаToolStripMenuItem.Name = "удалитьСотрудникаToolStripMenuItem";
            this.удалитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.удалитьСотрудникаToolStripMenuItem.Text = "Удалить сотрудника";
            this.удалитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployee);
            // 
            // изменитьНазваниеToolStripMenuItem
            // 
            this.изменитьНазваниеToolStripMenuItem.Name = "изменитьНазваниеToolStripMenuItem";
            this.изменитьНазваниеToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.изменитьНазваниеToolStripMenuItem.Text = "Изменить название...";
            // 
            // commonMenu
            // 
            this.commonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOfficeMenu});
            this.commonMenu.Name = "commonMenu";
            this.commonMenu.Size = new System.Drawing.Size(207, 26);
            // 
            // addOfficeMenu
            // 
            this.addOfficeMenu.Name = "addOfficeMenu";
            this.addOfficeMenu.Size = new System.Drawing.Size(206, 22);
            this.addOfficeMenu.Text = "Добавить новый офис...";
            this.addOfficeMenu.Click += new System.EventHandler(this.addOffice);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.White;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(12, 9);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(118, 24);
            this.text.TabIndex = 5;
            this.text.Text = "DATA_NULL";
            // 
            // addOffice_another
            // 
            this.addOffice_another.Enabled = false;
            this.addOffice_another.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOffice_another.Location = new System.Drawing.Point(16, 424);
            this.addOffice_another.Margin = new System.Windows.Forms.Padding(4);
            this.addOffice_another.Name = "addOffice_another";
            this.addOffice_another.Size = new System.Drawing.Size(76, 42);
            this.addOffice_another.TabIndex = 6;
            this.addOffice_another.Text = "+Оффис";
            this.addOffice_another.UseVisualStyleBackColor = true;
            this.addOffice_another.Click += new System.EventHandler(this.addOffice_another_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 476);
            this.Controls.Add(this.addOffice_another);
            this.Controls.Add(this.text);
            this.Controls.Add(this.rollUp);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.treeView);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView CRUD";
            this.officeMenu.ResumeLayout(false);
            this.teamMenu.ResumeLayout(false);
            this.employeeMenu.ResumeLayout(false);
            this.commonMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button dropDown;
        private System.Windows.Forms.Button rollUp;
        private System.Windows.Forms.ContextMenuStrip officeMenu;
        private System.Windows.Forms.ContextMenuStrip teamMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьОфисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCity;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip employeeMenu;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеОСотрудникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьОфисToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьНазваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьКомандуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip commonMenu;
        private System.Windows.Forms.ToolStripMenuItem addOfficeMenu;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button addOffice_another;
    }
}

