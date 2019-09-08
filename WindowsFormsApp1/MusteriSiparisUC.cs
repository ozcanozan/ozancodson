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
    public partial class MusteriSiparisUC : UserControl
    {
        int IDVariable = 0;
        int urunID = 0;
        int kategoriID = 0;
        int MusteriID = 0;

        public MusteriSiparisUC()
        {

            InitializeComponent();
            FillKategori();
            FillUrun();
            initializeMusteriGridView();
            var tableLayoutPanels = GetAll(this, typeof(TableLayoutPanel));
            foreach (var item in tableLayoutPanels)
            {
                item.Dock = DockStyle.Fill;
                if (item.Parent != null)
                {
                    item.Width = item.Parent.Width;
                }
                else
                {
                    item.Width = item.Parent.Width;
                }
                ((TableLayoutPanel)item).AutoScroll = true;
                item.AutoSize = true;
                item.Anchor = AnchorStyles.Left | AnchorStyles.Top; ;
                ((TableLayoutPanel)item).AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                item.ResumeLayout(false);
                item.PerformLayout();
            }
            var groupbox = GetAll(this, typeof(GroupBox));
            foreach (var item in groupbox)
            {
                item.Dock = DockStyle.Fill;
                if (item.Parent != null)
                {
                    item.Width = item.Parent.Width;
                }
                else
                {
                    item.Width = item.Parent.Width;
                }
                item.AutoSize = true;
                item.Anchor = AnchorStyles.Left | AnchorStyles.Top; ;
                // item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
                ((GroupBox)item).AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                item.ResumeLayout(false);
                item.PerformLayout();
            }
            //var textbox = GetAll(this, typeof(TextBox));
            //foreach (var item in textbox)
            //{
            //    item.Dock = DockStyle.Left; ;

            //    //if (this.Parent != null)
            //    //{
            //    //    item.Width = this.Parent.Width;
            //    //    item.Height = this.Parent.Height;
            //    //}
            //    //else
            //    //{
            //    //    item.Width = this.Width;
            //    //    item.Height = this.Height;
            //    //}
            //    item.AutoSize = true;
            //    //item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
            //    item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ; ;
            //    item.ResumeLayout(false);
            //    item.PerformLayout();
            //}
            //var dataGridViews = GetAll(this, typeof(DataGridView));
            //foreach (var item in dataGridViews)
            //{
            //    item.Dock = DockStyle.Left;
            //    if (item.Parent != null)
            //    {
            //        item.Width = item.Parent.Width;
            //    }
            //    else
            //    {
            //        item.Width = item.Parent.Width;
            //    }
            //    item.AutoSize = true;
            //    //item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
            //    item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ; ;
            //    item.ResumeLayout(false);
            //    item.PerformLayout();
            //}
        }

        private void GetMusteriData(string selectCommand)
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
        private void dgrdMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriID = Convert.ToInt32(dgrdMusteri.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSelectedAd.Text = dgrdMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSelectedTC.Text = dgrdMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();

        }
        private void dgrdMusteri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MusteriID = Convert.ToInt32(dgrdMusteri.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSelectedAd.Text = dgrdMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSelectedTC.Text = dgrdMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void initializeMusteriGridView()
        {
            GetMusteriData("Select * from MUSTERI");
        }
        private void FillUrun()
        {
            using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
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
                    }
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }

        public void FillKategori()
        {
            using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
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


        public void MusteriSiparisUC_SizeChange()
        {
            var tableLayoutPanels = GetAll(this, typeof(TableLayoutPanel));
            foreach (var item in tableLayoutPanels)
            {
                item.Dock = DockStyle.Fill;
                if (item.Parent != null)
                {
                    item.Width = item.Parent.Width - 30;
                }
                else
                {
                    item.Width = item.Parent.Width - 10;
                }
                ((TableLayoutPanel)item).AutoScroll = true;
                item.AutoSize = true;
                item.Anchor = AnchorStyles.Left | AnchorStyles.Top; ;
                ((TableLayoutPanel)item).AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                item.ResumeLayout(false);
                item.PerformLayout();
            }
            var groupbox = GetAll(this, typeof(GroupBox));
            foreach (var item in groupbox)
            {
                item.Dock = DockStyle.Fill;
                if (item.Parent != null)
                {
                    item.Width = item.Parent.Width;
                }
                else
                {
                    item.Width = item.Parent.Width;
                }
                item.AutoSize = true;
                item.Anchor = AnchorStyles.Left | AnchorStyles.Top; ;
                // item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
                ((GroupBox)item).AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                item.ResumeLayout(false);
                item.PerformLayout();
            }
            //var textbox = GetAll(this, typeof(TextBox));
            //foreach (var item in textbox)
            //{
            //    item.Dock = DockStyle.Left;
            //    //if (this.Parent != null)
            //    //{
            //    //    item.Width = this.Parent.Width;
            //    //    item.Height = this.Parent.Height;
            //    //}
            //    //else
            //    //{
            //    //    item.Width = this.Width;
            //    //    item.Height = this.Height;
            //    //}
            //    item.AutoSize = true;
            //    //item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
            //    item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ; ;
            //    item.ResumeLayout(false);
            //    item.PerformLayout();
            //}
            //var dataGridViews = GetAll(this, typeof(DataGridView));
            //foreach (var item in dataGridViews)
            //{
            //     item.Dock = DockStyle.Left;
            //    if (item.Parent != null)
            //    {
            //        item.Width = item.Parent.Width;
            //    }
            //    else
            //    {
            //        item.Width = item.Parent.Width;
            //    }
            //    item.AutoSize = true;
            //    //item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ;
            //    item.Anchor =  AnchorStyles.Left | AnchorStyles.Top ; ;
            //    item.ResumeLayout(false);
            //    item.PerformLayout();
            //}
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtADSorumluAdsoyad.Text) && string.IsNullOrEmpty(txtTc.Text))
                GetMusteriData("Select * from MUSTERI where AD like '%" + txtADSorumluAdsoyad.Text + "%' or SORUMLUADSOYAD like '%" + txtADSorumluAdsoyad.Text + "%' ");
            if (string.IsNullOrEmpty(txtADSorumluAdsoyad.Text) && !string.IsNullOrEmpty(txtTc.Text))
                GetMusteriData("Select * from MUSTERI where VKN_TC like '%" + txtTc.Text + "%'");
            if (!string.IsNullOrEmpty(txtADSorumluAdsoyad.Text) && !string.IsNullOrEmpty(txtTc.Text))
                GetMusteriData("Select * from MUSTERI where (AD like '%" + txtADSorumluAdsoyad.Text + "%' or SORUMLUADSOYAD like '%" + txtADSorumluAdsoyad.Text + "%') and  VKN_TC like '%" + txtTc.Text + "%'");
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            dgrdSepet.Rows.Add(GetKategoriName(), urunID, GetUrunName(), txtMiktar.Text, txtAlis.Text, txtSatis.Text);

            double sum = 0;
            for (int i = 0; i < dgrdSepet.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgrdSepet.Rows[i].Cells[5].Value) * Convert.ToDouble(dgrdSepet.Rows[i].Cells[3].Value);
            }
            txtToplamSatis.Text = sum.ToString();
        }
        private string GetKategoriName()
        {
            using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
            {
                string query = "select * from KATEGORI where ID=" + kategoriID;
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
                    return r["AD"].ToString();
                }
                conn.Close();
            }
            return "";
        }

        private string GetUrunName()
        {
            using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
            {
                string query = "select * from URUN where ID=" + urunID;
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
                    return r["NAME"].ToString();
                }
                conn.Close();
            }
            return "";
        }
        private string GetUrunName(int ID)
        {
            using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
            {
                string query = "select * from URUN where ID=" + ID;
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
                    return r["NAME"].ToString();
                }
                conn.Close();
            }
            return "";
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

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUrun.SelectedItem != null)
            {
                DataRowView drv = comboUrun.SelectedItem as DataRowView;
                urunID = Convert.ToInt32(drv.Row["ID"].ToString());
            }
        }

        private void btnClearSepet_Click(object sender, EventArgs e)
        {
            dgrdSepet.Rows.Clear();
            double sum = 0;
            for (int i = 0; i < dgrdSepet.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgrdSepet.Rows[i].Cells[5].Value) * Convert.ToDouble(dgrdSepet.Rows[i].Cells[3].Value);
            }
            txtToplamSatis.Text = sum.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            dgrdSepet.Rows.RemoveAt(dgrdSepet.SelectedRows[0].Index);
            double sum = 0;
            for (int i = 0; i < dgrdSepet.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgrdSepet.Rows[i].Cells[5].Value) * Convert.ToDouble(dgrdSepet.Rows[i].Cells[3].Value);
            }
            txtToplamSatis.Text = sum.ToString();
        }
        private bool AraDepodanDus(int UrunID, int miktar, SqlConnection conn, SqlTransaction tran)
        {
            try
            {

                string query = "select * from URUNMALZEME WHERE URUNID=" + urunID;
                using (SqlConnection con3 = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con3);
                    con3.Open();
                    SqlDataReader r = null;
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        int MalzemeID = Convert.ToInt32(r["MALZEMEID"].ToString());
                        string MalzemeAdi = r["MALZEMEADI"].ToString();
                        int dusulecekmiktar = Convert.ToInt32(r["MIKTARI"].ToString()) * miktar;
                        int aradepodakimiktar = 0;
                       
                        string query2 = "select * from ARADEPO WHERE MALZEMEID=" + MalzemeID;
                        using (SqlConnection con2 = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
                        {
                            SqlCommand cmd2 = new SqlCommand(query2, con2);
                            SqlDataReader r2 = null;
                            con2.Open();
                            r2 = cmd2.ExecuteReader();
                            bool aradepodavar = false;
                            while (r2.Read())
                            {
                                aradepodavar = true;
                                aradepodakimiktar = Convert.ToInt32(r2["MIKTARI"].ToString());
                                break;
                            }
                            if(!aradepodavar)
                            {
                                SqlCommand cmd6 = new SqlCommand("INSERT INTO [dbo].[ARADEPO]([MALZEMEID],[MALZEMEADI],[MIKTARI],[TARIH],[ALISFIYATI],[SATISFIYATI]) VALUES(@MALZEMEID,@MALZEMEADI,@MIKTARI,@TARIH,@ALISFIYATI,@SATISFIYATI)", conn);

                                cmd6.Transaction = tran;
                                cmd6.Parameters.AddWithValue("@MALZEMEADI", MalzemeAdi);
                                cmd6.Parameters.AddWithValue("@MALZEMEID", MalzemeID);
                                cmd6.Parameters.AddWithValue("@MIKTARI", 0);
                                cmd6.Parameters.AddWithValue("@ALISFIYATI", 0);
                                cmd6.Parameters.AddWithValue("@SATISFIYATI",0);
                                cmd6.Parameters.AddWithValue("@TARIH", DateTime.Now);
                                cmd6.ExecuteNonQuery();
                                //        con.Open();
                                //        cmd.Parameters.AddWithValue("@MALZEMEADI", txt_MALZEMEADI.Text);
                                //        cmd.Parameters.AddWithValue("@MALZEMEID", malzemeID);
                                //        cmd.Parameters.AddWithValue("@MIKTARI", txt_MIKTARI.Text);
                                //        //cmd.Parameters.AddWithValue("@ALISFIYATI", txt_ALISFIYATI.Text);
                                //        //cmd.Parameters.AddWithValue("@SATISFIYATI", txt_SATISFIYATI.Text);
                                //        cmd.Parameters.AddWithValue("@TARIH", txt_TARIH.Text);
                                //        cmd.ExecuteNonQuery();
                                //        con.Close();
                            }
                            if (aradepodakimiktar < dusulecekmiktar)
                            {
                                int malzememiktar = 0;
                                int icerikmiktar = 0;
                                int uyariMiktari = 0;
                                string malzemeAdi = "";
                                string query3 = "SELECT * FROM [dbo].[MALZEME] WHERE ID=" + MalzemeID;
                                using (SqlConnection con4 = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
                                {
                                    SqlCommand cmd3 = new SqlCommand(query3, con4);
                                    SqlDataReader r3 = null;
                                    con4.Open();
                                    r3 = cmd3.ExecuteReader();
                                    while (r3.Read())
                                    {
                                        malzememiktar = Convert.ToInt32(r3["MIKTARI"].ToString());
                                        icerikmiktar=Convert.ToInt32(r3["ICERIKMIKTARI"].ToString());
                                        uyariMiktari= Convert.ToInt32(r3["UYARIMIKTARI"].ToString());
                                        malzemeAdi = r3["MALZEMEADI"].ToString();
                                        break;
                                    }
                                    if (aradepodakimiktar + ( malzememiktar* icerikmiktar) < dusulecekmiktar)
                                        return false;
                                    else
                                    {
                                        while(aradepodakimiktar< dusulecekmiktar)
                                        {
                                            malzememiktar = malzememiktar - 1;
                                            aradepodakimiktar = aradepodakimiktar + icerikmiktar;
                                        }
                                        if(malzememiktar<= uyariMiktari)
                                        {
                                            MessageBox.Show(malzemeAdi+" malzemesi için uyarı miktarına ulaşılmıştır.Miktar=" +malzememiktar);
                                        }
                                        SqlCommand cmd4 = new SqlCommand("update [dbo].[ARADEPO] set MIKTARI=@MIKTARI where MALZEMEID=@MALZEMEID", conn);
                                        cmd4.Transaction = tran;
                                        cmd4.Parameters.AddWithValue("@MALZEMEID", MalzemeID);
                                        cmd4.Parameters.AddWithValue("@MIKTARI", aradepodakimiktar-dusulecekmiktar);
                                        cmd4.ExecuteNonQuery();


                                        SqlCommand cmd5 = new SqlCommand("update [dbo].[MALZEME] set MIKTARI=@MIKTARI where ID=@MALZEMEID", conn);
                                        cmd5.Transaction = tran;
                                        cmd5.Parameters.AddWithValue("@MALZEMEID", MalzemeID);
                                        cmd5.Parameters.AddWithValue("@MIKTARI", malzememiktar);
                                        cmd5.ExecuteNonQuery();
                                    }
                                }
                            }
                            else
                            {

                                SqlCommand cmd3 = new SqlCommand("update [dbo].[ARADEPO] set MIKTARI=MIKTARI-@MIKTARI where MALZEMEID=@MALZEMEID", conn);
                                cmd3.Transaction = tran;
                                cmd3.Parameters.AddWithValue("@MALZEMEID", MalzemeID);
                                cmd3.Parameters.AddWithValue("@MIKTARI", dusulecekmiktar);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            SqlTransaction tran = null;

            SqlCommand cmd;
            if (String.IsNullOrEmpty(txtSiparisNo.Text))
            {
                MessageBox.Show("Lütfen Sipariş Numarası Bilgisini Giriniz!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(this.mUSTERITableAdapter.Connection.ConnectionString))
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    for (int i = 0; i < dgrdSepet.Rows.Count; ++i)
                    {
                        if (AraDepodanDus(Convert.ToInt32(dgrdSepet.Rows[i].Cells[1].Value), Convert.ToInt32(dgrdSepet.Rows[i].Cells[3].Value), conn, tran) == false)
                        {
                            MessageBox.Show("Ara depoda " + GetUrunName(Convert.ToInt32(dgrdSepet.Rows[i].Cells[1].Value)) + " ürünü için malzeme kalmamıştır.Satış işlemi gerçekleşmemiştir.");
                            tran.Rollback();
                            conn.Close();
                            return;
                        }
                        string command = " INSERT INTO[dbo].[ANADEPO]([SIPARISNO],[URUNID],[MIKTAR],[TARIH],[MUSTERIID],[TOPLAMSATIS]) VALUES(@SIPARISNO,@URUNID,@MIKTAR,@TARIH,@MUSTERIID,@TOPLAMSATIS)";
                        cmd = new SqlCommand(command, conn);
                        cmd.Transaction = tran;
                        cmd.Parameters.AddWithValue("@SIPARISNO", txtSiparisNo.Text);
                        cmd.Parameters.AddWithValue("@URUNID", dgrdSepet.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@MIKTAR", dgrdSepet.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@TARIH", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MUSTERIID", MusteriID);
                        cmd.Parameters.AddWithValue("@TOPLAMSATIS", Convert.ToDouble(txtToplamSatis.Text));
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    conn.Close();
                    MessageBox.Show("Satış işlemi başarı ile gerçekleşmiştir");
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (tran != null)
                        tran.Rollback();
                }
                catch
                {
                    MessageBox.Show("Satış sırasında veritabanı hatası oluştu!");

                }
                MessageBox.Show("Satış sırasında veritabanı hatası oluştu!");
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
