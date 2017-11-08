using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Pastel.Evolution;


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
            try
            { 
            DataTable dt1 = new DataTable();
                //test change
            dt1 = EvoDAC.ReturnDatatable("SELECT Account, Name, Contact_Person, Telephone, Telephone2, Fax1, Fax2, Email FROM[Client]");
            dataGridView1.DataSource = dt1;
            }
            catch
            {
                MessageBox.Show("Setup Data Connection First","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DatabaseSetup frm_dbSetup = new DatabaseSetup();
                frm_dbSetup.ShowDialog(); // Shows Form2
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            EvoDAC.SDKConnector();
            string Cust = txt_Customer_Name.Text;
            bool flag = this.checkBox1.Checked;

            string DC = "Del2";
            
 

            //check if Customer exists note to capture a delivery address the Customer must exist first
            if (Customer.FindByCode(Cust) == -1)
            {
                Customer NewCust = new Customer();
                NewCust.Description = Cust;                
                NewCust.Save();

                Customer C = new Customer(NewCust.Code);
                //Set new properties
                NewCust.Description = txt_Customer_Name.Text.ToString();
                C.Telephone = textBox2.Text.ToString();
                C.EmailAddress = textBox4.Text.ToString();
                C.TaxNumber = textBox5.Text.ToString();
                C.DefaultTaxRate = (new TaxRate("1"));

                if (flag)
                {
                    //customer.set_IsCashDebtor(true);
                    C.IsCashDebtor = true;
                    C.AgeingMethod = ((AccountAgeingMethod)1);
                }
                //Set Postal or physical address
                C.PostalAddress = new Address(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text);
                C.PhysicalAddress = new Address()
                {
                    Line1 = txt7.Text,
                    Line2 = txt8.Text,
                    Line3 = txt9.Text,
                    Line4 = txt10.Text,
                    Line5 = txt11.Text,
                    PostalCode = txt12.Text,
                };
                C.Save();
                MessageBox.Show("Success", "Client saved to Database.");


                txt_Customer_Name.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                txt1.Clear();
                txt2.Clear();
                txt3.Clear();
                txt4.Clear();
                txt5.Clear();
                txt6.Clear();
                txt7.Clear();
                txt9.Clear();
                txt10.Clear();
                txt11.Clear();
                txt12.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Customer_Name.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
            txt7.Clear();
            txt9.Clear();
            txt10.Clear();
            txt11.Clear();
            txt12.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = EvoDAC.ReturnDatatable("SELECT Account, Name, Contact_Person, Telephone, Telephone2, Fax1, Fax2, Email FROM[Client]");
            dataGridView1.DataSource = dt1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
        }
    }
}
