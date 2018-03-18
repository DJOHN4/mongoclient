namespace MongoClientTool
{
    partial class frmClient
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.cboDB = new System.Windows.Forms.ComboBox();
            this.cboColl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDbList = new System.Windows.Forms.Button();
            this.btnColList = new System.Windows.Forms.Button();
            this.btnDocList = new System.Windows.Forms.Button();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(143, 23);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(218, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "mongodb://localhost:27017";
            // 
            // cboDB
            // 
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Location = new System.Drawing.Point(143, 48);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(218, 21);
            this.cboDB.TabIndex = 1;
            // 
            // cboColl
            // 
            this.cboColl.FormattingEnabled = true;
            this.cboColl.Location = new System.Drawing.Point(143, 75);
            this.cboColl.Name = "cboColl";
            this.cboColl.Size = new System.Drawing.Size(218, 21);
            this.cboColl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DB Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DataBase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Collections";
            // 
            // btnDbList
            // 
            this.btnDbList.Location = new System.Drawing.Point(378, 19);
            this.btnDbList.Name = "btnDbList";
            this.btnDbList.Size = new System.Drawing.Size(52, 23);
            this.btnDbList.TabIndex = 6;
            this.btnDbList.Text = "List";
            this.btnDbList.UseVisualStyleBackColor = true;
            this.btnDbList.Click += new System.EventHandler(this.btnDbList_Click);
            // 
            // btnColList
            // 
            this.btnColList.Location = new System.Drawing.Point(378, 47);
            this.btnColList.Name = "btnColList";
            this.btnColList.Size = new System.Drawing.Size(52, 23);
            this.btnColList.TabIndex = 7;
            this.btnColList.Text = "List";
            this.btnColList.UseVisualStyleBackColor = true;
            this.btnColList.Click += new System.EventHandler(this.btnColList_Click);
            // 
            // btnDocList
            // 
            this.btnDocList.Location = new System.Drawing.Point(378, 73);
            this.btnDocList.Name = "btnDocList";
            this.btnDocList.Size = new System.Drawing.Size(52, 23);
            this.btnDocList.TabIndex = 8;
            this.btnDocList.Text = "List";
            this.btnDocList.UseVisualStyleBackColor = true;
            this.btnDocList.Click += new System.EventHandler(this.btnDocList_Click);
            // 
            // dgvDocs
            // 
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Location = new System.Drawing.Point(30, 122);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.Size = new System.Drawing.Size(1192, 379);
            this.dgvDocs.TabIndex = 9;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(1153, 507);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(69, 23);
            this.btnDeleteAll.TabIndex = 10;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Export To";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(946, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "DataModel";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1094, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Index";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.btnDocList);
            this.Controls.Add(this.btnColList);
            this.Controls.Add(this.btnDbList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboColl);
            this.Controls.Add(this.cboDB);
            this.Controls.Add(this.txtServer);
            this.Name = "frmClient";
            this.Text = "MongoClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ComboBox cboDB;
        private System.Windows.Forms.ComboBox cboColl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDbList;
        private System.Windows.Forms.Button btnColList;
        private System.Windows.Forms.Button btnDocList;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

