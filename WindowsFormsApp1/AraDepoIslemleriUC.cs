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
    public partial class AraDepoIslemleriUC : UserControl
    {
        int IDVariable = 0;
        int urunID = 0;
        int kategoriID = 0;
        public AraDepoIslemleriUC()
        {
            InitializeComponent();
            FillMalzeme();
        }
        private void FillMalzeme(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
            {
                try
                {
                    malzemeListbox.Items.Clear();
                    string query = "select * from MALZEME ";
                    if (!String.IsNullOrEmpty(search))
                        query = "select * from MALZEME where MALZEMEADI like '%" + search + "%' or BARKODNO like '%" + search + "%'";
                    //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    //conn.Open();
                    //DataSet ds = new DataSet();
                    //da.Fill(ds, "MALZEME");
                    //malzemeListbox.DisplayMember = "MALZEMEADI";
                    //malzemeListbox.ValueMember = "ID";
                    //malzemeListbox.DataSource = ds.Tables["MALZEME"];
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader r = null;
                    conn.Open();
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        malzemeListbox.Items.Add(r["BARKODNO"] + "-" + r["MALZEMEADI"]);
                    }
                    conn.Close();

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
            GetData("Select * from ARADEPO");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDVariable = Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_BARKODNO.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txt_MIKTARI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString();
            ////txt_ALISFIYATI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
            ////txt_SATISFIYATI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txt_TARIH.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private int getMalzemeID(string barkod)
        {
            if (!String.IsNullOrEmpty(barkod)) {
            
           
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
            {
                   
                string query = "select * from MALZEME where BARKODNO=" + barkod;
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //conn.Open();
                //DataSet ds = new DataSet();
                //da.Fill(ds, "MALZEME");
                //malzemeListbox.DisplayMember = "MALZEMEADI";
                //malzemeListbox.ValueMember = "ID";
                //malzemeListbox.DataSource = ds.Tables["MALZEME"];
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader r = null;
                conn.Open();
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    return Convert.ToInt32(r["ID"]);
                }
                conn.Close();
            }
                return 0;
            }
            else 
            return 0;
        }

        private void malzemeListbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in malzemeListbox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(malzemeListbox.Items[e.Index].ToString());
            else
                checkedItems.Remove(malzemeListbox.Items[e.Index].ToString());

            foreach (string item in checkedItems)
            {
                string barkod = item.Split('-').ToList()[0];
                int malzemeID = getMalzemeID(barkod);
                //txt_BARKODNO.Text = barkod;
                //txt_MALZEMEADI.Text = item.Split('-').ToList()[1];
            }

        }
        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{
          
        //    SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
        //    SqlCommand cmd;
        //    int malzemeID = getMalzemeID(txt_BARKODNO.Text);
        //    if (malzemeID == 0)
        //    {
        //        MessageBox.Show("Ara Depo bilgileri eksik olduğu için güncellenemedi!");
        //        return;
        //    }
        //    else {
            
           
        //    if (txt_BARKODNO.Text != "" && malzemeID != 0 && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text !=  "" && txt_TARIH.Text != "")
        //    {
        //        cmd = new SqlCommand("update [dbo].[ARADEPO] set MALZEMEADI=@MALZEMEADI, MIKTARI=@MIKTARI,TARIH=@TARIH where MALZEMEID=@ID", con);
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
               
        //        cmd.Parameters.AddWithValue("@MIKTARI",Int32.Parse(txt_MIKTARI.Text));
        //        //cmd.Parameters.AddWithValue("@ALISFIYATI", float.Parse(txt_ALISFIYATI.Text));
        //        //cmd.Parameters.AddWithValue("@SATISFIYATI",float.Parse(txt_SATISFIYATI.Text));
        //        cmd.Parameters.AddWithValue("@TARIH", txt_TARIH.Text);
        //        cmd.Parameters.AddWithValue("@ID",malzemeID);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("ARA DEPO Başarı ile güncellenmiştir.");
        //        GetData("Select * from ARADEPO");
        //        ClearData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ara Depo bilgileri eksik olduğu için güncellenemedi!");
        //    }
        //}
        //}

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
        private string getBarkodNo(int malzemeID)
        {
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
            {
                string query = "select * from MALZEME where ID=" + malzemeID;
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //conn.Open();
                //DataSet ds = new DataSet();
                //da.Fill(ds, "MALZEME");
                //malzemeListbox.DisplayMember = "MALZEMEADI";
                //malzemeListbox.ValueMember = "ID";
                //malzemeListbox.DataSource = ds.Tables["MALZEME"];
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader r = null;
                conn.Open();
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    return r["BARKODNO"].ToString();
                }
                conn.Close();
            }
            return "";
        }
        private void dgrdMalzemeIslemleri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDVariable = Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString());
            //txt_BARKODNO.Text = getBarkodNo(Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString()));
            //txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txt_MIKTARI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString();
            ////txt_ALISFIYATI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
            ////txt_SATISFIYATI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txt_TARIH.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

       

        //private void btnSil_Click_1(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
        //    SqlCommand cmd;

        //    if (IDVariable != 0)
        //    {
        //        cmd = new SqlCommand("delete ARADEPO where ID=@id", con);
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@id", IDVariable);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("ARADEPOdan başarı ile silinmiştir!");
        //        GetData("Select * from ARADEPO");
        //        ClearData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Silinecek ARADEPO mallemesini seçiniz");
        //    }
        //}

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetData("Select * from ARADEPO where MALZEMEADI like '%" + txtAra.Text + "%'");
        }

        //private void btnEkle_Click_1(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
        //    SqlCommand cmd;
        //    int malzemeID = getMalzemeID(txt_BARKODNO.Text);
        //    if (txt_BARKODNO.Text != "" && malzemeID != 0 && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text != "" && txt_TARIH.Text != "")
        //    {
        //        cmd = new SqlCommand("INSERT INTO [dbo].[ARADEPO]([MALZEMEID],[MALZEMEADI],[MIKTARI],[TARIH]) VALUES(@MALZEMEID,@MALZEMEADI,@MIKTARI,@TARIH)", con);
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
        //        cmd.Parameters.AddWithValue("@MALZEMEID", malzemeID);
        //        cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
        //        //cmd.Parameters.AddWithValue("@ALISFIYATI", txt_ALISFIYATI.Text);
        //        //cmd.Parameters.AddWithValue("@SATISFIYATI", txt_SATISFIYATI.Text);
        //        cmd.Parameters.AddWithValue("@TARIH", txt_TARIH.Text);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("ARA DEPOya Başarı ile eklenmiştir.");
        //        GetData("Select * from ARADEPO");
        //        ClearData();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ara Depo bilgileri eksik olduğu için kaydedilemedi!");
        //    }
        //}

        private void btnMalzemeAra_Click(object sender, EventArgs e)
        {
            FillMalzeme(txtMalzemeAra.Text);
        }

        private void malzemeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_TARIH_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

