namespace Final_Project
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.lblBorrowList = new System.Windows.Forms.Label();
            this.lvwBorrowList = new System.Windows.Forms.ListView();
            this.timerBorrow = new System.Windows.Forms.Timer(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorrowList
            // 
            this.lblBorrowList.AutoSize = true;
            this.lblBorrowList.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBorrowList.Location = new System.Drawing.Point(48, 38);
            this.lblBorrowList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowList.Name = "lblBorrowList";
            this.lblBorrowList.Size = new System.Drawing.Size(167, 38);
            this.lblBorrowList.TabIndex = 0;
            this.lblBorrowList.Text = "已借書清單";
            // 
            // lvwBorrowList
            // 
            this.lvwBorrowList.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBorrowList.HideSelection = false;
            this.lvwBorrowList.Location = new System.Drawing.Point(56, 116);
            this.lvwBorrowList.Margin = new System.Windows.Forms.Padding(4);
            this.lvwBorrowList.Name = "lvwBorrowList";
            this.lvwBorrowList.Size = new System.Drawing.Size(894, 353);
            this.lvwBorrowList.TabIndex = 1;
            this.lvwBorrowList.UseCompatibleStateImageBehavior = false;
            this.lvwBorrowList.View = System.Windows.Forms.View.Details;
            this.lvwBorrowList.ItemActivate += new System.EventHandler(this.lvwBorrowList_ItemActivate);
            // 
            // timerBorrow
            // 
            this.timerBorrow.Interval = 3600000;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReload.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Location = new System.Drawing.Point(273, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 55);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "重新整理";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lvwBorrowList);
            this.Controls.Add(this.lblBorrowList);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "借書清單";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrowList;
        private System.Windows.Forms.ListView lvwBorrowList;
        private System.Windows.Forms.Timer timerBorrow;
        private System.Windows.Forms.Button btnReload;
    }
}