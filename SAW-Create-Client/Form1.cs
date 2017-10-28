using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
