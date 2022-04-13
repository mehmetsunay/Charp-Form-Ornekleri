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
    public partial class Frmislem : Form
    {
        public Frmislem()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_sayi2.Text);

            txt_sonuc.Text = (sayi1 * sayi2).ToString();
        }
    }
}
