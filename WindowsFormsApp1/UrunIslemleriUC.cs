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
    public partial class UrunIslemleriUC : UserControl
    {
        int ID =0;
        public UrunIslemleriUC()
        {
            InitializeComponent();
            FillKategori();
        }

        public void FillKategori()
        {
            using (SqlConnection conn = new SqlConnection(this.uRUNTableAdapter.Connection.ConnectionString))
            {
                try
                {
                    string query = "select * from KATEGORI";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "KATEGORI");
                    comboKategori.DisplayMember = "AD";
                    comboKategori.ValueMember = "ID";
                    comboKategori.DataSource = ds.Tables["KATEGORI"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }
        private void GetData(string selectCommand)
        {
            try
            {
                if (kategoriID == 0)
                    return;
                // Specify a connection string.  
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString = this.uRUNTableAdapter.Connection.ConnectionString;

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
                uRUNBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgrdUrun.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
        }


        public void initializeGridView()
        {
            GetData("Select * from URUN");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgrdUrun.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_KATEGORIID.Text = dgrdUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_NAME.Text = dgrdUrun.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void DgrdUrun_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgrdUrun.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_KATEGORIID.Text = dgrdUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_NAME.Text = dgrdUrun.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.uRUNTableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (txt_NAME.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[URUN]([KATEGORIID],[NAME]) VALUES(@KATEGORIID,@NAME)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@KATEGORIID", kategoriID);
                cmd.Parameters.AddWithValue("@NAME", txt_NAME.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ürün Başarı ile eklenmiştir.");
                GetData("Select * from URUN where KATEGORIID="+ kategoriID);
                ClearData();
            }
            else
            {
                MessageBox.Show("Ürün bilgileri eksik olduğu için kaydedilemedi!");
            }
        }

        //Insert Data  

        //Display Data in DataGridView  

        //Clear Data  
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

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
            SqlConnection con = new SqlConnection(this.uRUNTableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (ID != 0)
            {
                if (kategoriID != 0 && txt_NAME.Text != "")
                {

                    cmd = new SqlCommand("update [dbo].[URUN] set NAME=@NAME where ID=@ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@NAME", txt_NAME.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürün Başarı ile güncellenmiştir.");
                    GetData("Select * from URUN where KATEGORIID="+ kategoriID);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Ürün bilgileri eksik olduğu için kaydedilemedi!");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek ürünü seçiniz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.uRUNTableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (ID != 0)
            {
                cmd = new SqlCommand("delete URUN where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ürün başarı ile silinmiştir!");
                GetData("Select * from URUN where KATEGORIID="+ kategoriID);
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek ürünü seçiniz");
            }
        }

        private void dgrdUrun_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(dgrdUrun.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_KATEGORIID.Text = dgrdUrun.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_NAME.Text = dgrdUrun.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
        int kategoriID = 0;

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKategori.SelectedItem != null)
            {
                DataRowView drv = comboKategori.SelectedItem as DataRowView;
                kategoriID = Convert.ToInt32(drv.Row["ID"].ToString());

                GetData("Select * from URUN where KATEGORIID=" + kategoriID);
            }

        }
    }
}

