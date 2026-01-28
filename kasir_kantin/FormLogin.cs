using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace kasir_kantin 
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Username dan Password wajib diisi!");
                return;
            }

            try
            {
                SqlConnection conn = Koneksi.GetKoneksi();
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT COUNT(*) FROM Kasir WHERE Username=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                int hasil = Convert.ToInt32(cmd.ExecuteScalar());

                if (hasil > 0)
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang.");

                    this.Hide();

                    FormMain main = new FormMain();
                    main.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                    txtPass.Text = ""; 
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}