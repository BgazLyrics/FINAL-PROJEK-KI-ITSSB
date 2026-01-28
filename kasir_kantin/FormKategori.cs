using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_kantin 
{
    public partial class FormKategori : Form
    {
        private string idKategori = "";

        public FormKategori()
        {
            InitializeComponent();
        }

        void TampilData()
        {
            SqlConnection conn = Koneksi.GetKoneksi();
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kategori", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKategori.DataSource = dt;

            if (dgvKategori.Columns["Id"] != null)
            {
                dgvKategori.Columns["Id"].HeaderText = "ID";
                dgvKategori.Columns["Id"].Width = 50; 
                dgvKategori.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            }

            if (dgvKategori.Columns["NamaKategori"] != null)
            {
                dgvKategori.Columns["NamaKategori"].HeaderText = "Nama Kategori";
                dgvKategori.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvKategori.RowHeadersVisible = false;
        }

        void Bersihkan()
        {
            txtNama.Text = "";
            idKategori = ""; 
            btnSimpan.Text = "Simpan"; 
            btnHapus.Enabled = false; 
        }
        private void FormKategori_Load(object sender, EventArgs e)
        {
            TampilData();
            Bersihkan();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            
            if (txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = Koneksi.GetKoneksi();
            SqlCommand cmd;

            try
            {
                if (idKategori == "")
                {
                    cmd = new SqlCommand("INSERT INTO Kategori (NamaKategori) VALUES (@nama)", conn);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Kategori SET NamaKategori = @nama WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", idKategori);
                }

                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan!");
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Simpan: " + ex.Message);
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau hapus kategori ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = Koneksi.GetKoneksi();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Kategori WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", idKategori);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus!");
                    TampilData();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal Hapus: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKategori.Rows[e.RowIndex];

                idKategori = row.Cells["Id"].Value.ToString();
                txtNama.Text = row.Cells["NamaKategori"].Value.ToString();

                btnSimpan.Text = "Update";
                btnHapus.Enabled = true;
            }
        }
    }
}