namespace Final_Project
{
    partial class Form6
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
            this.lblManagerLogIn = new System.Windows.Forms.Label();
            this.lblManagerAccount = new System.Windows.Forms.Label();
            this.lblManagerPassword = new System.Windows.Forms.Label();
            this.txtManagerAccount = new System.Windows.Forms.TextBox();
            this.txtManagerPassword = new System.Windows.Forms.TextBox();
            this.btnManagerLogIn = new System.Windows.Forms.Button();
            this.lblManagerError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblManagerLogIn
            // 
            this.lblManagerLogIn.AutoSize = true;
            this.lblManagerLogIn.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblManagerLogIn.Location = new System.Drawing.Point(220, 29);
            this.lblManagerLogIn.Name = "lblManagerLogIn";
            this.lblManagerLogIn.Size = new System.Drawing.Size(162, 37);
            this.lblManagerLogIn.TabIndex = 0;
            this.lblManagerLogIn.Text = "管理員登入";
            // 
            // lblManagerAccount
            // 
            this.lblManagerAccount.AutoSize = true;
            this.lblManagerAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblManagerAccount.Location = new System.Drawing.Point(133, 109);
            this.lblManagerAccount.Name = "lblManagerAccount";
            this.lblManagerAccount.Size = new System.Drawing.Size(143, 24);
            this.lblManagerAccount.TabIndex = 1;
            this.lblManagerAccount.Text = "管理員帳號名稱";
            // 
            // lblManagerPassword
            // 
            this.lblManagerPassword.AutoSize = true;
            this.lblManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblManagerPassword.Location = new System.Drawing.Point(176, 192);
            this.lblManagerPassword.Name = "lblManagerPassword";
            this.lblManagerPassword.Size = new System.Drawing.Size(48, 24);
            this.lblManagerPassword.TabIndex = 2;
            this.lblManagerPassword.Text = "密碼";
            // 
            // txtManagerAccount
            // 
            this.txtManagerAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtManagerAccount.Location = new System.Drawing.Point(333, 106);
            this.txtManagerAccount.Name = "txtManagerAccount";
            this.txtManagerAccount.Size = new System.Drawing.Size(125, 33);
            this.txtManagerAccount.TabIndex = 3;
            // 
            // txtManagerPassword
            // 
            this.txtManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtManagerPassword.Location = new System.Drawing.Point(333, 183);
            this.txtManagerPassword.Name = "txtManagerPassword";
            this.txtManagerPassword.Size = new System.Drawing.Size(125, 33);
            this.txtManagerPassword.TabIndex = 4;
            // 
            // btnManagerLogIn
            // 
            this.btnManagerLogIn.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnManagerLogIn.Location = new System.Drawing.Point(249, 298);
            this.btnManagerLogIn.Name = "btnManagerLogIn";
            this.btnManagerLogIn.Size = new System.Drawing.Size(86, 50);
            this.btnManagerLogIn.TabIndex = 5;
            this.btnManagerLogIn.Text = "登入";
            this.btnManagerLogIn.UseVisualStyleBackColor = true;
            this.btnManagerLogIn.Click += new System.EventHandler(this.btnManagerLogIn_Click);
            // 
            // lblManagerError
            // 
            this.lblManagerError.AutoSize = true;
            this.lblManagerError.Location = new System.Drawing.Point(206, 248);
            this.lblManagerError.Name = "lblManagerError";
            this.lblManagerError.Size = new System.Drawing.Size(26, 12);
            this.lblManagerError.TabIndex = 6;
            this.lblManagerError.Text = "       ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.lblManagerError);
            this.Controls.Add(this.btnManagerLogIn);
            this.Controls.Add(this.txtManagerPassword);
            this.Controls.Add(this.txtManagerAccount);
            this.Controls.Add(this.lblManagerPassword);
            this.Controls.Add(this.lblManagerAccount);
            this.Controls.Add(this.lblManagerLogIn);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagerLogIn;
        private System.Windows.Forms.Label lblManagerAccount;
        private System.Windows.Forms.Label lblManagerPassword;
        private System.Windows.Forms.TextBox txtManagerAccount;
        private System.Windows.Forms.TextBox txtManagerPassword;
        private System.Windows.Forms.Button btnManagerLogIn;
        private System.Windows.Forms.Label lblManagerError;
    }
}