namespace WindowsFormsApp1
{
    partial class AraDepoIslemleriUC
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
            this.dgrdMalzeme = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALZEMEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALZEMEADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALZEMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet3 = new WindowsFormsApp1.Stok_TakipDataSet3();
            this.mALZEMETableAdapter = new WindowsFormsApp1.Stok_TakipDataSet3TableAdapters.MALZEMETableAdapter();
            this.txt_TARIH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SATISFIYATI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ALISFIYATI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MIKTARI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MALZEMEADI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BARKODNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.malzemeListbox = new System.Windows.Forms.CheckedListBox();
            this.txtMalzemeAra = new System.Windows.Forms.TextBox();
            this.btnMalzemeAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMalzeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALZEMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdMalzeme
            // 
            this.dgrdMalzeme.AutoGenerateColumns = false;
            this.dgrdMalzeme.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrdMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdMalzeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MALZEMEID,
            this.mALZEMEADIDataGridViewTextBoxColumn,
            this.mIKTARIDataGridViewTextBoxColumn,
            this.aLISFIYATIDataGridViewTextBoxColumn,
            this.sATISFIYATIDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dgrdMalzeme.DataSource = this.mALZEMEBindingSource;
            this.dgrdMalzeme.Location = new System.Drawing.Point(22, 508);
            this.dgrdMalzeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrdMalzeme.Name = "dgrdMalzeme";
            this.dgrdMalzeme.Size = new System.Drawing.Size(966, 208);
            this.dgrdMalzeme.TabIndex = 0;
            this.dgrdMalzeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgrdMalzeme.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgrdMalzeme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdMalzemeIslemleri_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MALZEMEID
            // 
            this.MALZEMEID.DataPropertyName = "MALZEMEID";
            this.MALZEMEID.HeaderText = "MALZEMEID";
            this.MALZEMEID.Name = "MALZEMEID";
            this.MALZEMEID.Visible = false;
            // 
            // mALZEMEADIDataGridViewTextBoxColumn
            // 
            this.mALZEMEADIDataGridViewTextBoxColumn.DataPropertyName = "MALZEMEADI";
            this.mALZEMEADIDataGridViewTextBoxColumn.HeaderText = "MALZEMEADI";
            this.mALZEMEADIDataGridViewTextBoxColumn.MinimumWidth = 175;
            this.mALZEMEADIDataGridViewTextBoxColumn.Name = "mALZEMEADIDataGridViewTextBoxColumn";
            this.mALZEMEADIDataGridViewTextBoxColumn.Width = 175;
            // 
            // mIKTARIDataGridViewTextBoxColumn
            // 
            this.mIKTARIDataGridViewTextBoxColumn.DataPropertyName = "MIKTARI";
            this.mIKTARIDataGridViewTextBoxColumn.HeaderText = "MIKTARI";
            this.mIKTARIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.mIKTARIDataGridViewTextBoxColumn.Name = "mIKTARIDataGridViewTextBoxColumn";
            // 
            // aLISFIYATIDataGridViewTextBoxColumn
            // 
            this.aLISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.HeaderText = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.aLISFIYATIDataGridViewTextBoxColumn.Name = "aLISFIYATIDataGridViewTextBoxColumn";
            // 
            // sATISFIYATIDataGridViewTextBoxColumn
            // 
            this.sATISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.HeaderText = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sATISFIYATIDataGridViewTextBoxColumn.Name = "sATISFIYATIDataGridViewTextBoxColumn";
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            this.tARIHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mALZEMEBindingSource
            // 
            this.mALZEMEBindingSource.DataMember = "MALZEME";
            this.mALZEMEBindingSource.DataSource = this.stok_TakipDataSet3;
            // 
            // stok_TakipDataSet3
            // 
            this.stok_TakipDataSet3.DataSetName = "Stok_TakipDataSet3";
            this.stok_TakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mALZEMETableAdapter
            // 
            this.mALZEMETableAdapter.ClearBeforeFill = true;
            // 
            // txt_TARIH
            // 
            this.txt_TARIH.Location = new System.Drawing.Point(1194, 551);
            this.txt_TARIH.Name = "txt_TARIH";
            this.txt_TARIH.Size = new System.Drawing.Size(200, 21);
            this.txt_TARIH.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1052, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tarih";
            // 
            // txt_SATISFIYATI
            // 
            this.txt_SATISFIYATI.Location = new System.Drawing.Point(1194, 508);
            this.txt_SATISFIYATI.Name = "txt_SATISFIYATI";
            this.txt_SATISFIYATI.Size = new System.Drawing.Size(200, 21);
            this.txt_SATISFIYATI.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1052, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Satış Fiyatı";
            // 
            // txt_ALISFIYATI
            // 
            this.txt_ALISFIYATI.Location = new System.Drawing.Point(1194, 465);
            this.txt_ALISFIYATI.Name = "txt_ALISFIYATI";
            this.txt_ALISFIYATI.Size = new System.Drawing.Size(200, 21);
            this.txt_ALISFIYATI.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1052, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Alış Fiyatı";
            // 
            // txt_MIKTARI
            // 
            this.txt_MIKTARI.Location = new System.Drawing.Point(1194, 421);
            this.txt_MIKTARI.Multiline = true;
            this.txt_MIKTARI.Name = "txt_MIKTARI";
            this.txt_MIKTARI.Size = new System.Drawing.Size(200, 22);
            this.txt_MIKTARI.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1053, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Miktarı";
            // 
            // txt_MALZEMEADI
            // 
            this.txt_MALZEMEADI.Location = new System.Drawing.Point(1194, 378);
            this.txt_MALZEMEADI.Name = "txt_MALZEMEADI";
            this.txt_MALZEMEADI.Size = new System.Drawing.Size(200, 21);
            this.txt_MALZEMEADI.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1053, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Malzeme Adı";
            // 
            // txt_BARKODNO
            // 
            this.txt_BARKODNO.Location = new System.Drawing.Point(1194, 332);
            this.txt_BARKODNO.Name = "txt_BARKODNO";
            this.txt_BARKODNO.Size = new System.Drawing.Size(200, 21);
            this.txt_BARKODNO.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1052, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Barkod No";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(1185, 673);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(80, 43);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(1056, 673);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 43);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(1314, 673);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 43);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(22, 443);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(822, 21);
            this.txtAra.TabIndex = 42;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(869, 432);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 43);
            this.btnAra.TabIndex = 41;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // malzemeListbox
            // 
            this.malzemeListbox.FormattingEnabled = true;
            this.malzemeListbox.Location = new System.Drawing.Point(22, 233);
            this.malzemeListbox.Name = "malzemeListbox";
            this.malzemeListbox.Size = new System.Drawing.Size(965, 180);
            this.malzemeListbox.TabIndex = 43;
            this.malzemeListbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.malzemeListbox_ItemCheck);
            this.malzemeListbox.SelectedIndexChanged += new System.EventHandler(this.malzemeListbox_SelectedIndexChanged);
            // 
            // txtMalzemeAra
            // 
            this.txtMalzemeAra.Location = new System.Drawing.Point(22, 145);
            this.txtMalzemeAra.Name = "txtMalzemeAra";
            this.txtMalzemeAra.Size = new System.Drawing.Size(822, 21);
            this.txtMalzemeAra.TabIndex = 46;
            // 
            // btnMalzemeAra
            // 
            this.btnMalzemeAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMalzemeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeAra.Location = new System.Drawing.Point(869, 134);
            this.btnMalzemeAra.Name = "btnMalzemeAra";
            this.btnMalzemeAra.Size = new System.Drawing.Size(80, 43);
            this.btnMalzemeAra.TabIndex = 45;
            this.btnMalzemeAra.Text = "Ara";
            this.btnMalzemeAra.UseVisualStyleBackColor = false;
            this.btnMalzemeAra.Click += new System.EventHandler(this.btnMalzemeAra_Click);
            // 
            // AraDepoIslemleriUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMalzemeAra);
            this.Controls.Add(this.btnMalzemeAra);
            this.Controls.Add(this.malzemeListbox);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txt_TARIH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_SATISFIYATI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ALISFIYATI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MIKTARI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MALZEMEADI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BARKODNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgrdMalzeme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AraDepoIslemleriUC";
            this.Size = new System.Drawing.Size(1495, 978);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMalzeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALZEMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdMalzeme;
        private System.Windows.Forms.BindingSource mALZEMEBindingSource;
        private Stok_TakipDataSet3 stok_TakipDataSet3;
        private Stok_TakipDataSet3TableAdapters.MALZEMETableAdapter mALZEMETableAdapter;
        private System.Windows.Forms.TextBox txt_TARIH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SATISFIYATI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ALISFIYATI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MIKTARI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MALZEMEADI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BARKODNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.CheckedListBox malzemeListbox;
        private System.Windows.Forms.TextBox txtMalzemeAra;
        private System.Windows.Forms.Button btnMalzemeAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARKODNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALZEMEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALZEMEADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
    }
}
