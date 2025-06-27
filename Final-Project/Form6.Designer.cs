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
            this.lblManagerLogIn.Location = new System.Drawing.Point(293, 36);
            this.lblManagerLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerLogIn.Name = "lblManagerLogIn";
            this.lblManagerLogIn.Size = new System.Drawing.Size(205, 47);
            this.lblManagerLogIn.TabIndex = 0;
            this.lblManagerLogIn.Text = "管理員登入";
            // 
            // lblManagerAccount
            // 
            this.lblManagerAccount.AutoSize = true;
            this.lblManagerAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblManagerAccount.Location = new System.Drawing.Point(177, 136);
            this.lblManagerAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerAccount.Name = "lblManagerAccount";
            this.lblManagerAccount.Size = new System.Drawing.Size(182, 31);
            this.lblManagerAccount.TabIndex = 1;
            this.lblManagerAccount.Text = "管理員帳號名稱";
            // 
            // lblManagerPassword
            // 
            this.lblManagerPassword.AutoSize = true;
            this.lblManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblManagerPassword.Location = new System.Drawing.Point(235, 240);
            this.lblManagerPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerPassword.Name = "lblManagerPassword";
            this.lblManagerPassword.Size = new System.Drawing.Size(62, 31);
            this.lblManagerPassword.TabIndex = 2;
            this.lblManagerPassword.Text = "密碼";
            // 
            // txtManagerAccount
            // 
            this.txtManagerAccount.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtManagerAccount.Location = new System.Drawing.Point(444, 132);
            this.txtManagerAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManagerAccount.Name = "txtManagerAccount";
            this.txtManagerAccount.Size = new System.Drawing.Size(165, 39);
            this.txtManagerAccount.TabIndex = 3;
            // 
            // txtManagerPassword
            // 
            this.txtManagerPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtManagerPassword.Location = new System.Drawing.Point(444, 229);
            this.txtManagerPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManagerPassword.Name = "txtManagerPassword";
            this.txtManagerPassword.Size = new System.Drawing.Size(165, 39);
            this.txtManagerPassword.TabIndex = 4;
            // 
            // btnManagerLogIn
            // 
            this.btnManagerLogIn.BackColor = System.Drawing.Color.LightSalmon;
            this.btnManagerLogIn.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnManagerLogIn.Location = new System.Drawing.Point(332, 372);
            this.btnManagerLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManagerLogIn.Name = "btnManagerLogIn";
            this.btnManagerLogIn.Size = new System.Drawing.Size(115, 62);
            this.btnManagerLogIn.TabIndex = 5;
            this.btnManagerLogIn.Text = "登入";
            this.btnManagerLogIn.UseVisualStyleBackColor = false;
            this.btnManagerLogIn.Click += new System.EventHandler(this.btnManagerLogIn_Click);
            // 
            // lblManagerError
            // 
            this.lblManagerError.AutoSize = true;
            this.lblManagerError.Location = new System.Drawing.Point(298, 310);
            this.lblManagerError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerError.Name = "lblManagerError";
            this.lblManagerError.Size = new System.Drawing.Size(35, 15);
            this.lblManagerError.TabIndex = 6;
            this.lblManagerError.Text = "       ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblManagerError);
            this.Controls.Add(this.btnManagerLogIn);
            this.Controls.Add(this.txtManagerPassword);
            this.Controls.Add(this.txtManagerAccount);
            this.Controls.Add(this.lblManagerPassword);
            this.Controls.Add(this.lblManagerAccount);
            this.Controls.Add(this.lblManagerLogIn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "管理員登入";
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