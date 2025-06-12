namespace Final_Project
{
    partial class Form4
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblEnglishName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblISBN1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblPublisher1 = new System.Windows.Forms.Label();
            this.lblAuthor1 = new System.Windows.Forms.Label();
            this.lblEnglishName1 = new System.Windows.Forms.Label();
            this.lblBookName1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookName.Location = new System.Drawing.Point(12, 29);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(48, 24);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "書名";
            // 
            // lblEnglishName
            // 
            this.lblEnglishName.AutoSize = true;
            this.lblEnglishName.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEnglishName.Location = new System.Drawing.Point(12, 79);
            this.lblEnglishName.Name = "lblEnglishName";
            this.lblEnglishName.Size = new System.Drawing.Size(86, 24);
            this.lblEnglishName.TabIndex = 2;
            this.lblEnglishName.Text = "英文書名";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAuthor.Location = new System.Drawing.Point(12, 132);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(48, 24);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "作者";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPublisher.Location = new System.Drawing.Point(12, 189);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(67, 24);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "出版社";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.Location = new System.Drawing.Point(12, 243);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(86, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "出版日期";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblISBN.Location = new System.Drawing.Point(12, 295);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(55, 24);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "ISBN";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBorrow.Location = new System.Drawing.Point(148, 359);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(88, 48);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "借書";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblISBN1
            // 
            this.lblISBN1.AutoSize = true;
            this.lblISBN1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblISBN1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblISBN1.Location = new System.Drawing.Point(110, 295);
            this.lblISBN1.Name = "lblISBN1";
            this.lblISBN1.Size = new System.Drawing.Size(44, 23);
            this.lblISBN1.TabIndex = 13;
            this.lblISBN1.Text = "        ";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate1.Location = new System.Drawing.Point(110, 243);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(44, 23);
            this.lblDate1.TabIndex = 12;
            this.lblDate1.Text = "        ";
            // 
            // lblPublisher1
            // 
            this.lblPublisher1.AutoSize = true;
            this.lblPublisher1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPublisher1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPublisher1.Location = new System.Drawing.Point(110, 189);
            this.lblPublisher1.Name = "lblPublisher1";
            this.lblPublisher1.Size = new System.Drawing.Size(44, 23);
            this.lblPublisher1.TabIndex = 11;
            this.lblPublisher1.Text = "        ";
            // 
            // lblAuthor1
            // 
            this.lblAuthor1.AutoSize = true;
            this.lblAuthor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAuthor1.Location = new System.Drawing.Point(110, 132);
            this.lblAuthor1.Name = "lblAuthor1";
            this.lblAuthor1.Size = new System.Drawing.Size(44, 23);
            this.lblAuthor1.TabIndex = 10;
            this.lblAuthor1.Text = "        ";
            // 
            // lblEnglishName1
            // 
            this.lblEnglishName1.AutoSize = true;
            this.lblEnglishName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnglishName1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEnglishName1.Location = new System.Drawing.Point(110, 79);
            this.lblEnglishName1.Name = "lblEnglishName1";
            this.lblEnglishName1.Size = new System.Drawing.Size(44, 23);
            this.lblEnglishName1.TabIndex = 9;
            this.lblEnglishName1.Text = "        ";
            // 
            // lblBookName1
            // 
            this.lblBookName1.AutoSize = true;
            this.lblBookName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookName1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBookName1.Location = new System.Drawing.Point(110, 29);
            this.lblBookName1.Name = "lblBookName1";
            this.lblBookName1.Size = new System.Drawing.Size(44, 23);
            this.lblBookName1.TabIndex = 8;
            this.lblBookName1.Text = "        ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 427);
            this.Controls.Add(this.lblISBN1);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.lblPublisher1);
            this.Controls.Add(this.lblAuthor1);
            this.Controls.Add(this.lblEnglishName1);
            this.Controls.Add(this.lblBookName1);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblEnglishName);
            this.Controls.Add(this.lblBookName);
            this.Name = "Form4";
            this.Text = "書籍資訊";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblEnglishName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblISBN1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.Label lblPublisher1;
        private System.Windows.Forms.Label lblAuthor1;
        private System.Windows.Forms.Label lblEnglishName1;
        private System.Windows.Forms.Label lblBookName1;
    }
}