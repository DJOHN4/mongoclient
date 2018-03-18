namespace MongoClientTool
{
    partial class frmTransactions
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStrategies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboExchange = new System.Windows.Forms.ComboBox();
            this.cboMarkets = new System.Windows.Forms.ComboBox();
            this.cboTransType = new System.Windows.Forms.ComboBox();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.dtpStratDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(1102, 63);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 27);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Strategies";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboStrategies
            // 
            this.cboStrategies.FormattingEnabled = true;
            this.cboStrategies.Items.AddRange(new object[] {
            "All",
            "Extrapolate",
            "PumpAndDump"});
            this.cboStrategies.Location = new System.Drawing.Point(346, 55);
            this.cboStrategies.Name = "cboStrategies";
            this.cboStrategies.Size = new System.Drawing.Size(93, 21);
            this.cboStrategies.TabIndex = 4;
            this.cboStrategies.SelectedIndexChanged += new System.EventHandler(this.cboStrategies_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Exchanges";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Markets";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Transaction Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboExchange
            // 
            this.cboExchange.FormattingEnabled = true;
            this.cboExchange.Items.AddRange(new object[] {
            "All",
            "Binance",
            "Gdax",
            "Etrade",
            "Cryptopia"});
            this.cboExchange.Location = new System.Drawing.Point(144, 55);
            this.cboExchange.Name = "cboExchange";
            this.cboExchange.Size = new System.Drawing.Size(106, 21);
            this.cboExchange.TabIndex = 3;
            this.cboExchange.SelectedIndexChanged += new System.EventHandler(this.cboExchange_SelectedIndexChanged);
            // 
            // cboMarkets
            // 
            this.cboMarkets.FormattingEnabled = true;
            this.cboMarkets.Items.AddRange(new object[] {
            "All",
            "Coins",
            "Stocks",
            "Options",
            "Forex",
            "Commodities"});
            this.cboMarkets.Location = new System.Drawing.Point(344, 12);
            this.cboMarkets.Name = "cboMarkets";
            this.cboMarkets.Size = new System.Drawing.Size(95, 21);
            this.cboMarkets.TabIndex = 2;
            this.cboMarkets.SelectedIndexChanged += new System.EventHandler(this.cboMarkets_SelectedIndexChanged);
            // 
            // cboTransType
            // 
            this.cboTransType.FormattingEnabled = true;
            this.cboTransType.Items.AddRange(new object[] {
            "All",
            "BUY",
            "SELL"});
            this.cboTransType.Location = new System.Drawing.Point(144, 12);
            this.cboTransType.Name = "cboTransType";
            this.cboTransType.Size = new System.Drawing.Size(106, 21);
            this.cboTransType.TabIndex = 1;
            this.cboTransType.SelectedIndexChanged += new System.EventHandler(this.cboTransType_SelectedIndexChanged);
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Location = new System.Drawing.Point(12, 98);
            this.dgvDocs.MultiSelect = false;
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.Size = new System.Drawing.Size(1192, 419);
            this.dgvDocs.TabIndex = 29;
            this.dgvDocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellClick);
            this.dgvDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            // 
            // dtpStratDate
            // 
            this.dtpStratDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStratDate.Location = new System.Drawing.Point(546, 13);
            this.dtpStratDate.Name = "dtpStratDate";
            this.dtpStratDate.Size = new System.Drawing.Size(88, 20);
            this.dtpStratDate.TabIndex = 5;
            this.dtpStratDate.ValueChanged += new System.EventHandler(this.dtpStratDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(546, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(88, 20);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total Cost";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Total Prfit";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(878, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total Revenue";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Current investment";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 529);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStratDate);
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStrategies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboExchange);
            this.Controls.Add(this.cboMarkets);
            this.Controls.Add(this.cboTransType);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStrategies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboExchange;
        private System.Windows.Forms.ComboBox cboMarkets;
        private System.Windows.Forms.ComboBox cboTransType;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.DateTimePicker dtpStratDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}