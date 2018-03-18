using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoClientTool
{
    public partial class frmClient : Form
    {
        public IMongoClient client;

        public frmClient()
        {
            InitializeComponent();
        }

        private void btnDbList_Click(object sender, EventArgs e)
        {
            client = new MongoClient(txtServer.Text.Trim());
            cboDB.Items.Clear();
            using (IAsyncCursor<BsonDocument> cursor = client.ListDatabases())
            {
                while (cursor.MoveNext())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        cboDB.Items.Add(doc[0]);
                    }
                }
            }
            cboDB.SelectedIndex = 0;

        }

        private void btnColList_Click(object sender, EventArgs e)
        {
            cboColl.Items.Clear();
            var db = client.GetDatabase(cboDB.GetItemText(cboDB.SelectedItem));
            using (IAsyncCursor<BsonDocument> cursor = db.ListCollections())
            {
                while (cursor.MoveNext())
                {
                    IEnumerable<BsonDocument> batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        cboColl.Items.Add(doc[0]);
                    }
                }
            }
            cboColl.SelectedIndex = 0;
        }

        private void btnDocList_Click(object sender, EventArgs e)
        {
            GetCollectionDocuments();

        }
        private void GetCollectionDocuments()
        {
            var db = client.GetDatabase(cboDB.GetItemText(cboDB.SelectedItem));
            var coll = db.GetCollection<BsonDocument>(cboColl.GetItemText(cboColl.SelectedItem));
            IEnumerable<BsonDocument> list = coll.Find(_ => true).ToList();
            dgvDocs.DataSource = Utilities.FillDataTable(list);

            //IEnumerable<StockPosition> list = coll.Find(_ => true).ToList();
            //dgvDocs.DataSource = Utilities.FillDataTable<StockPosition>(list);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all the docs?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var db = client.GetDatabase(cboDB.GetItemText(cboDB.SelectedItem));
                var coll = db.GetCollection<BsonDocument>(cboColl.GetItemText(cboColl.SelectedItem));
                coll.DeleteMany("{ }");
            }
            //MessageBox.Show()
            GetCollectionDocuments();
        }

        private void btnViewStratPerform_Click(object sender, EventArgs e)
        {
            //frmStrategyPerformance frmView = new frmStrategyPerformance();
            //frmView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = client.GetDatabase(cboDB.GetItemText(cboDB.SelectedItem));
                var coll = db.GetCollection<BsonDocument>(cboColl.GetItemText(cboColl.SelectedItem));
                var filter = new BsonDocument("Status", "CLOSED");
                IEnumerable<BsonDocument> list = coll.Find(filter).ToList();

                var data = SaveDataTableToCollection(list);
                MessageBox.Show("Data exported for modelling successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        public async Task SaveDataTableToCollection(IEnumerable<BsonDocument> batch)
        {
            try
            {
                var connectionString = ConfigurationManager.AppSettings["MongoDB"];
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("DataModel");

                var collection = database.GetCollection<BsonDocument>("StockPosition");

                await collection.InsertManyAsync(batch.AsEnumerable());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nsdaqIndexUrl = @"https://finance.google.com/finance/historical?q=.IXIC&output=json";
            string urii = @"http://www.google.com/finance?q=INDEXNASDAQ:.IXIC&output=json";

            //https://finance.google.com/finance?q=NASDAQ:AAPL&output=json

            //save ticker index here for data analysis.

            //if need to pass proxy using local configuration  
            System.Net.WebClient webClient = new WebClient();
            webClient.Proxy = HttpWebRequest.GetSystemWebProxy();
            //webClient.Proxy.Credentials = CredentialCache.DefaultCredentials;

            Stream strm = webClient.OpenRead(urii);
            StreamReader srm = new StreamReader(strm);
            string result = srm.ReadToEnd();
            strm.Close();
            //return result;


            try
            {
                var webRequest = System.Net.WebRequest.Create(nsdaqIndexUrl);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 20000;
                    webRequest.ContentType = "application/json";

                                       using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                            System.Diagnostics.Debug.WriteLine(String.Format("Response: {0}", jsonResponse));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            //var systemSounds = new[]
            //                  {
            //                      System.Media.SystemSounds.Asterisk,
            //                      System.Media.SystemSounds.Beep,
            //                      System.Media.SystemSounds.Exclamation,
            //                      System.Media.SystemSounds.Hand,
            //                      System.Media.SystemSounds.Question
            //                  };

            //comboBox1.DataSource = systemSounds;

            //comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ((System.Media.SystemSound)comboBox1.SelectedItem).Play();
        //}
    }
}
