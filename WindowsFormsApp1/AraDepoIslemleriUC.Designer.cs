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
            this.aLISFIYATIDataGridViewTextBoxColumn.Visible = false;
            // 
            // sATISFIYATIDataGridViewTextBoxColumn
            // 
            this.sATISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.HeaderText = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.sATISFIYATIDataGridViewTextBoxColumn.Name = "sATISFIYATIDataGridViewTextBoxColumn";
            this.sATISFIYATIDataGridViewTextBoxColumn.Visible = false;
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
