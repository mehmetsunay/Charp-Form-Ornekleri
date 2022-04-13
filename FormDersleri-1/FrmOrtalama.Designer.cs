
namespace FormDersleri_1
{
    partial class FrmOrtalama
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
            this.lbl_yaz1 = new System.Windows.Forms.Label();
            this.lbl_yaz2 = new System.Windows.Forms.Label();
            this.txt_yaz1 = new System.Windows.Forms.TextBox();
            this.txt_yaz2 = new System.Windows.Forms.TextBox();
            this.gbox_islem = new System.Windows.Forms.GroupBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_ortalama = new System.Windows.Forms.Label();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_yaz1
            // 
            this.lbl_yaz1.AutoSize = true;
            this.lbl_yaz1.Location = new System.Drawing.Point(24, 74);
            this.lbl_yaz1.Name = "lbl_yaz1";
            this.lbl_yaz1.Size = new System.Drawing.Size(61, 20);
            this.lbl_yaz1.TabIndex = 0;
            this.lbl_yaz1.Text = "1.SINAV";
            // 
            // lbl_yaz2
            // 
            this.lbl_yaz2.AutoSize = true;
            this.lbl_yaz2.Location = new System.Drawing.Point(24, 125);
            this.lbl_yaz2.Name = "lbl_yaz2";
            this.lbl_yaz2.Size = new System.Drawing.Size(61, 20);
            this.lbl_yaz2.TabIndex = 1;
            this.lbl_yaz2.Text = "2.SINAV";
            // 
            // txt_yaz1
            // 
            this.txt_yaz1.Location = new System.Drawing.Point(142, 74);
            this.txt_yaz1.Name = "txt_yaz1";
            this.txt_yaz1.Size = new System.Drawing.Size(125, 27);
            this.txt_yaz1.TabIndex = 2;
            // 
            // txt_yaz2
            // 
            this.txt_yaz2.Location = new System.Drawing.Point(142, 125);
            this.txt_yaz2.Name = "txt_yaz2";
            this.txt_yaz2.Size = new System.Drawing.Size(125, 27);
            this.txt_yaz2.TabIndex = 3;
            // 
            // gbox_islem
            // 
            this.gbox_islem.Controls.Add(this.lbl_ortalama);
            this.gbox_islem.Controls.Add(this.btn_hesapla);
            this.gbox_islem.Controls.Add(this.lbl_yaz1);
            this.gbox_islem.Controls.Add(this.txt_yaz2);
            this.gbox_islem.Controls.Add(this.lbl_yaz2);
            this.gbox_islem.Controls.Add(this.txt_yaz1);
            this.gbox_islem.Location = new System.Drawing.Point(79, 27);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(339, 302);
            this.gbox_islem.TabIndex = 4;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İŞLEM KAYDI";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(142, 177);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(125, 29);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_ortalama
            // 
            this.lbl_ortalama.AutoSize = true;
            this.lbl_ortalama.Location = new System.Drawing.Point(24, 221);
            this.lbl_ortalama.Name = "lbl_ortalama";
            this.lbl_ortalama.Size = new System.Drawing.Size(104, 20);
            this.lbl_ortalama.TabIndex = 5;
            this.lbl_ortalama.Text = "ORTALAMASI :";
            // 
            // FrmOrtalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 391);
            this.Controls.Add(this.gbox_islem);
            this.Name = "FrmOrtalama";
            this.Text = "FrmOrtalama";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_yaz1;
        private System.Windows.Forms.Label lbl_yaz2;
        private System.Windows.Forms.TextBox txt_yaz1;
        private System.Windows.Forms.TextBox txt_yaz2;
        private System.Windows.Forms.GroupBox gbox_islem;
        private System.Windows.Forms.Label lbl_ortalama;
        private System.Windows.Forms.Button btn_hesapla;
    }
}