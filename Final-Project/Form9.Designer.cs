namespace Final_Project
{
    partial class Form9
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
            this.lblUserState = new System.Windows.Forms.Label();
            this.dgvUserState = new System.Windows.Forms.DataGridView();
            this.timerUserState = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserState)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserState.Location = new System.Drawing.Point(49, 40);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(127, 36);
            this.lblUserState.TabIndex = 0;
            this.lblUserState.Text = "用戶狀況";
            // 
            // dgvUserState
            // 
            this.dgvUserState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserState.Location = new System.Drawing.Point(13, 114);
            this.dgvUserState.Name = "dgvUserState";
            this.dgvUserState.RowHeadersWidth = 51;
            this.dgvUserState.RowTemplate.Height = 27;
            this.dgvUserState.Size = new System.Drawing.Size(628, 324);
            this.dgvUserState.TabIndex = 1;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUserState);
            this.Controls.Add(this.lblUserState);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.DataGridView dgvUserState;
        private System.Windows.Forms.Timer timerUserState;
    }
}