namespace WindowsFormsApp1
{
    partial class MusteriSiparisUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtToplamSatis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnClearSepet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgrdSepet = new System.Windows.Forms.DataGridView();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlışFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectedAd = new System.Windows.Forms.TextBox();
            this.txtSelectedTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUrun = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSepet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtADSorumluAdsoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrdMusteri = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNVANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vKNTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORUMLUADSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORUMLUTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRMATELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet = new WindowsFormsApp1.Stok_TakipDataSet();
            this.mUSTERITableAdapter = new WindowsFormsApp1.Stok_TakipDataSetTableAdapters.MUSTERITableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdSepet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4057F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.47227F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1821, 758);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.txtSiparisNo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtToplamSatis);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnSatis);
            this.groupBox3.Controls.Add(this.btnClearSepet);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.dgrdSepet);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(4, 439);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1813, 316);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sepet İşlemleri";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(247, 222);
            this.txtSiparisNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(379, 21);
            this.txtSiparisNo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 219);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sipariş No";
            // 
            // txtToplamSatis
            // 
            this.txtToplamSatis.Location = new System.Drawing.Point(247, 159);
            this.txtToplamSatis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtToplamSatis.Name = "txtToplamSatis";
            this.txtToplamSatis.ReadOnly = true;
            this.txtToplamSatis.Size = new System.Drawing.Size(379, 21);
            this.txtToplamSatis.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Toplam Satış Fiyatı";
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSatis.Location = new System.Drawing.Point(644, 216);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(501, 27);
            this.btnSatis.TabIndex = 6;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnClearSepet
            // 
            this.btnClearSepet.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClearSepet.Location = new System.Drawing.Point(896, 159);
            this.btnClearSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearSepet.Name = "btnClearSepet";
            this.btnClearSepet.Size = new System.Drawing.Size(249, 27);
            this.btnClearSepet.TabIndex = 5;
            this.btnClearSepet.Text = "Sepeti Boşalt";
            this.btnClearSepet.UseVisualStyleBackColor = false;
            this.btnClearSepet.Click += new System.EventHandler(this.btnClearSepet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSil.Location = new System.Drawing.Point(644, 159);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(244, 27);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgrdSepet
            // 
            this.dgrdSepet.AllowUserToAddRows = false;
            this.dgrdSepet.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrdSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kategori,
            this.URUNID1,
            this.Urun,
            this.Miktar,
            this.AlışFiyatı,
            this.SatışFiyatı});
            this.dgrdSepet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdSepet.Location = new System.Drawing.Point(4, 17);
            this.dgrdSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrdSepet.Name = "dgrdSepet";
            this.dgrdSepet.Size = new System.Drawing.Size(1805, 119);
            this.dgrdSepet.TabIndex = 0;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.MinimumWidth = 150;
            this.Kategori.Name = "Kategori";
            this.Kategori.Width = 150;
            // 
            // URUNID1
            // 
            this.URUNID1.HeaderText = "URUNID1";
            this.URUNID1.Name = "URUNID1";
            this.URUNID1.Visible = false;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Urun";
            this.Urun.MinimumWidth = 150;
            this.Urun.Name = "Urun";
            this.Urun.Width = 150;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.MinimumWidth = 100;
            this.Miktar.Name = "Miktar";
            // 
            // AlışFiyatı
            // 
            this.AlışFiyatı.HeaderText = "AlışFiyatı";
            this.AlışFiyatı.MinimumWidth = 125;
            this.AlışFiyatı.Name = "AlışFiyatı";
            this.AlışFiyatı.Width = 125;
            // 
            // SatışFiyatı
            // 
            this.SatışFiyatı.HeaderText = "SatışFiyatı";
            this.SatışFiyatı.MinimumWidth = 125;
            this.SatışFiyatı.Name = "SatışFiyatı";
            this.SatışFiyatı.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtSatis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAlis);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSelectedAd);
            this.groupBox2.Controls.Add(this.txtSelectedTC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboUrun);
            this.groupBox2.Controls.Add(this.comboKategori);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSepet);
            this.groupBox2.Location = new System.Drawing.Point(4, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1813, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(601, 104);
            this.txtSatis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(366, 21);
            this.txtSatis.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Satış Fiyatı";
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(112, 101);
            this.txtAlis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(346, 21);
            this.txtAlis.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Alış Fiyatı";
            // 
            // txtSelectedAd
            // 
            this.txtSelectedAd.Location = new System.Drawing.Point(506, 9);
            this.txtSelectedAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelectedAd.Name = "txtSelectedAd";
            this.txtSelectedAd.ReadOnly = true;
            this.txtSelectedAd.Size = new System.Drawing.Size(461, 21);
            this.txtSelectedAd.TabIndex = 16;
            // 
            // txtSelectedTC
            // 
            this.txtSelectedTC.Location = new System.Drawing.Point(112, 9);
            this.txtSelectedTC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelectedTC.Name = "txtSelectedTC";
            this.txtSelectedTC.ReadOnly = true;
            this.txtSelectedTC.Size = new System.Drawing.Size(337, 21);
            this.txtSelectedTC.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Müşteri";
            // 
            // comboUrun
            // 
            this.comboUrun.FormattingEnabled = true;
            this.comboUrun.Location = new System.Drawing.Point(112, 72);
            this.comboUrun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboUrun.Name = "comboUrun";
            this.comboUrun.Size = new System.Drawing.Size(855, 23);
            this.comboUrun.TabIndex = 13;
            this.comboUrun.SelectedIndexChanged += new System.EventHandler(this.comboUrun_SelectedIndexChanged);
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(112, 41);
            this.comboKategori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(855, 23);
            this.comboKategori.TabIndex = 12;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(112, 134);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(346, 21);
            this.txtMiktar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Miktar";
            // 
            // btnSepet
            // 
            this.btnSepet.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSepet.Location = new System.Drawing.Point(601, 131);
            this.btnSepet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(366, 27);
            this.btnSepet.TabIndex = 5;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.UseVisualStyleBackColor = false;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1813, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgrdMusteri, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1805, 226);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMusteriAra, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1797, 107);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.60892F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.39108F));
            this.tableLayoutPanel5.Controls.Add(this.txtADSorumluAdsoyad, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(603, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(591, 101);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // txtADSorumluAdsoyad
            // 
            this.txtADSorumluAdsoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtADSorumluAdsoyad.Location = new System.Drawing.Point(173, 3);
            this.txtADSorumluAdsoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtADSorumluAdsoyad.Name = "txtADSorumluAdsoyad";
            this.txtADSorumluAdsoyad.Size = new System.Drawing.Size(414, 21);
            this.txtADSorumluAdsoyad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "AD/SORUMLUADSOYAD";
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMusteriAra.Location = new System.Drawing.Point(1202, 3);
            this.btnMusteriAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(213, 27);
            this.btnMusteriAra.TabIndex = 5;
            this.btnMusteriAra.Text = "ARA";
            this.btnMusteriAra.UseVisualStyleBackColor = false;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.021F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.979F));
            this.tableLayoutPanel4.Controls.Add(this.txtTc, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(591, 101);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(193, 3);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(181, 21);
            this.txtTc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VKN/TCKN";
            // 
            // dgrdMusteri
            // 
            this.dgrdMusteri.AutoGenerateColumns = false;
            this.dgrdMusteri.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrdMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdMusteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.uNVANDataGridViewTextBoxColumn,
            this.vKNTCDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.sORUMLUADSOYADDataGridViewTextBoxColumn,
            this.sORUMLUTELDataGridViewTextBoxColumn,
            this.fIRMATELDataGridViewTextBoxColumn});
            this.dgrdMusteri.DataSource = this.mUSTERIBindingSource;
            this.dgrdMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrdMusteri.Location = new System.Drawing.Point(4, 116);
            this.dgrdMusteri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrdMusteri.Name = "dgrdMusteri";
            this.dgrdMusteri.Size = new System.Drawing.Size(1797, 107);
            this.dgrdMusteri.TabIndex = 8;
            this.dgrdMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMusteri_CellContentDoubleClick);
            this.dgrdMusteri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMusteri_CellContentDoubleClick);
            this.dgrdMusteri.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdMusteri_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 150;
            // 
            // uNVANDataGridViewTextBoxColumn
            // 
            this.uNVANDataGridViewTextBoxColumn.DataPropertyName = "UNVAN";
            this.uNVANDataGridViewTextBoxColumn.HeaderText = "UNVAN";
            this.uNVANDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.uNVANDataGridViewTextBoxColumn.Name = "uNVANDataGridViewTextBoxColumn";
            this.uNVANDataGridViewTextBoxColumn.Width = 150;
            // 
            // vKNTCDataGridViewTextBoxColumn
            // 
            this.vKNTCDataGridViewTextBoxColumn.DataPropertyName = "VKN_TC";
            this.vKNTCDataGridViewTextBoxColumn.HeaderText = "VKN_TC";
            this.vKNTCDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.vKNTCDataGridViewTextBoxColumn.Name = "vKNTCDataGridViewTextBoxColumn";
            this.vKNTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            // 
            // sORUMLUADSOYADDataGridViewTextBoxColumn
            // 
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.DataPropertyName = "SORUMLUADSOYAD";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.HeaderText = "SORUMLUADSOYAD";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.MinimumWidth = 175;
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.Name = "sORUMLUADSOYADDataGridViewTextBoxColumn";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.Width = 175;
            // 
            // sORUMLUTELDataGridViewTextBoxColumn
            // 
            this.sORUMLUTELDataGridViewTextBoxColumn.DataPropertyName = "SORUMLUTEL";
            this.sORUMLUTELDataGridViewTextBoxColumn.HeaderText = "SORUMLUTEL";
            this.sORUMLUTELDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.sORUMLUTELDataGridViewTextBoxColumn.Name = "sORUMLUTELDataGridViewTextBoxColumn";
            this.sORUMLUTELDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIRMATELDataGridViewTextBoxColumn
            // 
            this.fIRMATELDataGridViewTextBoxColumn.DataPropertyName = "FIRMATEL";
            this.fIRMATELDataGridViewTextBoxColumn.HeaderText = "FIRMATEL";
            this.fIRMATELDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.fIRMATELDataGridViewTextBoxColumn.Name = "fIRMATELDataGridViewTextBoxColumn";
            this.fIRMATELDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERIBindingSource
            // 
            this.mUSTERIBindingSource.DataMember = "MUSTERI";
            this.mUSTERIBindingSource.DataSource = this.stok_TakipDataSet;
            // 
            // stok_TakipDataSet
            // 
            this.stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUSTERITableAdapter
            // 
            this.mUSTERITableAdapter.ClearBeforeFill = true;
            // 
            // MusteriSiparisUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MusteriSiparisUC";
            this.Size = new System.Drawing.Size(1821, 758);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdSepet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearSepet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgrdSepet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Stok_TakipDataSet stok_TakipDataSet;
        private System.Windows.Forms.BindingSource mUSTERIBindingSource;
        private Stok_TakipDataSetTableAdapters.MUSTERITableAdapter mUSTERITableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtADSorumluAdsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgrdMusteri;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNVANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vKNTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORUMLUADSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORUMLUTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRMATELDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboUrun;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedAd;
        private System.Windows.Forms.TextBox txtSelectedTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToplamSatis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlışFiyatı;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışFiyatı;
    }
}
