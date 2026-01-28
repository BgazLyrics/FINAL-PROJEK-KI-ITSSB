namespace kasir_kantin
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "KANTIN SMECONE";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(92, 198);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(106, 99);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Master Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hallo, apa yang mau dilakukan hari ini?";
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(241, 198);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(106, 99);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Master Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click_1);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(387, 198);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(106, 99);
            this.btnTransaksi.TabIndex = 7;
            this.btnTransaksi.Text = "Transaksi Penjualan";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(544, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 99);
            this.button4.TabIndex = 8;
            this.button4.Text = "Laporan Penjualan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(31, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Keluar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
    }
}