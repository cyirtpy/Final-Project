namespace Final_Project
{
    partial class Form8
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
            this.lblEditBookName = new System.Windows.Forms.Label();
            this.lblEditEnglishName = new System.Windows.Forms.Label();
            this.lblEditAuthor = new System.Windows.Forms.Label();
            this.lblEditPublisher = new System.Windows.Forms.Label();
            this.lblEditDate = new System.Windows.Forms.Label();
            this.lblEditISBN = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEditBookName = new System.Windows.Forms.TextBox();
            this.txtEditEnglishName = new System.Windows.Forms.TextBox();
            this.txtEditAuthor = new System.Windows.Forms.TextBox();
            this.txtEditPublisher = new System.Windows.Forms.TextBox();
            this.txtEditYear = new System.Windows.Forms.TextBox();
            this.txtEditISBN = new System.Windows.Forms.TextBox();
            this.txtEditMonth = new System.Windows.Forms.TextBox();
            this.txtEditDay = new System.Windows.Forms.TextBox();
            this.lblEditYear = new System.Windows.Forms.Label();
            this.lblEditMonth = new System.Windows.Forms.Label();
            this.lblEditDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditBookName
            // 
            this.lblEditBookName.AutoSize = true;
            this.lblEditBookName.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditBookName.Location = new System.Drawing.Point(36, 44);
            this.lblEditBookName.Name = "lblEditBookName";
            this.lblEditBookName.Size = new System.Drawing.Size(53, 24);
            this.lblEditBookName.TabIndex = 0;
            this.lblEditBookName.Text = "書名:";
            // 
            // lblEditEnglishName
            // 
            this.lblEditEnglishName.AutoSize = true;
            this.lblEditEnglishName.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditEnglishName.Location = new System.Drawing.Point(36, 97);
            this.lblEditEnglishName.Name = "lblEditEnglishName";
            this.lblEditEnglishName.Size = new System.Drawing.Size(91, 24);
            this.lblEditEnglishName.TabIndex = 1;
            this.lblEditEnglishName.Text = "英文書名:";
            // 
            // lblEditAuthor
            // 
            this.lblEditAuthor.AutoSize = true;
            this.lblEditAuthor.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditAuthor.Location = new System.Drawing.Point(36, 151);
            this.lblEditAuthor.Name = "lblEditAuthor";
            this.lblEditAuthor.Size = new System.Drawing.Size(53, 24);
            this.lblEditAuthor.TabIndex = 2;
            this.lblEditAuthor.Text = "作者:";
            // 
            // lblEditPublisher
            // 
            this.lblEditPublisher.AutoSize = true;
            this.lblEditPublisher.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditPublisher.Location = new System.Drawing.Point(36, 203);
            this.lblEditPublisher.Name = "lblEditPublisher";
            this.lblEditPublisher.Size = new System.Drawing.Size(72, 24);
            this.lblEditPublisher.TabIndex = 3;
            this.lblEditPublisher.Text = "出版社:";
            // 
            // lblEditDate
            // 
            this.lblEditDate.AutoSize = true;
            this.lblEditDate.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditDate.Location = new System.Drawing.Point(36, 261);
            this.lblEditDate.Name = "lblEditDate";
            this.lblEditDate.Size = new System.Drawing.Size(91, 24);
            this.lblEditDate.TabIndex = 4;
            this.lblEditDate.Text = "出版日期:";
            // 
            // lblEditISBN
            // 
            this.lblEditISBN.AutoSize = true;
            this.lblEditISBN.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditISBN.Location = new System.Drawing.Point(36, 314);
            this.lblEditISBN.Name = "lblEditISBN";
            this.lblEditISBN.Size = new System.Drawing.Size(60, 24);
            this.lblEditISBN.TabIndex = 5;
            this.lblEditISBN.Text = "ISBN:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(40, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 43);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(214, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除資料";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEditBookName
            // 
            this.txtEditBookName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditBookName.Location = new System.Drawing.Point(174, 39);
            this.txtEditBookName.Name = "txtEditBookName";
            this.txtEditBookName.Size = new System.Drawing.Size(100, 29);
            this.txtEditBookName.TabIndex = 8;
            // 
            // txtEditEnglishName
            // 
            this.txtEditEnglishName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditEnglishName.Location = new System.Drawing.Point(174, 97);
            this.txtEditEnglishName.Name = "txtEditEnglishName";
            this.txtEditEnglishName.Size = new System.Drawing.Size(100, 29);
            this.txtEditEnglishName.TabIndex = 9;
            // 
            // txtEditAuthor
            // 
            this.txtEditAuthor.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditAuthor.Location = new System.Drawing.Point(174, 151);
            this.txtEditAuthor.Name = "txtEditAuthor";
            this.txtEditAuthor.Size = new System.Drawing.Size(100, 29);
            this.txtEditAuthor.TabIndex = 10;
            // 
            // txtEditPublisher
            // 
            this.txtEditPublisher.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditPublisher.Location = new System.Drawing.Point(174, 209);
            this.txtEditPublisher.Name = "txtEditPublisher";
            this.txtEditPublisher.Size = new System.Drawing.Size(100, 29);
            this.txtEditPublisher.TabIndex = 11;
            // 
            // txtEditYear
            // 
            this.txtEditYear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditYear.Location = new System.Drawing.Point(174, 261);
            this.txtEditYear.MaxLength = 4;
            this.txtEditYear.Name = "txtEditYear";
            this.txtEditYear.Size = new System.Drawing.Size(100, 29);
            this.txtEditYear.TabIndex = 12;
            // 
            // txtEditISBN
            // 
            this.txtEditISBN.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditISBN.Location = new System.Drawing.Point(174, 316);
            this.txtEditISBN.MaxLength = 13;
            this.txtEditISBN.Name = "txtEditISBN";
            this.txtEditISBN.Size = new System.Drawing.Size(100, 29);
            this.txtEditISBN.TabIndex = 13;
            // 
            // txtEditMonth
            // 
            this.txtEditMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditMonth.Location = new System.Drawing.Point(371, 262);
            this.txtEditMonth.MaxLength = 2;
            this.txtEditMonth.Name = "txtEditMonth";
            this.txtEditMonth.Size = new System.Drawing.Size(100, 29);
            this.txtEditMonth.TabIndex = 14;
            // 
            // txtEditDay
            // 
            this.txtEditDay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditDay.Location = new System.Drawing.Point(564, 264);
            this.txtEditDay.MaxLength = 2;
            this.txtEditDay.Name = "txtEditDay";
            this.txtEditDay.Size = new System.Drawing.Size(100, 29);
            this.txtEditDay.TabIndex = 15;
            // 
            // lblEditYear
            // 
            this.lblEditYear.AutoSize = true;
            this.lblEditYear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditYear.Location = new System.Drawing.Point(133, 264);
            this.lblEditYear.Name = "lblEditYear";
            this.lblEditYear.Size = new System.Drawing.Size(38, 21);
            this.lblEditYear.TabIndex = 16;
            this.lblEditYear.Text = "(年)";
            // 
            // lblEditMonth
            // 
            this.lblEditMonth.AutoSize = true;
            this.lblEditMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditMonth.Location = new System.Drawing.Point(327, 264);
            this.lblEditMonth.Name = "lblEditMonth";
            this.lblEditMonth.Size = new System.Drawing.Size(38, 21);
            this.lblEditMonth.TabIndex = 17;
            this.lblEditMonth.Text = "(月)";
            // 
            // lblEditDay
            // 
            this.lblEditDay.AutoSize = true;
            this.lblEditDay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditDay.Location = new System.Drawing.Point(520, 266);
            this.lblEditDay.Name = "lblEditDay";
            this.lblEditDay.Size = new System.Drawing.Size(38, 21);
            this.lblEditDay.TabIndex = 18;
            this.lblEditDay.Text = "(日)";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEditDay);
            this.Controls.Add(this.lblEditMonth);
            this.Controls.Add(this.lblEditYear);
            this.Controls.Add(this.txtEditDay);
            this.Controls.Add(this.txtEditMonth);
            this.Controls.Add(this.txtEditISBN);
            this.Controls.Add(this.txtEditYear);
            this.Controls.Add(this.txtEditPublisher);
            this.Controls.Add(this.txtEditAuthor);
            this.Controls.Add(this.txtEditEnglishName);
            this.Controls.Add(this.txtEditBookName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEditISBN);
            this.Controls.Add(this.lblEditDate);
            this.Controls.Add(this.lblEditPublisher);
            this.Controls.Add(this.lblEditAuthor);
            this.Controls.Add(this.lblEditEnglishName);
            this.Controls.Add(this.lblEditBookName);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditBookName;
        private System.Windows.Forms.Label lblEditEnglishName;
        private System.Windows.Forms.Label lblEditAuthor;
        private System.Windows.Forms.Label lblEditPublisher;
        private System.Windows.Forms.Label lblEditDate;
        private System.Windows.Forms.Label lblEditISBN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEditBookName;
        private System.Windows.Forms.TextBox txtEditEnglishName;
        private System.Windows.Forms.TextBox txtEditAuthor;
        private System.Windows.Forms.TextBox txtEditPublisher;
        private System.Windows.Forms.TextBox txtEditYear;
        private System.Windows.Forms.TextBox txtEditISBN;
        private System.Windows.Forms.TextBox txtEditMonth;
        private System.Windows.Forms.TextBox txtEditDay;
        private System.Windows.Forms.Label lblEditYear;
        private System.Windows.Forms.Label lblEditMonth;
        private System.Windows.Forms.Label lblEditDay;
    }
}