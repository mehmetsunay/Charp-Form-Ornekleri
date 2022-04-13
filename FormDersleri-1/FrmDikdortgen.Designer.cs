
namespace FormDersleri_1
{
    partial class FrmDikdortgen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kisa = new System.Windows.Forms.Label();
            this.lbl_uzun = new System.Windows.Forms.Label();
            this.txt_kisa = new System.Windows.Forms.TextBox();
            this.txt_uzun = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.gbox_islem = new System.Windows.Forms.GroupBox();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kisa
            // 
            this.lbl_kisa.AutoSize = true;
            this.lbl_kisa.Location = new System.Drawing.Point(19, 57);
            this.lbl_kisa.Name = "lbl_kisa";
            this.lbl_kisa.Size = new System.Drawing.Size(91, 20);
            this.lbl_kisa.TabIndex = 0;
            this.lbl_kisa.Text = "KISA KENAR";
            // 
            // lbl_uzun
            // 
            this.lbl_uzun.AutoSize = true;
            this.lbl_uzun.Location = new System.Drawing.Point(19, 106);
            this.lbl_uzun.Name = "lbl_uzun";
            this.lbl_uzun.Size = new System.Drawing.Size(100, 20);
            this.lbl_uzun.TabIndex = 1;
            this.lbl_uzun.Text = "UZUN KENAR";
            // 
            // txt_kisa
            // 
            this.txt_kisa.Location = new System.Drawing.Point(142, 50);
            this.txt_kisa.Name = "txt_kisa";
            this.txt_kisa.Size = new System.Drawing.Size(125, 27);
            this.txt_kisa.TabIndex = 2;
            // 
            // txt_uzun
            // 
            this.txt_uzun.Location = new System.Drawing.Point(142, 103);
            this.txt_uzun.Name = "txt_uzun";
            this.txt_uzun.Size = new System.Drawing.Size(125, 27);
            this.txt_uzun.TabIndex = 3;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(142, 159);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(125, 29);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(19, 209);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(65, 20);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "SONUÇ :";
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Location = new System.Drawing.Point(338, 64);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(68, 24);
            this.rbAlan.TabIndex = 6;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "ALAN";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Location = new System.Drawing.Point(338, 136);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(73, 24);
            this.rbCevre.TabIndex = 7;
            this.rbCevre.TabStop = true;
            this.rbCevre.Text = "ÇEVRE";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // gbox_islem
            // 
            this.gbox_islem.Controls.Add(this.rbCevre);
            this.gbox_islem.Controls.Add(this.txt_uzun);
            this.gbox_islem.Controls.Add(this.rbAlan);
            this.gbox_islem.Controls.Add(this.lbl_uzun);
            this.gbox_islem.Controls.Add(this.btn_hesapla);
            this.gbox_islem.Controls.Add(this.lbl_sonuc);
            this.gbox_islem.Controls.Add(this.lbl_kisa);
            this.gbox_islem.Controls.Add(this.txt_kisa);
            this.gbox_islem.Location = new System.Drawing.Point(130, 74);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(523, 275);
            this.gbox_islem.TabIndex = 8;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İŞLEM KAYDI";
            // 
            // FrmDikdortgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_islem);
            this.Name = "FrmDikdortgen";
            this.Text = "FrmDikdortgen";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kisa;
        private System.Windows.Forms.Label lbl_uzun;
        private System.Windows.Forms.TextBox txt_kisa;
        private System.Windows.Forms.TextBox txt_uzun;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.RadioButton rbAlan;
        private System.Windows.Forms.RadioButton rbCevre;
        private System.Windows.Forms.GroupBox gbox_islem;
    }
}