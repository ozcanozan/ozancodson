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
    public partial class MusteriIslemleriUC : UserControl
    {
        public MusteriIslemleriUC()
        {
            InitializeComponent();

        }

        private void panel1_AutoSizeChanged(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
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
                mUSTERIBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgrdMusteri.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgrdMusteri.Refresh();
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
        }


        public void initializeGridView()
        {
            GetData("Select * from MUSTERI");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (txt_AD.Text != "" && txt_UNVAN.Text != "" && txt_VKN_TC.Text != "" && txt_ADRES.Text != "" && txt_SORUMLUADSOYAD.Text != "" && txt_SORUMLUTEL.Text != "" && txt_FIRMATEL.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[MUSTERI]([AD],[UNVAN],[VKN_TC],[ADRES],[SORUMLUADSOYAD],[SORUMLUTEL] ,[FIRMATEL]) VALUES(@AD,@UNVAN,@VKN_TC,@ADRES,@SORUMLUADSOYAD,@SORUMLUTEL,@FIRMATEL)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@AD", txt_AD.Text);
                cmd.Parameters.AddWithValue("@UNVAN", txt_UNVAN.Text);
                cmd.Parameters.AddWithValue("@VKN_TC", txt_VKN_TC.Text);
                cmd.Parameters.AddWithValue("@ADRES", txt_ADRES.Text);
                cmd.Parameters.AddWithValue("@SORUMLUADSOYAD", txt_SORUMLUADSOYAD.Text);
                cmd.Parameters.AddWithValue("@SORUMLUTEL", txt_SORUMLUTEL.Text);
                cmd.Parameters.AddWithValue("@FIRMATEL", txt_FIRMATEL.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Müşteri Başarı ile eklenmiştir.");
                GetData("Select * from MUSTERI");
                ClearData();
            }
            else
            {
                MessageBox.Show("Müşteri bilgileri eksik olduğu için kaydedilemedi!");
            }
        }


        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        //Insert Data  

        //Display Data in DataGridView  

        //Clear Data  
        private void ClearData()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control childcontrol in item.Controls)
                    {
                        if (childcontrol is TextBox)
                            childcontrol.Text = "";
                    }
                }
            }
            ID = 0;
        }
        private void dgrdMusteri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgrdMusteri.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_AD.Text = dgrdMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_UNVAN.Text = dgrdMusteri.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_VKN_TC.Text = dgrdMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ADRES.Text = dgrdMusteri.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_SORUMLUADSOYAD.Text = dgrdMusteri.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_SORUMLUTEL.Text = dgrdMusteri.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_FIRMATEL.Text = dgrdMusteri.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (ID != 0)
            {
                cmd = new SqlCommand("delete MUSTERI where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Müşteri başarı ile silinmiştir!");
                GetData("Select * from MUSTERI");
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek müşteriyi seçiniz");
            }

        }

        private void dgrdMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgrdMusteri.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_AD.Text = dgrdMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_UNVAN.Text = dgrdMusteri.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_VKN_TC.Text = dgrdMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ADRES.Text = dgrdMusteri.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_SORUMLUADSOYAD.Text = dgrdMusteri.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_SORUMLUTEL.Text = dgrdMusteri.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_FIRMATEL.Text = dgrdMusteri.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (ID != 0)
            {
                if (txt_AD.Text != "" && txt_UNVAN.Text != "" && txt_VKN_TC.Text != "" && txt_ADRES.Text != "" && txt_SORUMLUADSOYAD.Text != "" && txt_SORUMLUTEL.Text != "" && txt_FIRMATEL.Text != "")
                {

                    cmd = new SqlCommand("update [dbo].[MUSTERI] set AD=@AD,UNVAN=@UNVAN,VKN_TC=@VKN_TC,ADRES=@ADRES,SORUMLUADSOYAD=@SORUMLUADSOYAD,SORUMLUTEL=@SORUMLUTEL,FIRMATEL=@FIRMATEL where ID=@ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@AD", txt_AD.Text);
                    cmd.Parameters.AddWithValue("@UNVAN", txt_UNVAN.Text);
                    cmd.Parameters.AddWithValue("@VKN_TC", txt_VKN_TC.Text);
                    cmd.Parameters.AddWithValue("@ADRES", txt_ADRES.Text);
                    cmd.Parameters.AddWithValue("@SORUMLUADSOYAD", txt_SORUMLUADSOYAD.Text);
                    cmd.Parameters.AddWithValue("@SORUMLUTEL", txt_SORUMLUTEL.Text);
                    cmd.Parameters.AddWithValue("@FIRMATEL", txt_FIRMATEL.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Müşteri Başarı ile güncellenmiştir.");
                    GetData("Select * from MUSTERI");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Müşteri bilgileri eksik olduğu için kaydedilemedi!");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek müşteriyi seçiniz");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrdMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_AD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetData("Select * from MUSTERI where AD like '%" + txtAra.Text + "%'");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
