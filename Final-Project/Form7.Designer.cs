namespace Final_Project
{
    partial class Form7
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
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.btnBooksEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(12, 12);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.Size = new System.Drawing.Size(452, 410);
            this.dgvManager.TabIndex = 0;
            // 
            // btnBooksEdit
            // 
            this.btnBooksEdit.Location = new System.Drawing.Point(510, 105);
            this.btnBooksEdit.Name = "btnBooksEdit";
            this.btnBooksEdit.Size = new System.Drawing.Size(75, 49);
            this.btnBooksEdit.TabIndex = 1;
            this.btnBooksEdit.Text = "編輯庫存";
            this.btnBooksEdit.UseVisualStyleBackColor = true;
            this.btnBooksEdit.Click += new System.EventHandler(this.btnBooksEdit_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBooksEdit);
            this.Controls.Add(this.dgvManager);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Button btnBooksEdit;
    }
}