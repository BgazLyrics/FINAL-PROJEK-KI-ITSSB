namespace kasir_kantin
{
    partial class FormTransaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMenuu = new System.Windows.Forms.ComboBox();
            this.lblHargaa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numJumlahh = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTambahh = new System.Windows.Forms.Button();
            this.dgvKeranjangg = new System.Windows.Forms.DataGridView();
            this.lblTotall = new System.Windows.Forms.Label();
            this.btnBayarr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjangg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Form Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga";
            // 
            // cbMenuu
            // 
            this.cbMenuu.FormattingEnabled = true;
            this.cbMenuu.Location = new System.Drawing.Point(18, 120);
            this.cbMenuu.Name = "cbMenuu";
            this.cbMenuu.Size = new System.Drawing.Size(193, 24);
            this.cbMenuu.TabIndex = 11;
            this.cbMenuu.SelectedIndexChanged += new System.EventHandler(this.cbMenuu_SelectedIndexChanged);
            // 
            // lblHargaa
            // 
            this.lblHargaa.AutoSize = true;
            this.lblHargaa.Location = new System.Drawing.Point(240, 128);
            this.lblHargaa.Name = "lblHargaa";
            this.lblHargaa.Size = new System.Drawing.Size(38, 16);
            this.lblHargaa.TabIndex = 12;
            this.lblHargaa.Text = "Rp. 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "X";
            // 
            // numJumlahh
            // 
            this.numJumlahh.Location = new System.Drawing.Point(379, 121);
            this.numJumlahh.Name = "numJumlahh";
            this.numJumlahh.Size = new System.Drawing.Size(120, 22);
            this.numJumlahh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jumlah";
            // 
            // btnTambahh
            // 
            this.btnTambahh.Location = new System.Drawing.Point(18, 169);
            this.btnTambahh.Name = "btnTambahh";
            this.btnTambahh.Size = new System.Drawing.Size(170, 23);
            this.btnTambahh.TabIndex = 16;
            this.btnTambahh.Text = "Tambah ke keranjang";
            this.btnTambahh.UseVisualStyleBackColor = true;
            this.btnTambahh.Click += new System.EventHandler(this.btnTambahh_Click);
            // 
            // dgvKeranjangg
            // 
            this.dgvKeranjangg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjangg.Location = new System.Drawing.Point(12, 213);
            this.dgvKeranjangg.Name = "dgvKeranjangg";
            this.dgvKeranjangg.RowHeadersWidth = 51;
            this.dgvKeranjangg.RowTemplate.Height = 24;
            this.dgvKeranjangg.Size = new System.Drawing.Size(776, 309);
            this.dgvKeranjangg.TabIndex = 17;
            // 
            // lblTotall
            // 
            this.lblTotall.AutoSize = true;
            this.lblTotall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotall.Location = new System.Drawing.Point(15, 542);
            this.lblTotall.Name = "lblTotall";
            this.lblTotall.Size = new System.Drawing.Size(43, 16);
            this.lblTotall.TabIndex = 18;
            this.lblTotall.Text = "Total";
            // 
            // btnBayarr
            // 
            this.btnBayarr.Location = new System.Drawing.Point(689, 542);
            this.btnBayarr.Name = "btnBayarr";
            this.btnBayarr.Size = new System.Drawing.Size(75, 23);
            this.btnBayarr.TabIndex = 19;
            this.btnBayarr.Text = "Simpan";
            this.btnBayarr.UseVisualStyleBackColor = true;
            this.btnBayarr.Click += new System.EventHandler(this.btnBayarr_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnBayarr);
            this.Controls.Add(this.lblTotall);
            this.Controls.Add(this.dgvKeranjangg);
            this.Controls.Add(this.btnTambahh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numJumlahh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHargaa);
            this.Controls.Add(this.cbMenuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjangg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMenuu;
        private System.Windows.Forms.Label lblHargaa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numJumlahh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTambahh;
        private System.Windows.Forms.DataGridView dgvKeranjangg;
        private System.Windows.Forms.Label lblTotall;
        private System.Windows.Forms.Button btnBayarr;
    }
}