namespace ClientConverter
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
            this.tbMet = new System.Windows.Forms.TextBox();
            this.btnMet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYard = new System.Windows.Forms.TextBox();
            this.tbFoot = new System.Windows.Forms.TextBox();
            this.tbInch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFar = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.tbCel = new System.Windows.Forms.TextBox();
            this.tbFar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMet
            // 
            this.tbMet.Location = new System.Drawing.Point(130, 12);
            this.tbMet.Name = "tbMet";
            this.tbMet.Size = new System.Drawing.Size(143, 20);
            this.tbMet.TabIndex = 0;
            this.tbMet.TextChanged += new System.EventHandler(this.tbMet_TextChanged);
            // 
            // btnMet
            // 
            this.btnMet.Location = new System.Drawing.Point(23, 9);
            this.btnMet.Name = "btnMet";
            this.btnMet.Size = new System.Drawing.Size(91, 23);
            this.btnMet.TabIndex = 1;
            this.btnMet.Text = "Enter meters";
            this.btnMet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "meters";
            // 
            // tbYard
            // 
            this.tbYard.Location = new System.Drawing.Point(338, 87);
            this.tbYard.Name = "tbYard";
            this.tbYard.Size = new System.Drawing.Size(163, 20);
            this.tbYard.TabIndex = 3;
            // 
            // tbFoot
            // 
            this.tbFoot.Location = new System.Drawing.Point(338, 49);
            this.tbFoot.Name = "tbFoot";
            this.tbFoot.Size = new System.Drawing.Size(163, 20);
            this.tbFoot.TabIndex = 4;
            // 
            // tbInch
            // 
            this.tbInch.Location = new System.Drawing.Point(338, 14);
            this.tbInch.Name = "tbInch";
            this.tbInch.Size = new System.Drawing.Size(163, 20);
            this.tbInch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "footes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "yardes";
            // 
            // btnFar
            // 
            this.btnFar.Location = new System.Drawing.Point(23, 255);
            this.btnFar.Name = "btnFar";
            this.btnFar.Size = new System.Drawing.Size(91, 23);
            this.btnFar.TabIndex = 9;
            this.btnFar.Text = "Enter fahrenheit";
            this.btnFar.UseVisualStyleBackColor = true;
            // 
            // btnCel
            // 
            this.btnCel.Location = new System.Drawing.Point(23, 153);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(91, 23);
            this.btnCel.TabIndex = 10;
            this.btnCel.Text = "Enter celsius";
            this.btnCel.UseVisualStyleBackColor = true;
            // 
            // tbCel
            // 
            this.tbCel.Location = new System.Drawing.Point(130, 156);
            this.tbCel.Name = "tbCel";
            this.tbCel.Size = new System.Drawing.Size(143, 20);
            this.tbCel.TabIndex = 11;
            this.tbCel.TextChanged += new System.EventHandler(this.tbCel_TextChanged);
            // 
            // tbFar
            // 
            this.tbFar.Location = new System.Drawing.Point(130, 258);
            this.tbFar.Name = "tbFar";
            this.tbFar.Size = new System.Drawing.Size(143, 20);
            this.tbFar.TabIndex = 12;
            this.tbFar.TextChanged += new System.EventHandler(this.tbFar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "celsius";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 335);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFar);
            this.Controls.Add(this.tbCel);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.btnFar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInch);
            this.Controls.Add(this.tbFoot);
            this.Controls.Add(this.tbYard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMet);
            this.Controls.Add(this.tbMet);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMet;
        private System.Windows.Forms.Button btnMet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYard;
        private System.Windows.Forms.TextBox tbFoot;
        private System.Windows.Forms.TextBox tbInch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFar;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.TextBox tbCel;
        private System.Windows.Forms.TextBox tbFar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

