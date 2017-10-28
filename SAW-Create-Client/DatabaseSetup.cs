using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAW_Create_Client
{
    public partial class DatabaseSetup : Form
    {
        public DatabaseSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DatabaseSetup_Load(object sender, EventArgs e)
        {
            DataTable SQL_Server_List = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in SQL_Server_List.Rows)
            {
                string sqlServerName = server[SQL_Server_List.Columns["ServerName"]].ToString();
                string SqlInstanceName = server[SQL_Server_List.Columns["InstanceName"]].ToString();

                if (server[SQL_Server_List.Columns["InstanceName"]].ToString() == "")
                {
                    Evo_Server_Name.Items.Add(sqlServerName);
                    Com_Server_Name.Items.Add(sqlServerName);
                }
                else
                {
                    Evo_Server_Name.Items.Add(sqlServerName + "\\" + SqlInstanceName);
                    Com_Server_Name.Items.Add(sqlServerName + "\\" + SqlInstanceName);
                }

            }
        }

        private void Com_Server_Password_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Left");
        }

        private void Evo_Server_Password_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Left");
        }
    }
}
