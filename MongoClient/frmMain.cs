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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClient newFrm = new frmClient();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmStrategyPerformance newFrm = new frmStrategyPerformance();
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        private void allToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTransactions newFrm = new frmTransactions();
            newFrm.TransactionType = "ALL";
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        private void buyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTransactions newFrm = new frmTransactions();
            newFrm.TransactionType = "BUY";
            newFrm.MdiParent = this;
            newFrm.Show();
        }
        private void sellToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTransactions newFrm = new frmTransactions();
            newFrm.TransactionType = "SELL";
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStockTrans newFrm = new frmStockTrans();
           // newFrm.TransactionType = "ALL";
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void buyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sellToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void buyToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void sellToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
