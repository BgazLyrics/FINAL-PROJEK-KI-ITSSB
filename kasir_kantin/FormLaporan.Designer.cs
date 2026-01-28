namespace kasir_kantin
{
    partial class FormLaporan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.chartLaporan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCek = new System.Windows.Forms.Button();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Form Laporan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jenis Laporan";
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(29, 183);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 51;
            this.dgvLaporan.RowTemplate.Height = 24;
            this.dgvLaporan.Size = new System.Drawing.Size(574, 375);
            this.dgvLaporan.TabIndex = 18;
            // 
            // chartLaporan
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLaporan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLaporan.Legends.Add(legend1);
            this.chartLaporan.Location = new System.Drawing.Point(630, 183);
            this.chartLaporan.Name = "chartLaporan";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLaporan.Series.Add(series1);
            this.chartLaporan.Size = new System.Drawing.Size(459, 375);
            this.chartLaporan.TabIndex = 19;
            this.chartLaporan.Text = "chart1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 586);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 25);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total Penjualan";
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(540, 127);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(91, 23);
            this.btnCek.TabIndex = 22;
            this.btnCek.Text = "Tampilkan";
            this.btnCek.UseVisualStyleBackColor = true;
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(285, 127);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(200, 22);
            this.dtTanggal.TabIndex = 23;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(29, 125);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(204, 24);
            this.cbFilter.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tanggal";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chartLaporan);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.Load += new System.EventHandler(this.FormLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLaporan;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
    }
}