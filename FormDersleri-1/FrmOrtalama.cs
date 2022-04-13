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
    public partial class FrmOrtalama : Form
    {
        public FrmOrtalama()
        {
            InitializeComponent();
        }


        public double ortalamahesapla(double not1,double not2)

        {
            double sonuc = (not1 + not2) / 2;

            return sonuc;

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double yazili1 = Convert.ToDouble(txt_yaz1.Text);
            double yazili2 = Convert.ToDouble(txt_yaz2.Text);

            double ortalama = ortalamahesapla(yazili1, yazili2);
            lbl_ortalama.Text = "ORTALAMA :" + ortalama.ToString();
        }
    }
}
