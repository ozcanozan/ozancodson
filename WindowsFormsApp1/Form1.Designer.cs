namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUretimDepo = new System.Windows.Forms.Button();
            this.btnUrunMalzemeİşlemleri = new System.Windows.Forms.Button();
            this.btnMalzemeIslemleri = new System.Windows.Forms.Button();
            this.btnAraDepo = new System.Windows.Forms.Button();
            this.btnÜrünİşlemleri = new System.Windows.Forms.Button();
            this.btnMüşteriİşlemleri = new System.Windows.Forms.Button();
            this.btnSiparişKontrol = new System.Windows.Forms.Button();
            this.btnMüşteriSipariş = new System.Windows.Forms.Button();
            this.btnKategoriİşlemleri = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnUretimDepo);
            this.panel2.Controls.Add(this.btnUrunMalzemeİşlemleri);
            this.panel2.Controls.Add(this.btnMalzemeIslemleri);
            this.panel2.Controls.Add(this.btnAraDepo);
            this.panel2.Controls.Add(this.btnÜrünİşlemleri);
            this.panel2.Controls.Add(this.btnMüşteriİşlemleri);
            this.panel2.Controls.Add(this.btnSiparişKontrol);
            this.panel2.Controls.Add(this.btnMüşteriSipariş);
            this.panel2.Controls.Add(this.btnKategoriİşlemleri);
            this.panel2.Location = new System.Drawing.Point(39, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 913);
            this.panel2.TabIndex = 1;
            // 
            // btnUretimDepo
            // 
            this.btnUretimDepo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUretimDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUretimDepo.Location = new System.Drawing.Point(41, 473);
            this.btnUretimDepo.Name = "btnUretimDepo";
            this.btnUretimDepo.Size = new System.Drawing.Size(201, 50);
            this.btnUretimDepo.TabIndex = 10;
            this.btnUretimDepo.Text = "Üretim Depo";
            this.btnUretimDepo.UseVisualStyleBackColor = false;
            // 
            // btnUrunMalzemeİşlemleri
            // 
            this.btnUrunMalzemeİşlemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUrunMalzemeİşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunMalzemeİşlemleri.Location = new System.Drawing.Point(41, 315);
            this.btnUrunMalzemeİşlemleri.Name = "btnUrunMalzemeİşlemleri";
            this.btnUrunMalzemeİşlemleri.Size = new System.Drawing.Size(201, 50);
            this.btnUrunMalzemeİşlemleri.TabIndex = 6;
            this.btnUrunMalzemeİşlemleri.Text = "Ürün Malzeme/Reçeteler";
            this.btnUrunMalzemeİşlemleri.UseVisualStyleBackColor = false;
            this.btnUrunMalzemeİşlemleri.Click += new System.EventHandler(this.btnUrunMalzemeIslemleri_Click);
            // 
            // btnMalzemeIslemleri
            // 
            this.btnMalzemeIslemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMalzemeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeIslemleri.Location = new System.Drawing.Point(41, 81);
            this.btnMalzemeIslemleri.Name = "btnMalzemeIslemleri";
            this.btnMalzemeIslemleri.Size = new System.Drawing.Size(201, 50);
            this.btnMalzemeIslemleri.TabIndex = 9;
            this.btnMalzemeIslemleri.Text = "Malzeme İşlemleri/Hammadde Deposu";
            this.btnMalzemeIslemleri.UseVisualStyleBackColor = false;
            this.btnMalzemeIslemleri.Click += new System.EventHandler(this.btnMalzemeIslemleri_Click);
            // 
            // btnAraDepo
            // 
            this.btnAraDepo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAraDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAraDepo.Location = new System.Drawing.Point(41, 397);
            this.btnAraDepo.Name = "btnAraDepo";
            this.btnAraDepo.Size = new System.Drawing.Size(201, 50);
            this.btnAraDepo.TabIndex = 8;
            this.btnAraDepo.Text = "Ara Depo İşlemleri / Üretim Pasta Talep";
            this.btnAraDepo.UseVisualStyleBackColor = false;
            this.btnAraDepo.Click += new System.EventHandler(this.btnAraDepo_Click);
            // 
            // btnÜrünİşlemleri
            // 
            this.btnÜrünİşlemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnÜrünİşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÜrünİşlemleri.Location = new System.Drawing.Point(41, 237);
            this.btnÜrünİşlemleri.Name = "btnÜrünİşlemleri";
            this.btnÜrünİşlemleri.Size = new System.Drawing.Size(201, 50);
            this.btnÜrünİşlemleri.TabIndex = 7;
            this.btnÜrünİşlemleri.Text = "Ürün İsimleri";
            this.btnÜrünİşlemleri.UseVisualStyleBackColor = false;
            this.btnÜrünİşlemleri.Click += new System.EventHandler(this.btnÜrünİşlemleri_Click);
            // 
            // btnMüşteriİşlemleri
            // 
            this.btnMüşteriİşlemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMüşteriİşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMüşteriİşlemleri.Location = new System.Drawing.Point(41, 549);
            this.btnMüşteriİşlemleri.Name = "btnMüşteriİşlemleri";
            this.btnMüşteriİşlemleri.Size = new System.Drawing.Size(201, 50);
            this.btnMüşteriİşlemleri.TabIndex = 5;
            this.btnMüşteriİşlemleri.Text = "Müşteri İşlemleri";
            this.btnMüşteriİşlemleri.UseVisualStyleBackColor = false;
            this.btnMüşteriİşlemleri.Click += new System.EventHandler(this.btnMüşteriİşlemleri_Click);
            // 
            // btnSiparişKontrol
            // 
            this.btnSiparişKontrol.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSiparişKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparişKontrol.Location = new System.Drawing.Point(41, 713);
            this.btnSiparişKontrol.Name = "btnSiparişKontrol";
            this.btnSiparişKontrol.Size = new System.Drawing.Size(201, 50);
            this.btnSiparişKontrol.TabIndex = 2;
            this.btnSiparişKontrol.Text = "Sipariş Kontrol/Ana Depo";
            this.btnSiparişKontrol.UseVisualStyleBackColor = false;
            this.btnSiparişKontrol.Click += new System.EventHandler(this.btnSiparişKontrol_Click);
            // 
            // btnMüşteriSipariş
            // 
            this.btnMüşteriSipariş.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMüşteriSipariş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMüşteriSipariş.Location = new System.Drawing.Point(41, 631);
            this.btnMüşteriSipariş.Name = "btnMüşteriSipariş";
            this.btnMüşteriSipariş.Size = new System.Drawing.Size(201, 50);
            this.btnMüşteriSipariş.TabIndex = 1;
            this.btnMüşteriSipariş.Text = "Müşteri Sipariş";
            this.btnMüşteriSipariş.UseVisualStyleBackColor = false;
            this.btnMüşteriSipariş.Click += new System.EventHandler(this.btnMüşteriSipariş_Click);
            // 
            // btnKategoriİşlemleri
            // 
            this.btnKategoriİşlemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKategoriİşlemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriİşlemleri.Location = new System.Drawing.Point(41, 159);
            this.btnKategoriİşlemleri.Name = "btnKategoriİşlemleri";
            this.btnKategoriİşlemleri.Size = new System.Drawing.Size(201, 50);
            this.btnKategoriİşlemleri.TabIndex = 0;
            this.btnKategoriİşlemleri.Text = "Ürün Kategorileri";
            this.btnKategoriİşlemleri.UseVisualStyleBackColor = false;
            this.btnKategoriİşlemleri.Click += new System.EventHandler(this.btnKategoriİşlemleri_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Location = new System.Drawing.Point(345, 27);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1441, 1022);
            this.pnlRight.TabIndex = 2;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRight_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1833, 1061);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnÜrünİşlemleri;
        private System.Windows.Forms.Button btnUrunMalzemeİşlemleri;
        private System.Windows.Forms.Button btnMüşteriİşlemleri;
        private System.Windows.Forms.Button btnSiparişKontrol;
        private System.Windows.Forms.Button btnMüşteriSipariş;
        private System.Windows.Forms.Button btnKategoriİşlemleri;
        private System.Windows.Forms.Button btnAraDepo;
        private System.Windows.Forms.Button btnMalzemeIslemleri;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnUretimDepo;
    }
}

