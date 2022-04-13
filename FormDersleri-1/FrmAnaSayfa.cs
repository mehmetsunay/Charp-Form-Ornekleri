using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersleri_1
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_veri_Click(object sender, EventArgs e)
        {
            FrmVeriAktar va = new FrmVeriAktar();
            va.ShowDialog();
              

        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            Frmislem islem= new Frmislem();
            islem.ShowDialog();
            
        }

        private void btn_dikdortgen_Click(object sender, EventArgs e)
        {
            FrmDikdortgen dikdortgen = new FrmDikdortgen();
            dikdortgen.ShowDialog();
            
        }
    }
}
