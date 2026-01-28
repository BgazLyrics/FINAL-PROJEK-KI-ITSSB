using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace kasir_kantin 
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            IsiComboMenu();
            SiapkanTabelKeranjang();
            lblHargaa.Text = "0";
            lblTotall.Text = "Total: Rp 0";
        }
        void SiapkanTabelKeranjang()
        {
            dgvKeranjangg.AllowUserToAddRows = false;

            dgvKeranjangg.Columns.Add("IdMenu", "ID Menu");
            dgvKeranjangg.Columns.Add("NamaMenu", "Nama Item");
            dgvKeranjangg.Columns.Add("Harga", "Harga");
            dgvKeranjangg.Columns.Add("Jumlah", "Qty");
            dgvKeranjangg.Columns.Add("Subtotal", "Subtotal");

            dgvKeranjangg.Columns["IdMenu"].Visible = false;
            dgvKeranjangg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void IsiComboMenu()
        {
            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, NamaMenu FROM Menu WHERE Stok > 0", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMenuu.DataSource = dt;
                cbMenuu.DisplayMember = "NamaMenu";
                cbMenuu.ValueMember = "Id";
                cbMenuu.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Gagal load menu: " + ex.Message); }
        }

        void HitungTotalBayar()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvKeranjangg.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lblTotall.Text = "Total: Rp " + total.ToString("N0");
            lblTotall.Tag = total; 
        }

        private void btnBayarr_Click(object sender, EventArgs e)
        {
            if (dgvKeranjangg.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlInduk = "INSERT INTO Transaksi (TotalHarga) VALUES (@total); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdInduk = new SqlCommand(sqlInduk, conn);

                decimal totalAkhir = Convert.ToDecimal(lblTotall.Tag);
                cmdInduk.Parameters.AddWithValue("@total", totalAkhir);

                int idTransaksiBaru = Convert.ToInt32(cmdInduk.ExecuteScalar());

                foreach (DataGridViewRow row in dgvKeranjangg.Rows)
                {
                    string sqlDetail = "INSERT INTO DetailTransaksi (TransaksiId, MenuId, Jumlah, HargaSaatItu, Subtotal) " +
                                       "VALUES (@transId, @menuId, @qty, @harga, @sub)";

                    SqlCommand cmdDetail = new SqlCommand(sqlDetail, conn);
                    cmdDetail.Parameters.AddWithValue("@transId", idTransaksiBaru);
                    cmdDetail.Parameters.AddWithValue("@menuId", row.Cells["IdMenu"].Value);
                    cmdDetail.Parameters.AddWithValue("@qty", row.Cells["Jumlah"].Value);
                    cmdDetail.Parameters.AddWithValue("@harga", row.Cells["Harga"].Value);
                    cmdDetail.Parameters.AddWithValue("@sub", row.Cells["Subtotal"].Value);
                    cmdDetail.ExecuteNonQuery();

                    string sqlStok = "UPDATE Menu SET Stok = Stok - @qty WHERE Id = @menuId";
                    SqlCommand cmdStok = new SqlCommand(sqlStok, conn);
                    cmdStok.Parameters.AddWithValue("@qty", row.Cells["Jumlah"].Value);
                    cmdStok.Parameters.AddWithValue("@menuId", row.Cells["IdMenu"].Value);
                    cmdStok.ExecuteNonQuery();
                }

                MessageBox.Show("Transaksi Berhasil Disimpan!");

                dgvKeranjangg.Rows.Clear();
                lblTotall.Text = "Total: Rp 0";
                numJumlahh.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Transaksi: " + ex.Message);
            }
            if (dgvKeranjangg.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlInduk = "INSERT INTO Transaksi (TotalHarga) VALUES (@total); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdInduk = new SqlCommand(sqlInduk, conn);

                decimal totalAkhir = Convert.ToDecimal(lblTotall.Tag);
                cmdInduk.Parameters.AddWithValue("@total", totalAkhir);

                int idTransaksiBaru = Convert.ToInt32(cmdInduk.ExecuteScalar());

                foreach (DataGridViewRow row in dgvKeranjangg.Rows)
                {
                    string sqlDetail = "INSERT INTO DetailTransaksi (TransaksiId, MenuId, Jumlah, HargaSaatItu, Subtotal) " +
                                       "VALUES (@transId, @menuId, @qty, @harga, @sub)";

                    SqlCommand cmdDetail = new SqlCommand(sqlDetail, conn);
                    cmdDetail.Parameters.AddWithValue("@transId", idTransaksiBaru);
                    cmdDetail.Parameters.AddWithValue("@menuId", row.Cells["IdMenu"].Value);
                    cmdDetail.Parameters.AddWithValue("@qty", row.Cells["Jumlah"].Value);
                    cmdDetail.Parameters.AddWithValue("@harga", row.Cells["Harga"].Value);
                    cmdDetail.Parameters.AddWithValue("@sub", row.Cells["Subtotal"].Value);
                    cmdDetail.ExecuteNonQuery();

                    string sqlStok = "UPDATE Menu SET Stok = Stok - @qty WHERE Id = @menuId";
                    SqlCommand cmdStok = new SqlCommand(sqlStok, conn);
                    cmdStok.Parameters.AddWithValue("@qty", row.Cells["Jumlah"].Value);
                    cmdStok.Parameters.AddWithValue("@menuId", row.Cells["IdMenu"].Value);
                    cmdStok.ExecuteNonQuery();
                }

                MessageBox.Show("Transaksi Berhasil Disimpan!");

                dgvKeranjangg.Rows.Clear();
                lblTotall.Text = "Total: Rp 0";
                numJumlahh.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Transaksi: " + ex.Message);
            }
        }

        private void btnTambahh_Click(object sender, EventArgs e)
        {
            if (cbMenuu.SelectedIndex == -1 || numJumlahh.Value <= 0)
            {
                MessageBox.Show("Pilih menu dan jumlah dulu!");
                return;
            }

            string idMenu = cbMenuu.SelectedValue.ToString();
            string namaMenu = cbMenuu.Text;
            decimal harga = Convert.ToDecimal(lblHargaa.Text); 
            int jumlah = (int)numJumlahh.Value;
            decimal subtotal = harga * jumlah;

            dgvKeranjangg.Rows.Add(idMenu, namaMenu, harga, jumlah, subtotal);

            HitungTotalBayar();
        }

        private void cbMenuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenuu.SelectedIndex != -1 && cbMenuu.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    SqlConnection conn = Koneksi.GetKoneksi();
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string id = cbMenuu.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT Harga FROM Menu WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    object hasil = cmd.ExecuteScalar();
                    if (hasil != null)
                    {
                        decimal harga = Convert.ToDecimal(hasil);
                        lblHargaa.Text = harga.ToString("N0");
                    }
                }
                catch { } 
            }
        }
    }
}