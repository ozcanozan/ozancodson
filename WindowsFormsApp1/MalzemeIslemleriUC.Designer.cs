﻿namespace WindowsFormsApp1
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
            this.txt_MIKTARI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtİcerikMiktari = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bARKODNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALZEMEADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIKTARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICERIKMIKTARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UYARIMIKTARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_uyariMiktari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.mALZEMEADIDataGridViewTextBoxColumn,
            this.MIKTARI,
            this.ICERIKMIKTARI,
            this.UYARIMIKTARI});
            this.dgrdMalzeme.DataSource = this.mALZEMEBindingSource;
            this.dgrdMalzeme.Location = new System.Drawing.Point(22, 238);
            this.dgrdMalzeme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgrdMalzeme.Name = "dgrdMalzeme";
            this.dgrdMalzeme.Size = new System.Drawing.Size(966, 444);
            this.dgrdMalzeme.TabIndex = 0;
            this.dgrdMalzeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgrdMalzeme.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgrdMalzeme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdMalzemeIslemleri_RowHeaderMouseClick);
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
            this.txt_MALZEMEADI.Location = new System.Drawing.Point(1194, 389);
            this.txt_MALZEMEADI.Name = "txt_MALZEMEADI";
            this.txt_MALZEMEADI.Size = new System.Drawing.Size(200, 21);
            this.txt_MALZEMEADI.TabIndex = 31;
            this.txt_MALZEMEADI.TextChanged += new System.EventHandler(this.Txt_MALZEMEADI_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1053, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Malzeme Adı";
            // 
            // txt_BARKODNO
            // 
            this.txt_BARKODNO.Location = new System.Drawing.Point(1194, 343);
            this.txt_BARKODNO.Name = "txt_BARKODNO";
            this.txt_BARKODNO.Size = new System.Drawing.Size(200, 21);
            this.txt_BARKODNO.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1053, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Barkod No";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(1199, 602);
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
            this.btnEkle.Location = new System.Drawing.Point(1070, 602);
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
            this.btnSil.Location = new System.Drawing.Point(1328, 602);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 43);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(513, 163);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(355, 21);
            this.txtAra.TabIndex = 42;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(907, 152);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 43);
            this.btnAra.TabIndex = 41;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txt_MIKTARI
            // 
            this.txt_MIKTARI.Location = new System.Drawing.Point(1194, 440);
            this.txt_MIKTARI.Name = "txt_MIKTARI";
            this.txt_MIKTARI.Size = new System.Drawing.Size(200, 21);
            this.txt_MIKTARI.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1053, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1053, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "İçerik Miktarı";
            // 
            // txtİcerikMiktari
            // 
            this.txtİcerikMiktari.Location = new System.Drawing.Point(1194, 496);
            this.txtİcerikMiktari.Name = "txtİcerikMiktari";
            this.txtİcerikMiktari.Size = new System.Drawing.Size(200, 21);
            this.txtİcerikMiktari.TabIndex = 46;
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
            // MIKTARI
            // 
            this.MIKTARI.DataPropertyName = "MIKTARI";
            this.MIKTARI.HeaderText = "MIKTARI";
            this.MIKTARI.MinimumWidth = 100;
            this.MIKTARI.Name = "MIKTARI";
            // 
            // ICERIKMIKTARI
            // 
            this.ICERIKMIKTARI.DataPropertyName = "ICERIKMIKTARI";
            this.ICERIKMIKTARI.HeaderText = "ICERIKMIKTARI";
            this.ICERIKMIKTARI.Name = "ICERIKMIKTARI";
            // 
            // UYARIMIKTARI
            // 
            this.UYARIMIKTARI.DataPropertyName = "UYARIMIKTARI";
            this.UYARIMIKTARI.HeaderText = "UYARIMIKTARI";
            this.UYARIMIKTARI.Name = "UYARIMIKTARI";
            // 
            // txt_uyariMiktari
            // 
            this.txt_uyariMiktari.Location = new System.Drawing.Point(1194, 547);
            this.txt_uyariMiktari.Name = "txt_uyariMiktari";
            this.txt_uyariMiktari.Size = new System.Drawing.Size(200, 21);
            this.txt_uyariMiktari.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1053, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Uyarı Miktarı";
            // 
            // MalzemeIslemleriUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_uyariMiktari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtİcerikMiktari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MIKTARI);
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
        private System.Windows.Forms.TextBox txt_MIKTARI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtİcerikMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bARKODNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALZEMEADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIKTARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICERIKMIKTARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn UYARIMIKTARI;
        private System.Windows.Forms.TextBox txt_uyariMiktari;
        private System.Windows.Forms.Label label4;
    }
}
