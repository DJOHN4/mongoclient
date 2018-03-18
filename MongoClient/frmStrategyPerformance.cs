using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MongoClientTool
{
    public partial class frmStrategyPerformance : Form
    {
        public DataTable pnlDayDT;
        public frmStrategyPerformance()
        {
            InitializeComponent();
        }

        private void frmStrategyPerformance_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = pnlDayDT;
                //DataTable table = new DataTable();
                //table.Columns.Add(new DataColumn("Name1", typeof(string)));
                //table.Columns.Add(new DataColumn("Value1", typeof(int)));


                //table.Rows.Add(new object[] { "C1", 12});
                //table.Rows.Add(new object[] { "C2", 14});
                //table.Rows.Add(new object[] { "C12", 25});

                //chrtStratPerformance.Series[0].XValueMember = "Value1";
                //chrtStratPerformance.Series[0].YValueMembers = "Name1";

                //chrtStratPerformance.DataSource = table;
                //chrtStratPerformance.DataBind();

                // and fill in all the values from the dgv to the chart:
                //for (int i = 0; i < Table.Rows.Count; i++)
                //{
                //    for (int j = 1; j < Table.Columns.Count; j++)
                //    {
                //        int p = chart1.Series[i].Points.AddXY(Table.Columns[j].HeaderText, Table[j, i].Value);
                //    }
                //}

                Color[] myPalette = new Color[6]{
            Color.FromKnownColor(KnownColor.Green), 
            Color.FromKnownColor(KnownColor.Red),
            Color.FromKnownColor(KnownColor.Purple), 
            Color.FromKnownColor(KnownColor.Blue),
            Color.FromKnownColor(KnownColor.Orange),
            Color.FromKnownColor(KnownColor.Brown)
            
        };
                this.chrtStratPerformance.Palette = ChartColorPalette.None;
                this.chrtStratPerformance.PaletteCustomColors = myPalette;

                this.chrtStratPerformance.Legends.Add("Strategy");
                this.chrtStratPerformance.Legends[0].LegendStyle = LegendStyle.Table;
                this.chrtStratPerformance.Legends[0].Docking = Docking.Bottom;
                this.chrtStratPerformance.Legends[0].Alignment = StringAlignment.Center;
                this.chrtStratPerformance.Legends[0].Title = "Strategy Performance";
                this.chrtStratPerformance.Legends[0].BorderColor = Color.Black;


                ShowPieChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPieChart()
        {


            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Percentage", typeof(decimal)));

            foreach (DataRow row in pnlDayDT.Rows)
            {
                string Name=row.ItemArray[0].ToString();
                string percen = row.ItemArray[1].ToString();
                decimal per=Convert.ToDecimal(percen);
                table.Rows.Add(new object[] {Name , Math.Round(per, 2) });
                //table.Rows.Add(new object[] { "PumpAndDump", 40 });
                //table.Rows.Add(new object[] { "TrendFollow", 30 });
                //table.Rows.Add(new object[] { "MarketFall", 10 });
            }

            // Now we can set up the Chart:
            //List<Color> colors = new List<Color> { Color.Green, Color.Red, Color.Black };
            //chrtStratPerformance.Series.Colors(new string[] { "#952F91", "#00A9AA", "#EA7EB8"  /*...range of colors */ });


            chrtStratPerformance.DataSource = table;
            chrtStratPerformance.Series["Series1"].XValueMember = "Name";
            chrtStratPerformance.Series["Series1"].YValueMembers = "Percentage";
            chrtStratPerformance.DataBind();

            chrtStratPerformance.Series["Series1"].Label = "#PERCENT";
            chrtStratPerformance.Series["Series1"].LegendText = "#VALX";

        }
    }
}
