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
    public partial class frmPositions : Form
    {
        public StockPosition thisPos = null;
        public frmPositions()
        {
            InitializeComponent();
        }

        private void frmPositions_Load(object sender, EventArgs e)
        {
            txtSymbol.Text = thisPos.Symbol;
            txtRevenue.Text = thisPos.TotalRevenue.ToString();
            txtCost.Text=thisPos.TotalCost.ToString();
            txtCount.Text = thisPos.TotalCount.ToString();
            txtFee.Text = (thisPos.TotalBuyFee + thisPos.TotalSellFee).ToString();
            txtPnl.Text = thisPos.ProfitnLoss.ToString();

            dgvPositions.DataSource = thisPos.TradeList;
        }
    }
}
