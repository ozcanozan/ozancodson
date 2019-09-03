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
    public partial class UrunMalzemeIslemleriUC : UserControl
    {
        int IDVariable = 0;
        int urunID = 0;
        int kategoriID = 0;
        public UrunMalzemeIslemleriUC()
        {
            InitializeComponent();
            FillKategori();
            FillUrun();
            FillMalzeme();
        }

        private void FillMalzeme(string search="")
        {
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
            {
                try
                {
                    malzemeListbox.Items.Clear();
                    string query = "select * from MALZEME ";
                    if(!String.IsNullOrEmpty(search))
                        query= "select * from MALZEME where MALZEMEADI like '%" + search + "%' or BARKODNO like '%" + search + "%'";
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

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKategori.SelectedItem != null)
            {
                DataRowView drv = comboKategori.SelectedItem as DataRowView;
                kategoriID = Convert.ToInt32(drv.Row["ID"].ToString());
                FillUrun();
            }

        }
        private int getMalzemeID(string barkod)
        {
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
        private void FillUrun()
        {
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
            {
                try
                {
                    string query = "select * from URUN  where KATEGORIID=" + kategoriID;
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "URUN");
                    comboUrun.DisplayMember = "NAME";
                    comboUrun.ValueMember = "ID";
                    comboUrun.DataSource = ds.Tables["URUN"];
                    if (comboUrun.Items.Count > 0)
                    {
                        DataRowView drv = comboUrun.Items[0] as DataRowView;
                        urunID = Convert.ToInt32(drv.Row["ID"].ToString());
                        GetData("Select * from URUNMALZEME where URUNID=" + urunID);
                    }
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
            GetData("Select * from URUNMALZEME");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDVariable = Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_BARKODNO.Text = getBarkodNo(Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString()));
            txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_MIKTARI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (IDVariable != 0)
            {
                cmd = new SqlCommand("delete URUNMALZEME where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", IDVariable);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("URUNMALZEME başarı ile silinmiştir!");
                GetData("Select * from URUNMALZEME");
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek müşteriyi seçiniz");
            }
        }
        public void FillKategori()
        {
            using (SqlConnection conn = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString))
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
                    if (comboKategori.Items.Count > 0)
                    {
                        DataRowView drv = comboKategori.Items[0] as DataRowView;
                        kategoriID = Convert.ToInt32(drv.Row["ID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            int malzemeID = getMalzemeID(txt_BARKODNO.Text);
            
            if (txt_BARKODNO.Text != "" && urunID != 0 && malzemeID != 0  && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO [dbo].[URUNMALZEME]  ([URUNID],[MALZEMEID],[MIKTARI],[MALZEMEADI]) VALUES(@URUNID,@MALZEMEID,@MIKTARI,@MALZEMEADI)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@URUNID", urunID);
                cmd.Parameters.AddWithValue("@MALZEMEID", malzemeID);
                cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
                cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("URUNMALZEME Başarı ile Eklenmiştir.");
                GetData("Select * from URUNMALZEME where URUNID="+ urunID);
                ClearData();
            }
            else
            {
                MessageBox.Show("URUNMALZEME bilgileri eksik olduğu için kaydedilemedi!");
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
            txt_BARKODNO.Text = getBarkodNo(Convert.ToInt32(dgrdMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString()));
            txt_MALZEMEADI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_MIKTARI.Text = dgrdMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
        //    SqlCommand cmd;
        //    if (ID != 0)
        //    {
        //        if (txt_BARKODNO.Text != "" && txt_URUNID.Text != "" && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text != "" && txt_ALISFIYATI.Text != "" && txt_SATISFIYATI.Text != "" && txt_TARIH.Text != "")
        //        {

        //            cmd = new SqlCommand("INSERT INTO [dbo].[MALZEME]([BARKODNO],[URUNID],[MALZEMEADI],[MIKTARI],[ALISFIYATI],[SATISFIYATI] ,[TARIH]) VALUES(@BARKODNO,@URUNID,@MALZEMEADI,@MIKTARI,@ALISFIYATI,@SATISFIYATI,@TARIH)", con);
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@BARKODNO", txt_BARKODNO.Text);
        //            cmd.Parameters.AddWithValue("@URUNID", txt_URUNID.Text);
        //            cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
        //            cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
        //            cmd.Parameters.AddWithValue("@ALISFIYATI", txt_ALISFIYATI.Text);
        //            cmd.Parameters.AddWithValue("@SATISFIYATI", txt_SATISFIYATI.Text);
        //            cmd.Parameters.AddWithValue("@TARIH", txt_TARIH.Text);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show("Malzeme Başarı ile eklenmiştir.");
        //            GetData("Select * from MALZEME");
        //            ClearData();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Malzeme bilgileri eksik olduğu için kaydedilemedi!");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Güncellenecek malzemeyi seçiniz");
        //    }
        //}

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;

            if (IDVariable != 0)
            {
                cmd = new SqlCommand("delete URUNMALZEME where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", IDVariable);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("URUN MALZEME başarı ile silinmiştir!");
                GetData("Select * from URUNMALZEME");
                ClearData();
            }
            else
            {
                MessageBox.Show("Silinecek malzemeyi seçiniz");
            }
        }

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUrun.SelectedItem != null)
            {
                DataRowView drv = comboUrun.SelectedItem as DataRowView;
                urunID = Convert.ToInt32(drv.Row["ID"].ToString());
                GetData("Select * from URUNMALZEME where URUNID=" + urunID);
            }
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
                txt_BARKODNO.Text = barkod;
                txt_MALZEMEADI.Text = item.Split('-').ToList()[1];
            }

        }
        

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetData("Select * from URUNMALZEME where MALZEMEADI like '%" + txtAra.Text + "%' and URUNID="+urunID);
        }

        private void malzemeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMalzemeAra_Click(object sender, EventArgs e)
        {
            FillMalzeme(txtMalzemeAra.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.mALZEMETableAdapter.Connection.ConnectionString);
            SqlCommand cmd;
            int malzemeID = getMalzemeID(txt_BARKODNO.Text);

            if (txt_BARKODNO.Text != "" && urunID != 0 && malzemeID != 0 && IDVariable!=0 && txt_MALZEMEADI.Text != "" && txt_MIKTARI.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[URUNMALZEME] set MALZEMEID=@MALZEMEID,MIKTARI=@MIKTARI,MALZEMEADI=@MALZEMEADI where URUNID=@URUNID and ID=" + IDVariable, con);
                con.Open();
                cmd.Parameters.AddWithValue("@URUNID", urunID);
                cmd.Parameters.AddWithValue("@MALZEMEID", malzemeID);
                cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
                cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("URUN MALZEME Başarı ile Güncellemiştir.");
                GetData("Select * from URUNMALZEME where URUNID=" + urunID);
                ClearData();
            }
            else
            {
                MessageBox.Show("URUN MALZEME bilgileri eksik olduğu için kaydedilemedi!");
            }
        }
    }
}

