namespace MongoClientTool
{
    partial class frmStockTrans
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStratDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStrategies = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboExchange = new System.Windows.Forms.ComboBox();
            this.cboMarkets = new System.Windows.Forms.ComboBox();
            this.cboTransType = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtprofit = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtCurInvest = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPivot = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Current investment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(878, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Total Revenue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Total Profit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(546, 57);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(88, 20);
            this.dtpEndDate.TabIndex = 43;
            // 
            // dtpStratDate
            // 
            this.dtpStratDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStratDate.Location = new System.Drawing.Point(546, 13);
            this.dtpStratDate.Name = "dtpStratDate";
            this.dtpStratDate.Size = new System.Drawing.Size(88, 20);
            this.dtpStratDate.TabIndex = 42;
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Location = new System.Drawing.Point(12, 98);
            this.dgvDocs.MultiSelect = false;
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.Size = new System.Drawing.Size(1192, 419);
            this.dgvDocs.TabIndex = 49;
            this.dgvDocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(1102, 67);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 27);
            this.btnDisplay.TabIndex = 44;
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
            this.label7.TabIndex = 48;
            this.label7.Text = "Strategies";
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
            this.cboStrategies.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Exchanges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Market";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Transaction Type";
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
            this.cboExchange.Location = new System.Drawing.Point(144, 38);
            this.cboExchange.Name = "cboExchange";
            this.cboExchange.Size = new System.Drawing.Size(106, 21);
            this.cboExchange.TabIndex = 40;
            // 
            // cboMarkets
            // 
            this.cboMarkets.FormattingEnabled = true;
            this.cboMarkets.Items.AddRange(new object[] {
            "ALL",
            "STOCKS",
            "COINS",
            "OPTIONS",
            "FOREX"});
            this.cboMarkets.Location = new System.Drawing.Point(344, 12);
            this.cboMarkets.Name = "cboMarkets";
            this.cboMarkets.Size = new System.Drawing.Size(95, 21);
            this.cboMarkets.TabIndex = 39;
            // 
            // cboTransType
            // 
            this.cboTransType.FormattingEnabled = true;
            this.cboTransType.Items.AddRange(new object[] {
            "ALL",
            "ACTIVE",
            "CLOSED",
            "ORDER"});
            this.cboTransType.Location = new System.Drawing.Point(144, 12);
            this.cboTransType.Name = "cboTransType";
            this.cboTransType.Size = new System.Drawing.Size(106, 21);
            this.cboTransType.TabIndex = 38;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(786, 7);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(86, 20);
            this.txtCost.TabIndex = 56;
            // 
            // txtprofit
            // 
            this.txtprofit.Location = new System.Drawing.Point(786, 60);
            this.txtprofit.Name = "txtprofit";
            this.txtprofit.Size = new System.Drawing.Size(86, 20);
            this.txtprofit.TabIndex = 57;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(976, 7);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(86, 20);
            this.txtRevenue.TabIndex = 58;
            // 
            // txtCurInvest
            // 
            this.txtCurInvest.Location = new System.Drawing.Point(976, 57);
            this.txtCurInvest.Name = "txtCurInvest";
            this.txtCurInvest.Size = new System.Drawing.Size(86, 20);
            this.txtCurInvest.TabIndex = 59;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1102, 37);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(102, 27);
            this.btnExport.TabIndex = 60;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPivot
            // 
            this.btnPivot.Location = new System.Drawing.Point(1102, 6);
            this.btnPivot.Name = "btnPivot";
            this.btnPivot.Size = new System.Drawing.Size(102, 27);
            this.btnPivot.TabIndex = 61;
            this.btnPivot.Text = "Pivot";
            this.btnPivot.UseVisualStyleBackColor = true;
            this.btnPivot.Click += new System.EventHandler(this.btnPivot_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "DB";
            // 
            // cboDB
            // 
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Items.AddRange(new object[] {
            "TRADEBOT",
            "TRADEBOTTEST",
            "QuickTrader",
            "QuickTrader1",
            "QuickTrader2",
            "DataModel"});
            this.cboDB.Location = new System.Drawing.Point(144, 65);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(106, 21);
            this.cboDB.TabIndex = 62;
            // 
            // frmStockTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 529);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboDB);
            this.Controls.Add(this.btnPivot);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtCurInvest);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtprofit);
            this.Controls.Add(this.txtCost);
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
            this.Name = "frmStockTrans";
            this.Text = "frmStockTrans";
            this.Load += new System.EventHandler(this.frmStockTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStratDate;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStrategies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboExchange;
        private System.Windows.Forms.ComboBox cboMarkets;
        private System.Windows.Forms.ComboBox cboTransType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtprofit;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtCurInvest;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPivot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDB;
    }
}