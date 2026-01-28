namespace kasir_kantin
{
    partial class FormMenu
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
            this.txtNamaa = new System.Windows.Forms.TextBox();
            this.txtHargaa = new System.Windows.Forms.TextBox();
            this.txtStokk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategorii = new System.Windows.Forms.ComboBox();
            this.btnSimpann = new System.Windows.Forms.Button();
            this.btnHapuss = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefreshh = new System.Windows.Forms.Button();
            this.dgvMenuu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelola Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Menu";
            // 
            // txtNamaa
            // 
            this.txtNamaa.Location = new System.Drawing.Point(39, 111);
            this.txtNamaa.Name = "txtNamaa";
            this.txtNamaa.Size = new System.Drawing.Size(264, 22);
            this.txtNamaa.TabIndex = 3;
            // 
            // txtHargaa
            // 
            this.txtHargaa.Location = new System.Drawing.Point(39, 209);
            this.txtHargaa.Name = "txtHargaa";
            this.txtHargaa.Size = new System.Drawing.Size(264, 22);
            this.txtHargaa.TabIndex = 4;
            // 
            // txtStokk
            // 
            this.txtStokk.Location = new System.Drawing.Point(333, 111);
            this.txtStokk.Name = "txtStokk";
            this.txtStokk.Size = new System.Drawing.Size(234, 22);
            this.txtStokk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok";
            // 
            // cbKategorii
            // 
            this.cbKategorii.FormattingEnabled = true;
            this.cbKategorii.Location = new System.Drawing.Point(333, 209);
            this.cbKategorii.Name = "cbKategorii";
            this.cbKategorii.Size = new System.Drawing.Size(234, 24);
            this.cbKategorii.TabIndex = 10;
            // 
            // btnSimpann
            // 
            this.btnSimpann.Location = new System.Drawing.Point(41, 336);
            this.btnSimpann.Name = "btnSimpann";
            this.btnSimpann.Size = new System.Drawing.Size(75, 23);
            this.btnSimpann.TabIndex = 11;
            this.btnSimpann.Text = "Simpan";
            this.btnSimpann.UseVisualStyleBackColor = true;
            this.btnSimpann.Click += new System.EventHandler(this.btnSimpann_Click);
            // 
            // btnHapuss
            // 
            this.btnHapuss.Location = new System.Drawing.Point(244, 336);
            this.btnHapuss.Name = "btnHapuss";
            this.btnHapuss.Size = new System.Drawing.Size(75, 23);
            this.btnHapuss.TabIndex = 12;
            this.btnHapuss.Text = "Hapus";
            this.btnHapuss.UseVisualStyleBackColor = true;
            this.btnHapuss.Click += new System.EventHandler(this.btnHapuss_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(143, 336);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRefreshh
            // 
            this.btnRefreshh.Location = new System.Drawing.Point(783, 335);
            this.btnRefreshh.Name = "btnRefreshh";
            this.btnRefreshh.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshh.TabIndex = 14;
            this.btnRefreshh.Text = "Refresh";
            this.btnRefreshh.UseVisualStyleBackColor = true;
            this.btnRefreshh.Click += new System.EventHandler(this.btnRefreshh_Click);
            // 
            // dgvMenuu
            // 
            this.dgvMenuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuu.Location = new System.Drawing.Point(38, 392);
            this.dgvMenuu.Name = "dgvMenuu";
            this.dgvMenuu.RowHeadersWidth = 51;
            this.dgvMenuu.RowTemplate.Height = 24;
            this.dgvMenuu.Size = new System.Drawing.Size(841, 351);
            this.dgvMenuu.TabIndex = 15;
            this.dgvMenuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuu_CellClick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 767);
            this.Controls.Add(this.dgvMenuu);
            this.Controls.Add(this.btnRefreshh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapuss);
            this.Controls.Add(this.btnSimpann);
            this.Controls.Add(this.cbKategorii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStokk);
            this.Controls.Add(this.txtHargaa);
            this.Controls.Add(this.txtNamaa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaa;
        private System.Windows.Forms.TextBox txtHargaa;
        private System.Windows.Forms.TextBox txtStokk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKategorii;
        private System.Windows.Forms.Button btnSimpann;
        private System.Windows.Forms.Button btnHapuss;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefreshh;
        private System.Windows.Forms.DataGridView dgvMenuu;
    }
}