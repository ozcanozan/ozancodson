using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class SiparisKontrolUC : UserControl
    {
        public SiparisKontrolUC()
        {
            InitializeComponent();
        }
        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.  
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString = this.sIPARISDURUMUTableAdapter.Connection.ConnectionString;

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. 
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                anaDepoViewBindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgrdSiparisKontrol.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgrdSiparisKontrol.Refresh();
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
        }

        public void initializeGridView()
        {
            GetData("Select * from AnaDepoView");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMusteri.Text) && !String.IsNullOrEmpty(txtSiparisNo.Text))
                GetData("Select * from AnaDepoView where SIPARISNO like '%" + txtSiparisNo.Text + "%' or MUSTERIAD like '%" + txtMusteri.Text + "%' or VKN_TC like '%" + txtMusteri.Text + "%'or SORUMLUADSOYAD like '%" + txtMusteri.Text + "%'");
            else if (String.IsNullOrEmpty(txtMusteri.Text) && !String.IsNullOrEmpty(txtSiparisNo.Text))
                GetData("Select * from AnaDepoView where SIPARISNO like '%" + txtSiparisNo.Text + "%'");
            else if (!String.IsNullOrEmpty(txtMusteri.Text) && String.IsNullOrEmpty(txtSiparisNo.Text))
                GetData("Select * from AnaDepoView where  MUSTERIAD like '%" + txtMusteri.Text + "%' or VKN_TC like '%" + txtMusteri.Text + "%'or SORUMLUADSOYAD like '%" + txtMusteri.Text + "%'");
            else GetData("Select * from AnaDepoView");
        }
    }
}

