namespace kasir_kantin
{
    partial class FormKategori
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvKategori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Kategori Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kategori";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(41, 125);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 22);
            this.txtNama.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(264, 125);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(41, 415);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(173, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus Kategori";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(667, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // dgvKategori
            // 
            this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategori.Location = new System.Drawing.Point(41, 165);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.RowHeadersWidth = 51;
            this.dgvKategori.RowTemplate.Height = 24;
            this.dgvKategori.Size = new System.Drawing.Size(711, 235);
            this.dgvKategori.TabIndex = 6;
            this.dgvKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategori_CellContentClick);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKategori);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKategori";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvKategori;
    }
}

