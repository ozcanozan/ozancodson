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
    public partial class KategoriİslemleriUC : UserControl
    {
        public KategoriİslemleriUC()
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
                String connectionString = this.mUSTERITableAdapter.Connection.ConnectionString;

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
                kATEGORIBindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgrdKategori.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
        }




        public void initializeGridView()
        {
            GetData("Select * from KATEGORI");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.kATEGORITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (txt_Ad.Text != "" )
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[KATEGORI]([AD]) VALUES(@AD)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AD", txt_Ad.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kategori Başarı ile eklenmiştir.");
                GetData("Select * from KATEGORI");
                ClearData();
            }
            else
            {
                MessageBox.Show("Kategori bilgileri eksik olduğu için kaydedilemedi!");
            }
        }
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        //Insert Data  

        //Display Data in DataGridView  
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        //Clear Data  
        private void ClearData()
        {
            var textboxes = GetAll(this, typeof(TextBox));
            foreach (var item in textboxes)
            {
                item.Text = "";
            }
            ID = 0;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.kATEGORITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (ID != 0)
            {
                if (txt_Ad.Text != "")
                {

                    cmd = new SqlCommand("update [dbo].[KATEGORI] set AD=@AD where ID=@ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@AD", txt_Ad.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategori Başarı ile güncellenmiştir.");
                    GetData("Select * from KATEGORI");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Kategori bilgileri eksik olduğu için kaydedilemedi!");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek Kategoriyi seçiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.kATEGORITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (ID != 0)
            {
                cmd = new SqlCommand("delete KATEGORI where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kategori başarı ile silinmiştir!");
                GetData("Select * from KATEGORI");
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek Kategoriyi seçiniz");
            }
        }

        private void dgrdKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgrdKategori.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Ad.Text = dgrdKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void DgrdKategori_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgrdKategori.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Ad.Text = dgrdKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void dgrdKategori_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(dgrdKategori.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Ad.Text = dgrdKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetData("Select * from KATEGORI where AD like '%"+txtAra.Text+"%'");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

