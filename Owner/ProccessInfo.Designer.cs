namespace Owner
{
    partial class frmProccessInfo
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
            this.dtpDateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dgvProccesTable = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProccesTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDateTimeFrom
            // 
            this.dtpDateTimeFrom.CustomFormat = "yyyy.MM.dd    HH:mm";
            this.dtpDateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTimeFrom.Location = new System.Drawing.Point(99, 27);
            this.dtpDateTimeFrom.Name = "dtpDateTimeFrom";
            this.dtpDateTimeFrom.Size = new System.Drawing.Size(146, 22);
            this.dtpDateTimeFrom.TabIndex = 0;
            // 
            // dtpDateTimeTo
            // 
            this.dtpDateTimeTo.CustomFormat = "yyyy.MM.dd    HH:mm";
            this.dtpDateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTimeTo.Location = new System.Drawing.Point(99, 55);
            this.dtpDateTimeTo.Name = "dtpDateTimeTo";
            this.dtpDateTimeTo.Size = new System.Drawing.Size(146, 22);
            this.dtpDateTimeTo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDateTo);
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Controls.Add(this.lblDateFrom);
            this.groupBox1.Controls.Add(this.dtpDateTimeFrom);
            this.groupBox1.Controls.Add(this.dtpDateTimeTo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTo.Location = new System.Drawing.Point(10, 60);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(62, 16);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "Дата по:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateFrom.Location = new System.Drawing.Point(10, 32);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(53, 16);
            this.lblDateFrom.TabIndex = 1;
            this.lblDateFrom.Text = "Дата с:";
            // 
            // dgvProccesTable
            // 
            this.dgvProccesTable.AllowUserToAddRows = false;
            this.dgvProccesTable.AllowUserToDeleteRows = false;
            this.dgvProccesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProccesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.BeginDate,
            this.EndDate});
            this.dgvProccesTable.Location = new System.Drawing.Point(12, 111);
            this.dgvProccesTable.Name = "dgvProccesTable";
            this.dgvProccesTable.ReadOnly = true;
            this.dgvProccesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProccesTable.Size = new System.Drawing.Size(643, 451);
            this.dgvProccesTable.TabIndex = 2;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PName
            // 
            this.PName.FillWeight = 300F;
            this.PName.HeaderText = "Название";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PName.Width = 300;
            // 
            // BeginDate
            // 
            this.BeginDate.HeaderText = "Запуск";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            this.BeginDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Завершение";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(555, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(12, 584);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 26);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.Location = new System.Drawing.Point(266, 27);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(149, 49);
            this.btnGetData.TabIndex = 3;
            this.btnGetData.Text = "Получить данные";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFilter);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фиотровать по названию";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(16, 29);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(166, 22);
            this.tbFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilter.Location = new System.Drawing.Point(82, 57);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 26);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmProccessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 622);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvProccesTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProccessInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProccessInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProccesTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTimeTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProccesTable;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnFilter;
    }
}