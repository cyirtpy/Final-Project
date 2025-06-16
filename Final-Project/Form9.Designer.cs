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
            this.checkbEditTime = new System.Windows.Forms.CheckBox();
            this.lblEditDay = new System.Windows.Forms.Label();
            this.txtEditDay = new System.Windows.Forms.TextBox();
            this.txtEditHour = new System.Windows.Forms.TextBox();
            this.lblEditHour = new System.Windows.Forms.Label();
            this.txtEditMinute = new System.Windows.Forms.TextBox();
            this.lblEditMinute = new System.Windows.Forms.Label();
            this.txtEditSecond = new System.Windows.Forms.TextBox();
            this.lblEditSecond = new System.Windows.Forms.Label();
            this.btnEditData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserState)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserState.Location = new System.Drawing.Point(37, 32);
            this.lblUserState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(100, 28);
            this.lblUserState.TabIndex = 0;
            this.lblUserState.Text = "用戶狀況";
            // 
            // dgvUserState
            // 
            this.dgvUserState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserState.Location = new System.Drawing.Point(10, 91);
            this.dgvUserState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUserState.Name = "dgvUserState";
            this.dgvUserState.RowHeadersWidth = 51;
            this.dgvUserState.RowTemplate.Height = 27;
            this.dgvUserState.Size = new System.Drawing.Size(451, 259);
            this.dgvUserState.TabIndex = 1;
            this.dgvUserState.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserState_CellClick);
            // 
            // checkbEditTime
            // 
            this.checkbEditTime.AutoSize = true;
            this.checkbEditTime.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkbEditTime.Location = new System.Drawing.Point(500, 44);
            this.checkbEditTime.Name = "checkbEditTime";
            this.checkbEditTime.Size = new System.Drawing.Size(143, 28);
            this.checkbEditTime.TabIndex = 2;
            this.checkbEditTime.Text = "更改剩餘時間";
            this.checkbEditTime.UseVisualStyleBackColor = true;
            this.checkbEditTime.CheckedChanged += new System.EventHandler(this.checkbEditTime_CheckedChanged);
            // 
            // lblEditDay
            // 
            this.lblEditDay.AutoSize = true;
            this.lblEditDay.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditDay.Location = new System.Drawing.Point(502, 94);
            this.lblEditDay.Name = "lblEditDay";
            this.lblEditDay.Size = new System.Drawing.Size(48, 24);
            this.lblEditDay.TabIndex = 3;
            this.lblEditDay.Text = "天數";
            // 
            // txtEditDay
            // 
            this.txtEditDay.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditDay.Location = new System.Drawing.Point(563, 91);
            this.txtEditDay.Name = "txtEditDay";
            this.txtEditDay.Size = new System.Drawing.Size(80, 33);
            this.txtEditDay.TabIndex = 4;
            // 
            // txtEditHour
            // 
            this.txtEditHour.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditHour.Location = new System.Drawing.Point(563, 134);
            this.txtEditHour.Name = "txtEditHour";
            this.txtEditHour.Size = new System.Drawing.Size(80, 33);
            this.txtEditHour.TabIndex = 6;
            // 
            // lblEditHour
            // 
            this.lblEditHour.AutoSize = true;
            this.lblEditHour.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditHour.Location = new System.Drawing.Point(502, 137);
            this.lblEditHour.Name = "lblEditHour";
            this.lblEditHour.Size = new System.Drawing.Size(29, 24);
            this.lblEditHour.TabIndex = 5;
            this.lblEditHour.Text = "時";
            // 
            // txtEditMinute
            // 
            this.txtEditMinute.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditMinute.Location = new System.Drawing.Point(563, 183);
            this.txtEditMinute.Name = "txtEditMinute";
            this.txtEditMinute.Size = new System.Drawing.Size(80, 33);
            this.txtEditMinute.TabIndex = 8;
            // 
            // lblEditMinute
            // 
            this.lblEditMinute.AutoSize = true;
            this.lblEditMinute.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditMinute.Location = new System.Drawing.Point(502, 186);
            this.lblEditMinute.Name = "lblEditMinute";
            this.lblEditMinute.Size = new System.Drawing.Size(29, 24);
            this.lblEditMinute.TabIndex = 7;
            this.lblEditMinute.Text = "分";
            // 
            // txtEditSecond
            // 
            this.txtEditSecond.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditSecond.Location = new System.Drawing.Point(563, 231);
            this.txtEditSecond.Name = "txtEditSecond";
            this.txtEditSecond.Size = new System.Drawing.Size(80, 33);
            this.txtEditSecond.TabIndex = 10;
            // 
            // lblEditSecond
            // 
            this.lblEditSecond.AutoSize = true;
            this.lblEditSecond.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEditSecond.Location = new System.Drawing.Point(502, 234);
            this.lblEditSecond.Name = "lblEditSecond";
            this.lblEditSecond.Size = new System.Drawing.Size(29, 24);
            this.lblEditSecond.TabIndex = 9;
            this.lblEditSecond.Text = "秒";
            // 
            // btnEditData
            // 
            this.btnEditData.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditData.Location = new System.Drawing.Point(532, 304);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(111, 44);
            this.btnEditData.TabIndex = 11;
            this.btnEditData.Text = "更改資料";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 369);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.txtEditSecond);
            this.Controls.Add(this.lblEditSecond);
            this.Controls.Add(this.txtEditMinute);
            this.Controls.Add(this.lblEditMinute);
            this.Controls.Add(this.txtEditHour);
            this.Controls.Add(this.lblEditHour);
            this.Controls.Add(this.txtEditDay);
            this.Controls.Add(this.lblEditDay);
            this.Controls.Add(this.checkbEditTime);
            this.Controls.Add(this.dgvUserState);
            this.Controls.Add(this.lblUserState);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form9";
            this.Text = "用戶狀況";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.DataGridView dgvUserState;
        private System.Windows.Forms.Timer timerUserState;
        private System.Windows.Forms.CheckBox checkbEditTime;
        private System.Windows.Forms.Label lblEditDay;
        private System.Windows.Forms.TextBox txtEditDay;
        private System.Windows.Forms.TextBox txtEditHour;
        private System.Windows.Forms.Label lblEditHour;
        private System.Windows.Forms.TextBox txtEditMinute;
        private System.Windows.Forms.Label lblEditMinute;
        private System.Windows.Forms.TextBox txtEditSecond;
        private System.Windows.Forms.Label lblEditSecond;
        private System.Windows.Forms.Button btnEditData;
    }
}