namespace WindowsFormsApp1
{
    partial class SiparisKontrolUC
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
            this.sIPARISDURUMUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet4 = new WindowsFormsApp1.Stok_TakipDataSet4();
            this.sIPARISDURUMUTableAdapter = new WindowsFormsApp1.Stok_TakipDataSet4TableAdapters.SIPARISDURUMUTableAdapter();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.stok_TakipDataSet6 = new WindowsFormsApp1.Stok_TakipDataSet6();
            this.anaDepoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anaDepoViewTableAdapter = new WindowsFormsApp1.Stok_TakipDataSet6TableAdapters.AnaDepoViewTableAdapter();
            this.dgrdSiparisKontrol = new System.Windows.Forms.DataGridView();
            this.sIPARISNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMSATISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vKNTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORUMLUADSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaDepoViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet7 = new WindowsFormsApp1.Stok_TakipDataSet7();
            this.anaDepoViewTableAdapter1 = new WindowsFormsApp1.Stok_TakipDataSet7TableAdapters.AnaDepoViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sIPARISDURUMUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaDepoViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdSiparisKontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaDepoViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // sIPARISDURUMUBindingSource
            // 
            this.sIPARISDURUMUBindingSource.DataMember = "SIPARISDURUMU";
            this.sIPARISDURUMUBindingSource.DataSource = this.stok_TakipDataSet4;
            // 
            // stok_TakipDataSet4
            // 
            this.stok_TakipDataSet4.DataSetName = "Stok_TakipDataSet4";
            this.stok_TakipDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sIPARISDURUMUTableAdapter
            // 
            this.sIPARISDURUMUTableAdapter.ClearBeforeFill = true;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(873, 135);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(126, 37);
            this.btnAra.TabIndex = 34;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sipariş No";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(266, 108);
            this.txtSiparisNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(733, 21);
            this.txtSiparisNo.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Müşteri AD /TCKN/VKN/Sorumlu AD";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(266, 71);
            this.txtMusteri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(733, 21);
            this.txtMusteri.TabIndex = 40;
            // 
            // stok_TakipDataSet6
            // 
            this.stok_TakipDataSet6.DataSetName = "Stok_TakipDataSet6";
            this.stok_TakipDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaDepoViewBindingSource
            // 
            this.anaDepoViewBindingSource.DataMember = "AnaDepoView";
            this.anaDepoViewBindingSource.DataSource = this.stok_TakipDataSet6;
            // 
            // anaDepoViewTableAdapter
            // 
            this.anaDepoViewTableAdapter.ClearBeforeFill = true;
            // 
            // dgrdSiparisKontrol
            // 
            this.dgrdSiparisKontrol.AutoGenerateColumns = false;
            this.dgrdSiparisKontrol.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrdSiparisKontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdSiparisKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIPARISNODataGridViewTextBoxColumn,
            this.uRUNIDDataGridViewTextBoxColumn,
            this.mIKTARDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn,
            this.mUSTERIIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.tOPLAMSATISDataGridViewTextBoxColumn,
            this.mUSTERIADDataGridViewTextBoxColumn,
            this.vKNTCDataGridViewTextBoxColumn,
            this.sORUMLUADSOYADDataGridViewTextBoxColumn,
            this.uRUNADDataGridViewTextBoxColumn});
            this.dgrdSiparisKontrol.DataSource = this.anaDepoViewBindingSource1;
            this.dgrdSiparisKontrol.Location = new System.Drawing.Point(24, 204);
            this.dgrdSiparisKontrol.Name = "dgrdSiparisKontrol";
            this.dgrdSiparisKontrol.Size = new System.Drawing.Size(968, 251);
            this.dgrdSiparisKontrol.TabIndex = 42;
            // 
            // sIPARISNODataGridViewTextBoxColumn
            // 
            this.sIPARISNODataGridViewTextBoxColumn.DataPropertyName = "SIPARISNO";
            this.sIPARISNODataGridViewTextBoxColumn.HeaderText = "SIPARISNO";
            this.sIPARISNODataGridViewTextBoxColumn.Name = "sIPARISNODataGridViewTextBoxColumn";
            // 
            // uRUNIDDataGridViewTextBoxColumn
            // 
            this.uRUNIDDataGridViewTextBoxColumn.DataPropertyName = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.HeaderText = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.Name = "uRUNIDDataGridViewTextBoxColumn";
            this.uRUNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mIKTARDataGridViewTextBoxColumn
            // 
            this.mIKTARDataGridViewTextBoxColumn.DataPropertyName = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.HeaderText = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.Name = "mIKTARDataGridViewTextBoxColumn";
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            // 
            // mUSTERIIDDataGridViewTextBoxColumn
            // 
            this.mUSTERIIDDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIID";
            this.mUSTERIIDDataGridViewTextBoxColumn.HeaderText = "MUSTERIID";
            this.mUSTERIIDDataGridViewTextBoxColumn.Name = "mUSTERIIDDataGridViewTextBoxColumn";
            this.mUSTERIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOPLAMSATISDataGridViewTextBoxColumn
            // 
            this.tOPLAMSATISDataGridViewTextBoxColumn.DataPropertyName = "TOPLAMSATIS";
            this.tOPLAMSATISDataGridViewTextBoxColumn.HeaderText = "TOPLAMSATIS";
            this.tOPLAMSATISDataGridViewTextBoxColumn.Name = "tOPLAMSATISDataGridViewTextBoxColumn";
            // 
            // mUSTERIADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.HeaderText = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.Name = "mUSTERIADDataGridViewTextBoxColumn";
            this.mUSTERIADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vKNTCDataGridViewTextBoxColumn
            // 
            this.vKNTCDataGridViewTextBoxColumn.DataPropertyName = "VKN_TC";
            this.vKNTCDataGridViewTextBoxColumn.HeaderText = "VKN_TC";
            this.vKNTCDataGridViewTextBoxColumn.Name = "vKNTCDataGridViewTextBoxColumn";
            this.vKNTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sORUMLUADSOYADDataGridViewTextBoxColumn
            // 
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.DataPropertyName = "SORUMLUADSOYAD";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.HeaderText = "SORUMLUADSOYAD";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.Name = "sORUMLUADSOYADDataGridViewTextBoxColumn";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uRUNADDataGridViewTextBoxColumn
            // 
            this.uRUNADDataGridViewTextBoxColumn.DataPropertyName = "URUNAD";
            this.uRUNADDataGridViewTextBoxColumn.HeaderText = "URUNAD";
            this.uRUNADDataGridViewTextBoxColumn.Name = "uRUNADDataGridViewTextBoxColumn";
            this.uRUNADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anaDepoViewBindingSource1
            // 
            this.anaDepoViewBindingSource1.DataMember = "AnaDepoView";
            this.anaDepoViewBindingSource1.DataSource = this.stok_TakipDataSet7;
            // 
            // stok_TakipDataSet7
            // 
            this.stok_TakipDataSet7.DataSetName = "Stok_TakipDataSet7";
            this.stok_TakipDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaDepoViewTableAdapter1
            // 
            this.anaDepoViewTableAdapter1.ClearBeforeFill = true;
            // 
            // SiparisKontrolUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgrdSiparisKontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiparisNo);
            this.Controls.Add(this.btnAra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SiparisKontrolUC";
            this.Size = new System.Drawing.Size(1799, 953);
            ((System.ComponentModel.ISupportInitialize)(this.sIPARISDURUMUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaDepoViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdSiparisKontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaDepoViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sIPARISDURUMUBindingSource;
        private Stok_TakipDataSet4 stok_TakipDataSet4;
        private Stok_TakipDataSet4TableAdapters.SIPARISDURUMUTableAdapter sIPARISDURUMUTableAdapter;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparisNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteri;
        private Stok_TakipDataSet6 stok_TakipDataSet6;
        private System.Windows.Forms.BindingSource anaDepoViewBindingSource;
        private Stok_TakipDataSet6TableAdapters.AnaDepoViewTableAdapter anaDepoViewTableAdapter;
        private System.Windows.Forms.DataGridView dgrdSiparisKontrol;
        private System.Windows.Forms.BindingSource anaDepoViewBindingSource1;
        private Stok_TakipDataSet7 stok_TakipDataSet7;
        private Stok_TakipDataSet7TableAdapters.AnaDepoViewTableAdapter anaDepoViewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIPARISNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMSATISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vKNTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORUMLUADSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNADDataGridViewTextBoxColumn;
    }
}
