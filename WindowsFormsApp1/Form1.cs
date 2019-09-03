using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MusteriIslemleriUC musteriIslemleriUC = new MusteriIslemleriUC();

        MusteriSiparisUC musteriSiparisUC = new MusteriSiparisUC();

        UrunIslemleriUC urunIslemleriUC = new UrunIslemleriUC();

        UrunMalzemeIslemleriUC urunMalzemeIslemleriUC = new UrunMalzemeIslemleriUC();


        MalzemeIslemleriUC malzemeIslemleriUC = new MalzemeIslemleriUC();


        KategoriİslemleriUC kategoriIslemleriUC = new KategoriİslemleriUC();

        SiparisKontrolUC siparisKontrolUC = new SiparisKontrolUC();

        AraDepoIslemleriUC araDepoIslemleriUC = new AraDepoIslemleriUC();



        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMüşteriİşlemleri_Click(object sender, EventArgs e)
        {
           
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            musteriIslemleriUC = new MusteriIslemleriUC();
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            musteriIslemleriUC.Width = this.Width;
            musteriIslemleriUC.Height = this.Height;
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            urunMalzemeIslemleriUC.Hide();
            siparisKontrolUC.Hide();
            araDepoIslemleriUC.Hide();
            malzemeIslemleriUC.Hide();
            musteriIslemleriUC.Show();
            musteriIslemleriUC.initializeGridView();
            musteriIslemleriUC.BringToFront();
            // musteriIslemleriUC1.Show();
            // musteriIslemleriUC1.BringToFront();
            // musteriIslemleriUC1.initializeGridView();
            pnlRight.Controls.Add(musteriIslemleriUC);
            
        }

        private void btnKategoriİşlemleri_Click(object sender, EventArgs e)
        {
            //KategoriİslemleriUC kategoriİslemleriUC = new KategoriİslemleriUC();
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            kategoriIslemleriUC = new KategoriİslemleriUC();
            pnlRight.Controls.Remove(siparisKontrolUC);
            kategoriIslemleriUC.Width = this.Width;
            kategoriIslemleriUC.Height = this.Height;
            musteriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            urunMalzemeIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();

            araDepoIslemleriUC.Hide();
            malzemeIslemleriUC.Hide();
            kategoriIslemleriUC.initializeGridView();
            kategoriIslemleriUC.Show();
            kategoriIslemleriUC.BringToFront();
            pnlRight.Controls.Add(kategoriIslemleriUC);


        }

        private void btnÜrünİşlemleri_Click(object sender, EventArgs e)
        {

            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(urunIslemleriUC);
            urunIslemleriUC = new UrunIslemleriUC();
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            urunIslemleriUC.Width = this.Width;
            urunIslemleriUC.Height = this.Height;
            urunIslemleriUC.initializeGridView();
            musteriIslemleriUC.Hide();
            kategoriIslemleriUC.Hide();
            urunMalzemeIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();

            araDepoIslemleriUC.Hide();
            malzemeIslemleriUC.Hide();
            urunIslemleriUC.Show();
            urunIslemleriUC.BringToFront();
            urunIslemleriUC.initializeGridView();
            pnlRight.Controls.Add(urunIslemleriUC);
        }

        private void btnUrunMalzemeIslemleri_Click(object sender, EventArgs e)
        {

            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            urunMalzemeIslemleriUC = new UrunMalzemeIslemleriUC();
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            urunMalzemeIslemleriUC.Width = this.Width;
            urunMalzemeIslemleriUC.Height = this.Height;
            urunMalzemeIslemleriUC.initializeGridView();
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();

            malzemeIslemleriUC.Hide();
            araDepoIslemleriUC.Hide();
            urunMalzemeIslemleriUC.Show();
            urunMalzemeIslemleriUC.BringToFront();
            urunMalzemeIslemleriUC.initializeGridView();
            pnlRight.Controls.Add(urunMalzemeIslemleriUC);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            urunMalzemeIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            musteriSiparisUC.Hide();
            malzemeIslemleriUC.Hide();
            this.SizeChanged += Form1_SizeChanged;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            musteriSiparisUC.MusteriSiparisUC_SizeChange();
        }

        private void btnMüşteriSipariş_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            musteriSiparisUC = new MusteriSiparisUC();
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            musteriSiparisUC.Width = this.Width;
            musteriSiparisUC.Height = this.Height;
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();

            araDepoIslemleriUC.Hide();
            malzemeIslemleriUC.Hide();
            musteriSiparisUC.Show();
            musteriSiparisUC.BringToFront();
            pnlRight.Controls.Add(musteriSiparisUC);
        }

        private void btnSiparişKontrol_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            pnlRight.Controls.Remove(malzemeIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            siparisKontrolUC = new SiparisKontrolUC();
            
            siparisKontrolUC.Width = this.Width;
            siparisKontrolUC.Height = this.Height;
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            musteriSiparisUC.Hide();
            siparisKontrolUC.initializeGridView();
            siparisKontrolUC.Show();
            siparisKontrolUC.BringToFront();
            pnlRight.Controls.Add(siparisKontrolUC);
        }

        private void btnMalzemeIslemleri_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(malzemeIslemleriUC);
            malzemeIslemleriUC = new MalzemeIslemleriUC();
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            pnlRight.Controls.Remove(araDepoIslemleriUC);
            malzemeIslemleriUC.Width = this.Width;
            malzemeIslemleriUC.Height = this.Height;
            malzemeIslemleriUC.initializeGridView();
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();
            malzemeIslemleriUC.Show();
            malzemeIslemleriUC.BringToFront();
            malzemeIslemleriUC.initializeGridView();
            pnlRight.Controls.Add(malzemeIslemleriUC);
        }

        private void btnAraDepo_Click(object sender, EventArgs e)
        {
            pnlRight.Controls.Remove(urunMalzemeIslemleriUC);
            pnlRight.Controls.Remove(malzemeIslemleriUC);

            pnlRight.Controls.Remove(araDepoIslemleriUC);
            araDepoIslemleriUC = new AraDepoIslemleriUC();
            pnlRight.Controls.Remove(urunIslemleriUC);
            pnlRight.Controls.Remove(musteriIslemleriUC);
            pnlRight.Controls.Remove(musteriSiparisUC);
            pnlRight.Controls.Remove(kategoriIslemleriUC);
            pnlRight.Controls.Remove(siparisKontrolUC);
            urunMalzemeIslemleriUC.Width = this.Width;
            urunMalzemeIslemleriUC.Height = this.Height;
            urunMalzemeIslemleriUC.initializeGridView();
            kategoriIslemleriUC.Hide();
            urunIslemleriUC.Hide();
            musteriIslemleriUC.Hide();
            siparisKontrolUC.Hide();
            araDepoIslemleriUC.Show();
            araDepoIslemleriUC.BringToFront();
            araDepoIslemleriUC.initializeGridView();
            pnlRight.Controls.Add(araDepoIslemleriUC);

        }

        private void PnlRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
