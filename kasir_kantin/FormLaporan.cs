using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace kasir_kantin 
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Clear(); 
            cbFilter.Items.Add("Harian");
            cbFilter.Items.Add("Bulanan");

            cbFilter.SelectedIndex = 0;
            SiapkanTabel();
        }

        void SiapkanTabel()
        {
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        void TampilkanData()
        {
            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (cbFilter.Text == "Harian")
                {
                    query = "SELECT * FROM Transaksi WHERE CAST(TanggalWaktu AS DATE) = @tanggal";
                    cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.Date);
                }
                else if (cbFilter.Text == "Bulanan")
                {
                    query = "SELECT * FROM Transaksi WHERE MONTH(TanggalWaktu) = @bulan AND YEAR(TanggalWaktu) = @tahun";
                    cmd.Parameters.AddWithValue("@bulan", dtTanggal.Value.Month);
                    cmd.Parameters.AddWithValue("@tahun", dtTanggal.Value.Year);
                }

                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLaporan.DataSource = dt;

                HitungTotal(dt);

                IsiChart(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        void HitungTotal(DataTable dt)
        {
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["TotalHarga"]);
            }
            lblTotal.Text = "Total Pendapatan: Rp " + total.ToString("N0");
        }

        void IsiChart(DataTable dt)
        {
            if (chartLaporan == null) return;

            chartLaporan.Series.Clear();
            chartLaporan.Titles.Clear();

            Series series = new Series("Omzet");
            series.ChartType = SeriesChartType.Column; 

            foreach (DataRow row in dt.Rows)
            {
                DateTime waktu = Convert.ToDateTime(row["TanggalWaktu"]);
                decimal nilai = Convert.ToDecimal(row["TotalHarga"]);

                series.Points.AddXY(waktu.ToString("dd/MM HH:mm"), nilai);
            }

            chartLaporan.Series.Add(series);
            chartLaporan.Titles.Add("Grafik Penjualan");
        }
    }
}