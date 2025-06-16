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
            this.btnUserState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(12, 12);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.Size = new System.Drawing.Size(452, 410);
            this.dgvManager.TabIndex = 0;
            // 
            // btnBooksEdit
            // 
            this.btnBooksEdit.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBooksEdit.Location = new System.Drawing.Point(510, 105);
            this.btnBooksEdit.Name = "btnBooksEdit";
            this.btnBooksEdit.Size = new System.Drawing.Size(113, 76);
            this.btnBooksEdit.TabIndex = 1;
            this.btnBooksEdit.Text = "編輯庫存";
            this.btnBooksEdit.UseVisualStyleBackColor = true;
            this.btnBooksEdit.Click += new System.EventHandler(this.btnBooksEdit_Click);
            // 
            // btnUserState
            // 
            this.btnUserState.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUserState.Location = new System.Drawing.Point(510, 253);
            this.btnUserState.Name = "btnUserState";
            this.btnUserState.Size = new System.Drawing.Size(113, 67);
            this.btnUserState.TabIndex = 2;
            this.btnUserState.Text = "用戶狀況";
            this.btnUserState.UseVisualStyleBackColor = true;
            this.btnUserState.Click += new System.EventHandler(this.btnUserState_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserState);
            this.Controls.Add(this.btnBooksEdit);
            this.Controls.Add(this.dgvManager);
            this.Name = "Form7";
            this.Text = "管理員介面";
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Button btnBooksEdit;
        private System.Windows.Forms.Button btnUserState;
    }
}