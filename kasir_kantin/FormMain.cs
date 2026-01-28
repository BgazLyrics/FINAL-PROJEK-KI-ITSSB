using System;
using System.Windows.Forms;

namespace kasir_kantin 
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu frm = new FormMenu();
            frm.ShowDialog();
        }

        private void btnKategori_Click_1(object sender, EventArgs e)
        {
            FormKategori frm = new FormKategori();
            frm.ShowDialog(); 

        }

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            FormTransaksi frm = new FormTransaksi();
            frm.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTransaksi frm = new FormTransaksi();
            frm.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}