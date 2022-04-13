
namespace FormDersleri_1
{
    partial class Frmislem
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
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.gbox_islem = new System.Windows.Forms.GroupBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_sonuc = new System.Windows.Forms.TextBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.AutoSize = true;
            this.lbl_sayi1.Location = new System.Drawing.Point(36, 52);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(50, 20);
            this.lbl_sayi1.TabIndex = 0;
            this.lbl_sayi1.Text = "SAYI 1";
            // 
            // gbox_islem
            // 
            this.gbox_islem.Controls.Add(this.btn_hesapla);
            this.gbox_islem.Controls.Add(this.txt_sonuc);
            this.gbox_islem.Controls.Add(this.lbl_sonuc);
            this.gbox_islem.Controls.Add(this.txt_sayi2);
            this.gbox_islem.Controls.Add(this.txt_sayi1);
            this.gbox_islem.Controls.Add(this.lbl_sayi2);
            this.gbox_islem.Controls.Add(this.lbl_sayi1);
            this.gbox_islem.Location = new System.Drawing.Point(191, 74);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(475, 278);
            this.gbox_islem.TabIndex = 1;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İŞLEM KAYDI";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(171, 211);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(94, 29);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_sonuc
            // 
            this.txt_sonuc.Location = new System.Drawing.Point(137, 153);
            this.txt_sonuc.Name = "txt_sonuc";
            this.txt_sonuc.Size = new System.Drawing.Size(164, 27);
            this.txt_sonuc.TabIndex = 5;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(36, 160);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(65, 20);
            this.lbl_sonuc.TabIndex = 4;
            this.lbl_sonuc.Text = "SONUÇ :";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(137, 102);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(164, 27);
            this.txt_sayi2.TabIndex = 3;
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(137, 52);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(164, 27);
            this.txt_sayi1.TabIndex = 2;
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.AutoSize = true;
            this.lbl_sayi2.Location = new System.Drawing.Point(36, 102);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(50, 20);
            this.lbl_sayi2.TabIndex = 1;
            this.lbl_sayi2.Text = "SAYI 2";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(330, 387);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // Frmislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.gbox_islem);
            this.Name = "Frmislem";
            this.Text = "Frmislem";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayi1;
        private System.Windows.Forms.GroupBox gbox_islem;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_sonuc;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}