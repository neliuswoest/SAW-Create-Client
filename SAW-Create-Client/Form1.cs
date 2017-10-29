using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


namespace SAW_Create_Client
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void databaseSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSetup frm_dbSetup = new DatabaseSetup();
            frm_dbSetup.ShowDialog(); // Shows Form2
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                EvoDAC.SDKConnector();
                MessageBox.Show("Test ok");
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            


        }
    }
}
