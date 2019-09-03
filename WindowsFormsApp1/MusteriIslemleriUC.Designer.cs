namespace WindowsFormsApp1
{
    partial class MusteriIslemleriUC
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
            this.mUSTERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_TakipDataSet = new WindowsFormsApp1.Stok_TakipDataSet();
            this.mUSTERITableAdapter = new WindowsFormsApp1.Stok_TakipDataSetTableAdapters.MUSTERITableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txt_UNVAN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_FIRMATEL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SORUMLUTEL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SORUMLUADSOYAD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ADRES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_VKN_TC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgrdMusteri = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNVANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vKNTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORUMLUADSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORUMLUTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRMATELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMusteri)).BeginInit();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txt_UNVAN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_FIRMATEL);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_SORUMLUTEL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_SORUMLUADSOYAD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_ADRES);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_VKN_TC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_AD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.dgrdMusteri);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 775);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 106);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(871, 21);
            this.txtAra.TabIndex = 26;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(918, 83);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 43);
            this.btnAra.TabIndex = 25;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txt_UNVAN
            // 
            this.txt_UNVAN.Location = new System.Drawing.Point(1164, 226);
            this.txt_UNVAN.Name = "txt_UNVAN";
            this.txt_UNVAN.Size = new System.Drawing.Size(200, 21);
            this.txt_UNVAN.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1022, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Unvan";
            // 
            // txt_FIRMATEL
            // 
            this.txt_FIRMATEL.Location = new System.Drawing.Point(1164, 552);
            this.txt_FIRMATEL.Name = "txt_FIRMATEL";
            this.txt_FIRMATEL.Size = new System.Drawing.Size(200, 21);
            this.txt_FIRMATEL.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1022, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Firma Tel";
            // 
            // txt_SORUMLUTEL
            // 
            this.txt_SORUMLUTEL.Location = new System.Drawing.Point(1164, 512);
            this.txt_SORUMLUTEL.Name = "txt_SORUMLUTEL";
            this.txt_SORUMLUTEL.Size = new System.Drawing.Size(200, 21);
            this.txt_SORUMLUTEL.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1022, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sorumlu Tel";
            // 
            // txt_SORUMLUADSOYAD
            // 
            this.txt_SORUMLUADSOYAD.Location = new System.Drawing.Point(1164, 472);
            this.txt_SORUMLUADSOYAD.Name = "txt_SORUMLUADSOYAD";
            this.txt_SORUMLUADSOYAD.Size = new System.Drawing.Size(200, 21);
            this.txt_SORUMLUADSOYAD.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1022, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sorumlu Ad Soyad";
            // 
            // txt_ADRES
            // 
            this.txt_ADRES.Location = new System.Drawing.Point(1164, 314);
            this.txt_ADRES.Multiline = true;
            this.txt_ADRES.Name = "txt_ADRES";
            this.txt_ADRES.Size = new System.Drawing.Size(200, 128);
            this.txt_ADRES.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1025, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adres";
            // 
            // txt_VKN_TC
            // 
            this.txt_VKN_TC.Location = new System.Drawing.Point(1164, 275);
            this.txt_VKN_TC.Name = "txt_VKN_TC";
            this.txt_VKN_TC.Size = new System.Drawing.Size(200, 21);
            this.txt_VKN_TC.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "VKN/TCKN";
            // 
            // txt_AD
            // 
            this.txt_AD.Location = new System.Drawing.Point(1164, 184);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(200, 21);
            this.txt_AD.TabIndex = 10;
            this.txt_AD.TextChanged += new System.EventHandler(this.txt_AD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(1154, 639);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(80, 43);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(1025, 639);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 43);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(1283, 639);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 43);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.dgrdMusteri.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrdMusteri.GridColor = System.Drawing.SystemColors.Control;
            this.dgrdMusteri.Location = new System.Drawing.Point(13, 170);
            this.dgrdMusteri.Name = "dgrdMusteri";
            this.dgrdMusteri.Size = new System.Drawing.Size(985, 512);
            this.dgrdMusteri.TabIndex = 3;
            this.dgrdMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMusteri_CellContentClick);
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
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uNVANDataGridViewTextBoxColumn
            // 
            this.uNVANDataGridViewTextBoxColumn.DataPropertyName = "UNVAN";
            this.uNVANDataGridViewTextBoxColumn.HeaderText = "UNVAN";
            this.uNVANDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.uNVANDataGridViewTextBoxColumn.Name = "uNVANDataGridViewTextBoxColumn";
            this.uNVANDataGridViewTextBoxColumn.Width = 125;
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
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.Name = "sORUMLUADSOYADDataGridViewTextBoxColumn";
            this.sORUMLUADSOYADDataGridViewTextBoxColumn.Width = 150;
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
            // MusteriIslemleriUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MusteriIslemleriUC";
            this.Size = new System.Drawing.Size(1413, 758);
            ((System.ComponentModel.ISupportInitialize)(this.mUSTERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_TakipDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mUSTERIBindingSource;
        private Stok_TakipDataSet stok_TakipDataSet;
        private Stok_TakipDataSetTableAdapters.MUSTERITableAdapter mUSTERITableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrdMusteri;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txt_FIRMATEL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SORUMLUTEL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SORUMLUADSOYAD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ADRES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_VKN_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UNVAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNVANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vKNTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORUMLUADSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORUMLUTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRMATELDataGridViewTextBoxColumn;
    }
}
