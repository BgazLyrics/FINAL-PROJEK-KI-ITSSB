using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace kasir_kantin 
{
    class Koneksi
    {
        // 1. Siapkan variabel koneksi
        public static SqlConnection conn;

        // 2. Method untuk ambil koneksi
        public static SqlConnection GetKoneksi()
        {
            try
            {
                // Setting Connection String
                // Data Source = Nama Server SQL kamu (Cek di SSMS pas login awal, biasanya "LOCALHOST" atau "LAPTOP-XXXX\SQLEXPRESS")
                // Initial Catalog = Nama Database
                // Integrated Security = True (Artinya pakai login Windows, gak perlu user/pass)

                string strKoneksi = "Data Source=BILGAS\\SQLEXPRESS;Initial Catalog=db_kantin;Integrated Security=True";

                conn = new SqlConnection(strKoneksi);

                // Cek kalau koneksi tertutup, kita buka
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Koneksi: " + ex.Message);
            }
            return conn;
        }
    }
}