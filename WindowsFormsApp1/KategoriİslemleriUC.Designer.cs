namespace WindowsFormsApp1
{
    partial class KategoriİslemleriUC
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
            this.stok_TakipDataSet = new WindowsFormsApp1.Stok_TakipDataSet();
            this.mUSTERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mUSTERITableAdapter = new WindowsFormsApp1.Stok_TakipDataSetTableAdapters.MUSTERITableAdapter();
            this.kATEGORIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet1 = new WindowsFormsApp1.Stok_TakipDataSet1();
            this.kATEGORITableAdapter = new WindowsFormsApp1.Stok_TakipDataSet1TableAdapters.KATEGORITableAdapter();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgrdKategori = new System.Windows.Forms.DataGridView();
            this.kATEGORIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet5 = new WindowsFormsApp1.Stok_TakipDataSet5();
            this.kATEGORITableAdapter1 = new WindowsFormsApp1.Stok_TakipDataSet5TableAdapters.KATEGORITableAdapter();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // stok_TakipDataSet
            // 
            this.stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUSTERIBindingSource
            // 
            this.mUSTERIBindingSource.DataMember = "MUSTERI";
            this.mUSTERIBindingSource.DataSource = this.stok_TakipDataSet;
            // 
            // mUSTERITableAdapter
            // 
            this.mUSTERITableAdapter.ClearBeforeFill = true;
            // 
            // kATEGORIBindingSource
            // 
            this.kATEGORIBindingSource.DataSource = this.stok_TakipDataSet;
            this.kATEGORIBindingSource.Position = 0;
            // 
            // stok_TakipDataSet1
            // 
            this.stok_TakipDataSet1.DataSetName = "Stok_TakipDataSet1";
            this.stok_TakipDataSet1.Locale = new System.Globalization.CultureInfo("en-GB");
            this.stok_TakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kATEGORITableAdapter
            // 
            this.kATEGORITableAdapter.ClearBeforeFill = true;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(1202, 340);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(200, 21);
            this.txt_Ad.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1060, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(1193, 421);
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
            this.btnEkle.Location = new System.Drawing.Point(1064, 421);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 43);
            this.btnEkle.TabIndex = 26;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(1322, 421);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 43);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgrdKategori
            // 
            this.dgrdKategori.AutoGenerateColumns = false;
            this.dgrdKategori.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrdKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdKategori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn});
            this.dgrdKategori.DataSource = this.kATEGORIBindingSource1;
            this.dgrdKategori.Location = new System.Drawing.Point(18, 161);
            this.dgrdKategori.Name = "dgrdKategori";
            this.dgrdKategori.Size = new System.Drawing.Size(1016, 560);
            this.dgrdKategori.TabIndex = 30;
            this.dgrdKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdKategori_CellContentClick);
            this.dgrdKategori.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdKategori_CellContentDoubleClick);
            this.dgrdKategori.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgrdKategori_RowHeaderMouseClick);
            // 
            // kATEGORIBindingSource1
            // 
            this.kATEGORIBindingSource1.DataMember = "KATEGORI";
            this.kATEGORIBindingSource1.DataSource = this.stok_TakipDataSet5;
            // 
            // stok_TakipDataSet5
            // 
            this.stok_TakipDataSet5.DataSetName = "Stok_TakipDataSet5";
            this.stok_TakipDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kATEGORITableAdapter1
            // 
            this.kATEGORITableAdapter1.ClearBeforeFill = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(632, 96);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(266, 21);
            this.txtAra.TabIndex = 31;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(929, 85);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(105, 43);
            this.btnAra.TabIndex = 32;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 500;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 500;
            // 
            // KategoriİslemleriUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgrdKategori);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KategoriİslemleriUC";
            this.Size = new System.Drawing.Size(1503, 985);
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kATEGORIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private Stok_TakipDataSet stok_TakipDataSet;
        private System.Windows.Forms.BindingSource mUSTERIBindingSource;
        private Stok_TakipDataSetTableAdapters.MUSTERITableAdapter mUSTERITableAdapter;
        private Stok_TakipDataSet1 stok_TakipDataSet1;
        private System.Windows.Forms.BindingSource kATEGORIBindingSource;
        private Stok_TakipDataSet1TableAdapters.KATEGORITableAdapter kATEGORITableAdapter;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgrdKategori;
        private System.Windows.Forms.BindingSource kATEGORIBindingSource1;
        private Stok_TakipDataSet5 stok_TakipDataSet5;
        private Stok_TakipDataSet5TableAdapters.KATEGORITableAdapter kATEGORITableAdapter1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
    }
}
