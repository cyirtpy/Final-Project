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
            this.SuspendLayout();
            // 
            // lblBorrowList
            // 
            this.lblBorrowList.AutoSize = true;
            this.lblBorrowList.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBorrowList.Location = new System.Drawing.Point(36, 30);
            this.lblBorrowList.Name = "lblBorrowList";
            this.lblBorrowList.Size = new System.Drawing.Size(134, 31);
            this.lblBorrowList.TabIndex = 0;
            this.lblBorrowList.Text = "已借書清單";
            // 
            // lvwBorrowList
            // 
            this.lvwBorrowList.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvwBorrowList.HideSelection = false;
            this.lvwBorrowList.Location = new System.Drawing.Point(42, 93);
            this.lvwBorrowList.Name = "lvwBorrowList";
            this.lvwBorrowList.Size = new System.Drawing.Size(667, 283);
            this.lvwBorrowList.TabIndex = 1;
            this.lvwBorrowList.UseCompatibleStateImageBehavior = false;
            this.lvwBorrowList.View = System.Windows.Forms.View.Details;
            this.lvwBorrowList.ItemActivate += new System.EventHandler(this.lvwBorrowList_ItemActivate);
            // 
            // timerBorrow
            // 
            this.timerBorrow.Interval = 3600000;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwBorrowList);
            this.Controls.Add(this.lblBorrowList);
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
    }
}