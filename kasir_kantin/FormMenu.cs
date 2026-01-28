using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Wajib ada
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_kantin 
{
    public partial class FormMenu : Form
    {
        private string idMenu = "";

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            IsiComboKategori(); 
            TampilData();       
            Bersihkan();        
        }

        void TampilData()
        {
            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT Menu.Id, Menu.NamaMenu, Menu.Harga, Menu.Stok, Kategori.NamaKategori, Menu.KategoriId " +
                               "FROM Menu JOIN Kategori ON Menu.KategoriId = Kategori.Id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMenuu.DataSource = dt;

                if (dgvMenuu.Columns["Id"] != null) dgvMenuu.Columns["Id"].Visible = false;
                if (dgvMenuu.Columns["KategoriId"] != null) dgvMenuu.Columns["KategoriId"].Visible = false;

                if (dgvMenuu.Columns["Harga"] != null) dgvMenuu.Columns["Harga"].DefaultCellStyle.Format = "N0";

                if (dgvMenuu.Columns["NamaMenu"] != null) dgvMenuu.Columns["NamaMenu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Tampil Data: " + ex.Message);
            }
        }

        void IsiComboKategori()
        {
            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, NamaKategori FROM Kategori", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbKategorii.DataSource = dt;
                cbKategorii.DisplayMember = "NamaKategori";
                cbKategorii.ValueMember = "Id";
                cbKategorii.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Load Kategori: " + ex.Message);
            }
        }

        void Bersihkan()
        {
            txtNamaa.Text = "";
            txtHargaa.Text = "";
            txtStokk.Text = "";
            cbKategorii.SelectedIndex = -1;
            idMenu = "";

            btnSimpann.Text = "Simpan";
            btnHapuss.Enabled = false;
        }
        private void dgvMenuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenuu.Rows[e.RowIndex];

                idMenu = row.Cells["Id"].Value.ToString();
                txtNamaa.Text = row.Cells["NamaMenu"].Value.ToString();
                txtHargaa.Text = row.Cells["Harga"].Value.ToString();
                txtStokk.Text = row.Cells["Stok"].Value.ToString();

                cbKategorii.SelectedValue = row.Cells["KategoriId"].Value;

                btnSimpann.Text = "Update";
                btnHapuss.Enabled = true;
            }
        }

        private void btnSimpann_Click(object sender, EventArgs e)
        {
            if (txtNamaa.Text == "" || txtHargaa.Text == "" || cbKategorii.SelectedValue == null)
            {
                MessageBox.Show("Data tidak boleh kosong!");
                return;
            }

            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd;

                if (idMenu == "") 
                {
                    cmd = new SqlCommand("INSERT INTO Menu (NamaMenu, Harga, Stok, KategoriId) VALUES (@nama, @harga, @stok, @katId)", conn);
                }
                else 
                {
                    cmd = new SqlCommand("UPDATE Menu SET NamaMenu=@nama, Harga=@harga, Stok=@stok, KategoriId=@katId WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", idMenu);
                }

                cmd.Parameters.AddWithValue("@nama", txtNamaa.Text);
                cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtHargaa.Text));
                cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStokk.Text));
                cmd.Parameters.AddWithValue("@katId", cbKategorii.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukses Simpan Data!");
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Simpan: " + ex.Message);
            }
        }
        private void btnHapuss_Click(object sender, EventArgs e)
        {
            if (idMenu == "")
            {
                MessageBox.Show("Pilih dulu data di tabel yang mau dihapus!");
                return;
            }

            if (MessageBox.Show("Yakin hapus menu ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = Koneksi.GetKoneksi();
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", idMenu);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Terhapus!");
                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Hapus: " + ex.Message);
                }
            }
        }
        private void btnRefreshh_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }
    }
}