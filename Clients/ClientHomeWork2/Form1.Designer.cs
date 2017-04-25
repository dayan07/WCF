namespace ClientHomeWork2
{
    partial class Form1
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnFiles = new System.Windows.Forms.Button();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.btnFolders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(13, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(655, 20);
            this.tbPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(696, 9);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(132, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Select path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(13, 40);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(655, 134);
            this.lbFiles.TabIndex = 2;
            this.lbFiles.Visible = false;
            // 
            // btnFiles
            // 
            this.btnFiles.Location = new System.Drawing.Point(696, 40);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(132, 23);
            this.btnFiles.TabIndex = 3;
            this.btnFiles.Text = "Show files";
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(13, 188);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(655, 134);
            this.lbFolders.TabIndex = 4;
            this.lbFolders.Visible = false;
            // 
            // btnFolders
            // 
            this.btnFolders.Location = new System.Drawing.Point(696, 188);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(132, 23);
            this.btnFolders.TabIndex = 5;
            this.btnFolders.Text = "Show folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 341);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.lbFolders);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.tbPath);
            this.Name = "Form1";
            this.Text = "From Disk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Button btnFolders;
    }
}

