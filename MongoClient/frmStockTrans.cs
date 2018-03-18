using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoClientTool
{
    public partial class frmStockTrans : Form
    {
        public frmStockTrans()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GetCollectionDocuments();
            CalculateTradeDetails();
        }

        private void frmStockTrans_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDefaultValues();
                GetCollectionDocuments();
              /*  DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Details";
                btnColumn.Text = "Details";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvDocs.Columns.Add(btnColumn);*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CalculateTradeDetails()
        {
            decimal totalCost = 0.0m;
            decimal curInvest = 0.0m;
            decimal profitnLoss = 0.0m;
            decimal totalRev = 0.0m;
            for (int i = 0; i < dgvDocs.Rows.Count; ++i)
            {
                totalCost += Convert.ToDecimal(dgvDocs.Rows[i].Cells["TotalCost"].Value);
                if (Convert.ToInt32(dgvDocs.Rows[i].Cells["SellPrice"].Value) == 0)
                    curInvest += Convert.ToDecimal(dgvDocs.Rows[i].Cells["TotalCost"].Value);
                profitnLoss += Convert.ToDecimal(dgvDocs.Rows[i].Cells["ProfitnLoss"].Value);
                totalRev += Convert.ToDecimal(dgvDocs.Rows[i].Cells["TotalRevenue"].Value);
            }

            txtCost.Text = totalCost.ToString();
            txtCurInvest.Text = curInvest.ToString();
            txtprofit.Text = profitnLoss.ToString();
            txtRevenue.Text = totalRev.ToString();
        }
        private void GetCollectionDocuments()
        {
            try
            {
                IMongoClient client = new MongoClient(ConfigurationManager.AppSettings["mongoDB"].ToString());
                var db = client.GetDatabase(cboDB.SelectedItem.ToString());
                var coll = db.GetCollection<StockPosition>("StockPosition");

                FilterDefinition<StockPosition> query = null;
                query = SetQueryFilter();
                IEnumerable<StockPosition> transList = coll.Find<StockPosition>(query).ToList();
                //IEnumerable<StockPosition> transList = DBManager.GetEntityList<StockPosition>(query);
                dgvDocs.DataSource = Utilities.FillDataTable<StockPosition>(transList);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private FilterDefinition<StockPosition> SetQueryFilter()
        {
            string transType = string.Empty;
            string markets = string.Empty;
            string xChanges = string.Empty;
            string strategies = string.Empty;
            DateTime stratDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;
            FilterDefinition<StockPosition> filter = null;

            if (cboTransType.SelectedItem.ToString() == "ALL" || cboTransType.SelectedItem.ToString() == "ACTIVE" || cboTransType.SelectedItem.ToString() == "ORDER")
            {
                filter = Builders<StockPosition>.Filter.Gte(trans => trans.CreatedOn, dtpStratDate.Value.Date);
                filter = filter & Builders<StockPosition>.Filter.Lt(trans => trans.CreatedOn, dtpEndDate.Value);
                if (cboTransType.SelectedItem.ToString() != "ALL")
                    filter = filter & Builders<StockPosition>.Filter.Eq(trans => trans.Status, cboTransType.SelectedItem.ToString());
            }
            else if (cboTransType.SelectedItem.ToString() == "CLOSED")
            {
                filter = Builders<StockPosition>.Filter.Gte(trans => trans.ModifiedOn, dtpStratDate.Value.Date);
                filter = filter & Builders<StockPosition>.Filter.Lt(trans => trans.ModifiedOn, dtpEndDate.Value);

                filter = filter & Builders<StockPosition>.Filter.Eq(trans => trans.Status, cboTransType.SelectedItem.ToString());
            }
            //if (cboMarkets.SelectedItem.ToString() != "All")
            //    filter = filter & Builders<StockPosition>.Filter.Eq(trans => trans.Market, cboMarkets.SelectedItem.ToString());
            //if (cboExchange.SelectedItem.ToString() != "All")
            //    filter = filter & Builders<StockPosition>.Filter.Eq(trans => trans.Exchange, cboExchange.SelectedItem.ToString());
            //if (cboStrategies.SelectedItem.ToString() != "All")
            //    filter = filter & Builders<StockPosition>.Filter.Eq(trans => trans.Strategy, cboStrategies.SelectedItem.ToString());

            return filter;
        }
        private void LoadDefaultValues()
        {
            dtpStratDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Format = DateTimePickerFormat.Custom;

            dtpStratDate.CustomFormat = "dd-MMM-yyyy";
            dtpEndDate.CustomFormat = "dd-MMM-yyyy";

            cboTransType.SelectedIndex = 0;
            cboMarkets.SelectedIndex = 0;
            cboExchange.SelectedIndex = 0;
            cboStrategies.SelectedIndex = 0;
            cboDB.SelectedIndex = 0;

            dgvDocs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            // btnDisplay.Focus();
            btnDisplay.Select();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvDocs.DataSource;
            Utilities.ExportToExcel(dt);
        }

        private void btnPivot_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvDocs.DataSource;

            // DataRow[] dr = dt.Select("Select Symbol, Sum(ProfitnLoss)");

            var results = from Trans in dt.AsEnumerable()
                          where Trans.Field<decimal>("SellProfitPercent") == 0.5m
                          select Trans;
            // DataTable view = results.CopyToDataTable();

            var dataRow = dt.AsEnumerable().Where(x => x.Field<decimal>("SellProfitPercent") == 0.5m)
                .Select(x => new { Name = x.Field<string>("Symbol"), profit = x.Field<decimal>("ProfitnLoss") })
                 .GroupBy(x => x.Name)
                               .Select(x => new
                               {
                                   Name = Name,
                                   Profit = x.Sum(y => y.profit)
                               });

            var rst = (from row in dt.AsEnumerable()
                       group row by row.Field<string>("Symbol") into grp
                       select new
                          {
                              Name = grp.Key,
                              Sum = (from r in grp where r.Field<decimal>("SellProfitPercent") == 0.5m select r.Field<decimal>("ProfitnLoss")).Sum()
                          }).ToList();


            var totalPnlList = (from row in dt.AsEnumerable()
                                group row by row.Field<decimal>("SellProfitPercent") into grp
                                select new
                                {
                                    Name = grp.Key,
                                    Sum = (from r in grp select r.Field<decimal>("ProfitnLoss")).Sum()
                                }).ToList();


           var pnlDayList = (from row in dt.AsEnumerable()
                                        group row by new
                     {
                         Date = row.Field<DateTime>("ModifiedOn"),
                         SPP = row.Field<decimal>("SellProfitPercent"),
                         MPL = row.Field<int>("MinPositionLevel")

                     } into grp
                                        select new
                                        {
                                            Name = grp.Key,
                                            Sum = (from r in grp select r.Field<decimal>("ProfitnLoss")).Sum()
                                        }).ToList();

           DataTable newItems = new DataTable();
           newItems.Columns.Add("Name");
           newItems.Columns.Add("Sum");

           foreach (var item in pnlDayList)
           {
               DataRow newRow = newItems.NewRow();
               newRow["Name"] = item.Name;
               newRow["Sum"] = item.Sum;
               newItems.Rows.Add(newRow);
           }

            frmStrategyPerformance frmPro = new frmStrategyPerformance();
            frmPro.pnlDayDT = newItems;
            frmPro.Show();
        }

        private void dgvDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocs.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvDocs.CurrentCell != null && dgvDocs.CurrentCell.Value != null)
                {
                    string jsonVal = dgvDocs.Rows[e.RowIndex].Cells[16].Value.ToString();
                    StockPosition posObject = new StockPosition(dgvDocs.Rows[e.RowIndex].Cells[1].Value.ToString(),
                      Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[2].Value.ToString()),
                         Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[5].Value.ToString()),
                         Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[9].Value.ToString()),
                         Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[8].Value.ToString()));
                    posObject.TotalCount = Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[2].Value.ToString());
                    posObject.TotalCost = Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[5].Value.ToString());
                    posObject.TotalRevenue = Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[9].Value.ToString());
                    posObject.ProfitnLoss = Convert.ToDecimal(dgvDocs.Rows[e.RowIndex].Cells[10].Value.ToString());
                    posObject.TradeList = JsonConvert.DeserializeObject<List<StockData>>(jsonVal);
                    frmPositions newPos = new frmPositions();
                    newPos.thisPos = posObject;
                    //newPos.MdiParent = this.MdiParent;
                    newPos.ShowDialog();
                }
            }
        }
    }
}
