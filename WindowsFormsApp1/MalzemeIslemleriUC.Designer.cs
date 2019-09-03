namespace WindowsFormsApp1
{
    partial class MalzemeIslemleriUC
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
            this.bARKODNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALZEMEADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALZEMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet3 = new WindowsFormsApp1.Stok_TakipDataSet3();
            this.mALZEMETableAdapter = new WindowsFormsApp1.Stok_TakipDataSet3TableAdapters.MALZEMETableAdapter();
            this.txt_MALZEMEADI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BARKODNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
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
            this.bARKODNODataGridViewTextBoxColumn,
            this.mALZEMEADIDataGridViewTextBoxColumn});
            this.dgrdMalzeme.DataSource = this.mALZEMEBindingSource;
            this.dgrdMalzeme.Location = new System.Drawing.Point(22, 332);
            this.dgrdMalzeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrdMalzeme.Name = "dgrdMalzeme";
            this.dgrdMalzeme.Size = new System.Drawing.Size(966, 384);
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
            // bARKODNODataGridViewTextBoxColumn
            // 
            this.bARKODNODataGridViewTextBoxColumn.DataPropertyName = "BARKODNO";
            this.bARKODNODataGridViewTextBoxColumn.HeaderText = "BARKODNO";
            this.bARKODNODataGridViewTextBoxColumn.MinimumWidth = 125;
            this.bARKODNODataGridViewTextBoxColumn.Name = "bARKODNODataGridViewTextBoxColumn";
            this.bARKODNODataGridViewTextBoxColumn.Width = 125;
            // 
            // mALZEMEADIDataGridViewTextBoxColumn
            // 
            this.mALZEMEADIDataGridViewTextBoxColumn.DataPropertyName = "MALZEMEADI";
            this.mALZEMEADIDataGridViewTextBoxColumn.HeaderText = "MALZEMEADI";
            this.mALZEMEADIDataGridViewTextBoxColumn.MinimumWidth = 175;
            this.mALZEMEADIDataGridViewTextBoxColumn.Name = "mALZEMEADIDataGridViewTextBoxColumn";
            this.mALZEMEADIDataGridViewTextBoxColumn.Width = 175;
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
            // txt_MALZEMEADI
            // 
            this.txt_MALZEMEADI.Location = new System.Drawing.Point(1194, 483);
            this.txt_MALZEMEADI.Name = "txt_MALZEMEADI";
            this.txt_MALZEMEADI.Size = new System.Drawing.Size(200, 21);
            this.txt_MALZEMEADI.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1053, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Malzeme Adı";
            // 
            // txt_BARKODNO
            // 
            this.txt_BARKODNO.Location = new System.Drawing.Point(1194, 437);
            this.txt_BARKODNO.Name = "txt_BARKODNO";
            this.txt_BARKODNO.Size = new System.Drawing.Size(200, 21);
            this.txt_BARKODNO.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1052, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Barkod No";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(1185, 547);
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
            this.btnEkle.Location = new System.Drawing.Point(1056, 547);
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
            this.btnSil.Location = new System.Drawing.Point(1314, 547);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 43);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(513, 257);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(355, 21);
            this.txtAra.TabIndex = 42;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(907, 246);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 43);
            this.btnAra.TabIndex = 41;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // MalzemeIslemleriUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
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
            this.Name = "MalzemeIslemleriUC";
            this.Size = new System.Drawing.Size(1495, 978);
            this.Load += new System.EventHandler(this.MalzemeIslemleriUC_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARKODNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALZEMEADIDataGridViewTextBoxColumn;
    }
}
