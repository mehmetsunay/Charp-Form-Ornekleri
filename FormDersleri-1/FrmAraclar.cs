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
    public partial class FrmAraclar : Form
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_secim.Text = "SEÇİMİNİZ :" + comboBox1.SelectedItem;
        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
