namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AZToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ZAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBorrowList = new System.Windows.Forms.Button();
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.timerBorrow = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AZToolStripMenuItem
            // 
            this.AZToolStripMenuItem.Name = "AZToolStripMenuItem";
            this.AZToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ZAToolStripMenuItem
            // 
            this.ZAToolStripMenuItem.Name = "ZAToolStripMenuItem";
            this.ZAToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogIn.Location = new System.Drawing.Point(999, 285);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(101, 68);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "登入";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWelcome.Location = new System.Drawing.Point(996, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(109, 29);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "                ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.排序ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(14, 23);
            // 
            // 排序ToolStripMenuItem
            // 
            this.排序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AZToolStripMenuItem1,
            this.ZAToolStripMenuItem1});
            this.排序ToolStripMenuItem.Name = "排序ToolStripMenuItem";
            this.排序ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.排序ToolStripMenuItem.Text = "排序";
            // 
            // AZToolStripMenuItem1
            // 
            this.AZToolStripMenuItem1.Checked = true;
            this.AZToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AZToolStripMenuItem1.Name = "AZToolStripMenuItem1";
            this.AZToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.AZToolStripMenuItem1.Text = "A~Z";
            this.AZToolStripMenuItem1.Click += new System.EventHandler(this.AZToolStripMenuItem1_Click);
            // 
            // ZAToolStripMenuItem1
            // 
            this.ZAToolStripMenuItem1.Name = "ZAToolStripMenuItem1";
            this.ZAToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.ZAToolStripMenuItem1.Text = "Z~A";
            this.ZAToolStripMenuItem1.Click += new System.EventHandler(this.ZAToolStripMenuItem1_Click);
            // 
            // btnBorrowList
            // 
            this.btnBorrowList.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBorrowList.Location = new System.Drawing.Point(959, 396);
            this.btnBorrowList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowList.Name = "btnBorrowList";
            this.btnBorrowList.Size = new System.Drawing.Size(157, 62);
            this.btnBorrowList.TabIndex = 6;
            this.btnBorrowList.Text = "借書清單";
            this.btnBorrowList.UseVisualStyleBackColor = true;
            this.btnBorrowList.Click += new System.EventHandler(this.btnBorrowList_Click);
            // 
            // lvwBooks
            // 
            this.lvwBooks.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.Location = new System.Drawing.Point(33, 102);
            this.lvwBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(863, 520);
            this.lvwBooks.TabIndex = 7;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.View = System.Windows.Forms.View.Details;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 671);
            this.Controls.Add(this.lvwBooks);
            this.Controls.Add(this.btnBorrowList);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "圖書管理系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem AZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZAToolStripMenuItem;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem 排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AZToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ZAToolStripMenuItem1;
        private System.Windows.Forms.Button btnBorrowList;
        private System.Windows.Forms.ListView lvwBooks;
        private System.Windows.Forms.Timer timerBorrow;
    }
}

