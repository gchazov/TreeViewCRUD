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
            this.treeView = new System.Windows.Forms.TreeView();
            this.load_btn = new System.Windows.Forms.Button();
            this.dropDown = new System.Windows.Forms.Button();
            this.rollUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(60, 43);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(306, 271);
            this.treeView.TabIndex = 0;
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(153, 336);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(122, 23);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "LOAD DATA";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // dropDown
            // 
            this.dropDown.Location = new System.Drawing.Point(416, 84);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(137, 23);
            this.dropDown.TabIndex = 2;
            this.dropDown.Text = "DROP DOWN ALL";
            this.dropDown.UseVisualStyleBackColor = true;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // rollUp
            // 
            this.rollUp.Location = new System.Drawing.Point(416, 144);
            this.rollUp.Name = "rollUp";
            this.rollUp.Size = new System.Drawing.Size(137, 23);
            this.rollUp.TabIndex = 3;
            this.rollUp.Text = "ROLL UP ALL";
            this.rollUp.UseVisualStyleBackColor = true;
            this.rollUp.Click += new System.EventHandler(this.rollUp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rollUp);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.treeView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button dropDown;
        private System.Windows.Forms.Button rollUp;
    }
}

