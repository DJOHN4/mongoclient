using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoClientTool
{
    public partial class frmTransactions : Form
    {
        public string TransactionType = string.Empty;
        public IMongoClient client;



        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
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

        private void GetCollectionDocuments()
        {
            FilterDefinition<Transactions> query = null;
            query = SetQueryFilter();
            IEnumerable<Transactions> transList = DBManager.GetEntityList<Transactions>(query);
            dgvDocs.DataSource = Utilities.FillDataTable<Transactions>(transList);
        }
        private FilterDefinition<Transactions> SetQueryFilter()
        {
            string transType = string.Empty;
            string markets = string.Empty;
            string xChanges = string.Empty;
            string strategies = string.Empty;
            DateTime stratDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;
            FilterDefinition<Transactions> filter = null;

            filter = Builders<Transactions>.Filter.Gte(trans => trans.CreatedDate, dtpStratDate.Value.Date);
            filter = filter & Builders<Transactions>.Filter.Lt(trans => trans.CreatedDate, dtpEndDate.Value);

            if (cboTransType.SelectedItem.ToString() != "All")
                filter = filter & Builders<Transactions>.Filter.Eq(trans => trans.TransactionType, cboTransType.SelectedItem.ToString());
            if (cboMarkets.SelectedItem.ToString() != "All")
                filter = filter & Builders<Transactions>.Filter.Eq(trans => trans.Market, cboMarkets.SelectedItem.ToString());
            if (cboExchange.SelectedItem.ToString() != "All")
                filter = filter & Builders<Transactions>.Filter.Eq(trans => trans.Exchange, cboExchange.SelectedItem.ToString());
            if (cboStrategies.SelectedItem.ToString() != "All")
                filter = filter & Builders<Transactions>.Filter.Eq(trans => trans.Strategy, cboStrategies.SelectedItem.ToString());

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

            dgvDocs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            // btnDisplay.Focus();
            btnDisplay.Select();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            GetCollectionDocuments();
        }

        private void dgvDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocs.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dgvDocs.CurrentCell != null && dgvDocs.CurrentCell.Value != null)
                {
                    string jsonVal=dgvDocs.Rows[e.RowIndex].Cells[5].Value.ToString();
                    StockPosition posObject = JsonConvert.DeserializeObject<StockPosition>(jsonVal);
                    frmPositions newPos = new frmPositions();
                    newPos.thisPos = posObject;
                    //newPos.MdiParent = this.MdiParent;
                    newPos.ShowDialog();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpStratDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboStrategies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboExchange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMarkets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTransType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
