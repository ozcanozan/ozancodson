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
    public partial class MalzemeIslemleriUC : UserControl
    {
        int IDVariable = 0;
        public MalzemeIslemleriUC()
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
                String connectionString = this.mALZEMETableAdapter.Connection.ConnectionString;

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
                mALZEMEBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dgrdMalzeme.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("veritabanı hatası");
            }
        }


        public void initializeGridView()
        {
            GetData("Select * from MALZEME");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDVariable = Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_BARKODNO.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
        }


   
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (txt_BARKODNO.Text != "" && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[MALZEME]([BARKODNO],[MALZEMEADI],[MIKTARI],[ICERIKMIKTARI],[UYARIMIKTARI]) VALUES(@BARKODNO,@MALZEMEADI,@MIKTARI,@ICERIKMIKTARI,@UYARIMIKTARI)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@BARKODNO", txt_BARKODNO.Text);
                cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
                cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
                cmd.Parameters.AddWithValue("@ICERIKMIKTARI", txtİcerikMiktari.Text);
                cmd.Parameters.AddWithValue("@UYARIMIKTARI", txt_uyariMiktari.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Malzeme Başarı ile eklenmiştir.");
                GetData("Select * from MALZEME");
                ClearData();
            }
            else
            {
                MessageBox.Show("Malzeme bilgileri eksik olduğu için kaydedilemedi!");
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
            IDVariable = 0;
        }

        private void dgrdMalzemeIslemleri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDVariable = Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_BARKODNO.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_MIKTARI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_uyariMiktari.Text= dgrdMalzeme.Rows[e.RowIndex].Cells[5].Value.ToString(); 
            txtİcerikMiktari.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

 

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (IDVariable != 0)
            {
                cmd = new SqlCommand("delete MALZEME where ID=@IDVariable", con);
                con.Open();
                cmd.Parameters.AddWithValue("@IDVariable", IDVariable);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Malzeme başarı ile silinmiştir!");
                GetData("Select * from MALZEME");
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek malzemeyi seçiniz");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetData("Select * from MALZEME where MALZEMEADI like '%" + txtAra.Text + "%'");
        }

        private void MalzemeIslemleriUC_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            if (IDVariable != 0)
            {
                if (txt_BARKODNO.Text != "" && txt_MALZEMEADI.Text != "")
                {

                    cmd = new SqlCommand("update [dbo].[MALZEME] set BARKODNO=@BARKODNO,MALZEMEADI=@MALZEMEADI,MIKTARI=@MIKTARI,ICERIKMIKTARI=@ICERIKMIKTARI,UYARIMIKTARI=@UYARIMIKTARI where ID=@ID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", IDVariable);
                    cmd.Parameters.AddWithValue("@BARKODNO", txt_BARKODNO.Text);
                    cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
                    cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
                    cmd.Parameters.AddWithValue("@ICERIKMIKTARI", txtİcerikMiktari.Text);
                    cmd.Parameters.AddWithValue("@UYARIMIKTARI", txt_uyariMiktari.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("MALZEME Başarı ile güncellenmiştir.");
                    GetData("Select * from MALZEME");
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Malzeme bilgileri eksik olduğu için kaydedilemedi!");
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek Malzemeyi seçiniz");
            }
        }

        private void Txt_MALZEMEADI_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

