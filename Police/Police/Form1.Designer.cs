namespace Police
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
            this.rem_pass = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ProblemLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rem_pass
            // 
            this.rem_pass.AutoSize = true;
            this.rem_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rem_pass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rem_pass.Location = new System.Drawing.Point(70, 9);
            this.rem_pass.Name = "rem_pass";
            this.rem_pass.Size = new System.Drawing.Size(326, 37);
            this.rem_pass.TabIndex = 3;
            this.rem_pass.Text = "POLICE ACCOUNT ";
            // 
            // LoginField
            // 
            this.LoginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(129, 131);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(284, 35);
            this.LoginField.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(129, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(284, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "PASS";
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Location = new System.Drawing.Point(19, 262);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(418, 31);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "ENTER";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // ProblemLogin
            // 
            this.ProblemLogin.AutoSize = true;
            this.ProblemLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProblemLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProblemLogin.Location = new System.Drawing.Point(184, 313);
            this.ProblemLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProblemLogin.Name = "ProblemLogin";
            this.ProblemLogin.Size = new System.Drawing.Size(92, 16);
            this.ProblemLogin.TabIndex = 9;
            this.ProblemLogin.Text = "Registration";
            this.ProblemLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProblemLogin.Click += new System.EventHandler(this.ProblemLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 405);
            this.Controls.Add(this.ProblemLogin);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.rem_pass);
            this.Name = "Form1";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rem_pass;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ProblemLogin;
    }
}

