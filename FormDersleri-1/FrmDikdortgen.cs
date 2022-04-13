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
    public partial class FrmDikdortgen : Form
    {
        public FrmDikdortgen()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int kis3, uzun, sonuc = 0;

            kis3 =Convert.ToInt32 (txt_kisa.Text);

            uzun =Convert.ToInt32 (txt_uzun.Text);

            if (rbAlan.Checked)

             sonuc = kis3 * uzun; 

            else if (rbCevre.Checked)

             sonuc = 2 * (kis3 + uzun); 

            else

           MessageBox.Show("Lütfen Seçim Yapınız"); 

            lbl_sonuc.Text = "Sonuç " + sonuc;




        }
    }
}
