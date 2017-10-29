using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["EvolutionServerName"].Value = Evo_Server_Name.Text.ToString();
            config.AppSettings.Settings["EvolutionDatabase"].Value = Evo_Company_Databases.Text.ToString();
            config.AppSettings.Settings["EvolutionUserName"].Value = Evo_Server_User_Name.Text.ToString();
            config.AppSettings.Settings["EvolutionPassword"].Value = Evo_Server_Password.Text.ToString();

            config.AppSettings.Settings["CommonServerName"].Value = Com_Server_Name.Text.ToString();
            config.AppSettings.Settings["CommonDatabase"].Value = Common_Databases.Text.ToString();
            config.AppSettings.Settings["CommonUserName"].Value = Com_Server_User_Name.Text.ToString();
            config.AppSettings.Settings["CommonPassword"].Value = Com_Server_Password.Text.ToString();

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();

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

      

        private void Evo_Server_Password_Leave(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
            cb.DataSource = Evo_Server_Name.SelectedItem.ToString();
            cb.InitialCatalog = "Master";
            cb.UserID = Evo_Server_User_Name.Text.ToString();
            cb.Password = Evo_Server_Password.Text.ToString();

            using (SqlConnection lSqlCon = new SqlConnection(cb.ToString()))
            {
                DataTable dt1 = new DataTable();
                try
                {
                    lSqlCon.Open();
                    using (SqlCommand lSqlCmd = new SqlCommand())
                    {
                        lSqlCmd.Connection = lSqlCon;
                        lSqlCmd.CommandType = CommandType.Text;
                        lSqlCmd.CommandText = "select Name from sys.databases where name NOT In ('master','tempdb','model','msdb') order by Name asc";
                        lSqlCmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(lSqlCmd);
                        da.Fill(dt1);
                        //DataTable dt2 = EvoDAC.ReturnDatatable("select Name from sys.databases where name NOT In ('master','tempdb','model','msdb') order by Name asc");
                        lSqlCon.Close();
                        foreach (DataRow row in dt1.Rows)
                        {
                            Evo_Company_Databases.Items.Add(row["Name"].ToString());
                        }
                        dt1.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Could not connect to server. Make sure username and password is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Evo_Server_Password.Focus();
                    Evo_Server_Password.BackColor = Color.Red;
                    Evo_Server_User_Name.BackColor = Color.Red;
                }
            }
        }

        private void Com_Server_Password_Leave(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
            cb.DataSource = Com_Server_Name.SelectedItem.ToString();
            cb.InitialCatalog = "Master";
            cb.UserID = Com_Server_User_Name.Text.ToString();
            cb.Password = Com_Server_Password.Text.ToString();

            using (SqlConnection lSqlCon = new SqlConnection(cb.ToString()))
            {
                DataTable dt2 = new DataTable();
                try
                {
                    lSqlCon.Open();
                    using (SqlCommand lSqlCmd = new SqlCommand())
                    {
                        lSqlCmd.Connection = lSqlCon;
                        lSqlCmd.CommandType = CommandType.Text;
                        lSqlCmd.CommandText = "select Name from sys.databases where name NOT In ('master','tempdb','model','msdb') order by Name asc";
                        lSqlCmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(lSqlCmd);
                        da.Fill(dt2);
                        //DataTable dt2 = EvoDAC.ReturnDatatable("select Name from sys.databases where name NOT In ('master','tempdb','model','msdb') order by Name asc");
                        lSqlCon.Close();
                        foreach (DataRow row in dt2.Rows)
                        {
                            Common_Databases.Items.Add(row["Name"].ToString());
                        }
                        dt2.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Could not connect to server. Make sure username and password is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Com_Server_Password.Focus();
                    Com_Server_Password.BackColor = Color.Red;
                    Com_Server_User_Name.BackColor = Color.Red;
                }
            }
        }
    }
}









