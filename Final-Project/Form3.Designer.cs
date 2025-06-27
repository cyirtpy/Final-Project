namespace Final_Project
{
    partial class Form3
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblRegisterAccountName = new System.Windows.Forms.Label();
            this.lblRegisterPasswod = new System.Windows.Forms.Label();
            this.lblRegisterPasswodCheck = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterPasswordCheck = new System.Windows.Forms.TextBox();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft JhengHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegister.Location = new System.Drawing.Point(304, 51);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(168, 47);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "註冊帳號";
            // 
            // lblRegisterAccountName
            // 
            this.lblRegisterAccountName.AutoSize = true;
            this.lblRegisterAccountName.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegisterAccountName.Location = new System.Drawing.Point(231, 145);
            this.lblRegisterAccountName.Name = "lblRegisterAccountName";
            this.lblRegisterAccountName.Size = new System.Drawing.Size(105, 29);
            this.lblRegisterAccountName.TabIndex = 1;
            this.lblRegisterAccountName.Text = "帳號名稱";
            // 
            // lblRegisterPasswod
            // 
            this.lblRegisterPasswod.AutoSize = true;
            this.lblRegisterPasswod.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegisterPasswod.Location = new System.Drawing.Point(251, 210);
            this.lblRegisterPasswod.Name = "lblRegisterPasswod";
            this.lblRegisterPasswod.Size = new System.Drawing.Size(59, 29);
            this.lblRegisterPasswod.TabIndex = 2;
            this.lblRegisterPasswod.Text = "密碼";
            // 
            // lblRegisterPasswodCheck
            // 
            this.lblRegisterPasswodCheck.AutoSize = true;
            this.lblRegisterPasswodCheck.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegisterPasswodCheck.Location = new System.Drawing.Point(231, 271);
            this.lblRegisterPasswodCheck.Name = "lblRegisterPasswodCheck";
            this.lblRegisterPasswodCheck.Size = new System.Drawing.Size(105, 29);
            this.lblRegisterPasswodCheck.TabIndex = 3;
            this.lblRegisterPasswodCheck.Text = "確認密碼";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(395, 136);
            this.txtRegisterUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(187, 38);
            this.txtRegisterUsername.TabIndex = 4;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(395, 201);
            this.txtRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(187, 38);
            this.txtRegisterPassword.TabIndex = 5;
            // 
            // txtRegisterPasswordCheck
            // 
            this.txtRegisterPasswordCheck.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegisterPasswordCheck.Location = new System.Drawing.Point(395, 262);
            this.txtRegisterPasswordCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegisterPasswordCheck.Name = "txtRegisterPasswordCheck";
            this.txtRegisterPasswordCheck.Size = new System.Drawing.Size(187, 38);
            this.txtRegisterPasswordCheck.TabIndex = 6;
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegisterAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegisterAccount.Location = new System.Drawing.Point(324, 351);
            this.btnRegisterAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(139, 65);
            this.btnRegisterAccount.TabIndex = 7;
            this.btnRegisterAccount.Text = "註冊帳號";
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterAccount);
            this.Controls.Add(this.txtRegisterPasswordCheck);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.lblRegisterPasswodCheck);
            this.Controls.Add(this.lblRegisterPasswod);
            this.Controls.Add(this.lblRegisterAccountName);
            this.Controls.Add(this.lblRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "註冊帳號";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblRegisterAccountName;
        private System.Windows.Forms.Label lblRegisterPasswod;
        private System.Windows.Forms.Label lblRegisterPasswodCheck;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterPasswordCheck;
        private System.Windows.Forms.Button btnRegisterAccount;
    }
}