namespace MongoClientTool
{
    partial class frmStrategyPerformance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chrtStratPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStratPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // chrtStratPerformance
            // 
            this.chrtStratPerformance.BackColor = System.Drawing.Color.Gainsboro;
            this.chrtStratPerformance.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chrtStratPerformance.BorderlineColor = System.Drawing.Color.Black;
            this.chrtStratPerformance.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrtStratPerformance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtStratPerformance.Legends.Add(legend1);
            this.chrtStratPerformance.Location = new System.Drawing.Point(619, 128);
            this.chrtStratPerformance.Name = "chrtStratPerformance";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtStratPerformance.Series.Add(series1);
            this.chrtStratPerformance.Size = new System.Drawing.Size(529, 412);
            this.chrtStratPerformance.TabIndex = 1;
            this.chrtStratPerformance.Text = "chart1";
            // 
            // frmStrategyPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 621);
            this.Controls.Add(this.chrtStratPerformance);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStrategyPerformance";
            this.Text = "frmStrategyPerformance";
            this.Load += new System.EventHandler(this.frmStrategyPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtStratPerformance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtStratPerformance;
    }
}