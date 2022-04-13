
namespace FormDersleri_1
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dikdortgen = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_veri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dikdortgen);
            this.groupBox1.Controls.Add(this.btn_carp);
            this.groupBox1.Controls.Add(this.btn_veri);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(31, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOŞGELDİNİZ";
            // 
            // btn_dikdortgen
            // 
            this.btn_dikdortgen.Location = new System.Drawing.Point(447, 319);
            this.btn_dikdortgen.Name = "btn_dikdortgen";
            this.btn_dikdortgen.Size = new System.Drawing.Size(94, 56);
            this.btn_dikdortgen.TabIndex = 3;
            this.btn_dikdortgen.Text = "AL.ÇEVRE HESABI";
            this.btn_dikdortgen.UseVisualStyleBackColor = true;
            this.btn_dikdortgen.Click += new System.EventHandler(this.btn_dikdortgen_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(292, 319);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(94, 56);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "ÇARPMA İŞLEMİ";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_veri
            // 
            this.btn_veri.Location = new System.Drawing.Point(135, 319);
            this.btn_veri.Name = "btn_veri";
            this.btn_veri.Size = new System.Drawing.Size(94, 56);
            this.btn_veri.TabIndex = 1;
            this.btn_veri.Text = "VERİ EKLEME";
            this.btn_veri.UseVisualStyleBackColor = true;
            this.btn_veri.Click += new System.EventHandler(this.btn_veri_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dikdortgen;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_veri;
    }
}