
namespace FormDersleri_1
{
    partial class FrmVeriAktar
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
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.gbox_islem = new System.Windows.Forms.GroupBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.lbox_aktar = new System.Windows.Forms.ListBox();
            this.gbox_islem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(33, 59);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(45, 20);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "İSİM :";
            // 
            // gbox_islem
            // 
            this.gbox_islem.Controls.Add(this.lbox_aktar);
            this.gbox_islem.Controls.Add(this.btn_aktar);
            this.gbox_islem.Controls.Add(this.txt_Ad);
            this.gbox_islem.Controls.Add(this.lbl_Ad);
            this.gbox_islem.Location = new System.Drawing.Point(166, 69);
            this.gbox_islem.Name = "gbox_islem";
            this.gbox_islem.Size = new System.Drawing.Size(410, 308);
            this.gbox_islem.TabIndex = 1;
            this.gbox_islem.TabStop = false;
            this.gbox_islem.Text = "İŞLEM KAYDI";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(154, 59);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(150, 27);
            this.txt_Ad.TabIndex = 1;
            // 
            // btn_aktar
            // 
            this.btn_aktar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_aktar.Location = new System.Drawing.Point(154, 121);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(150, 29);
            this.btn_aktar.TabIndex = 2;
            this.btn_aktar.Text = "AKTAR";
            this.btn_aktar.UseVisualStyleBackColor = false;
            this.btn_aktar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbox_aktar
            // 
            this.lbox_aktar.FormattingEnabled = true;
            this.lbox_aktar.ItemHeight = 20;
            this.lbox_aktar.Location = new System.Drawing.Point(154, 195);
            this.lbox_aktar.Name = "lbox_aktar";
            this.lbox_aktar.Size = new System.Drawing.Size(150, 104);
            this.lbox_aktar.TabIndex = 3;
            // 
            // FrmVeriAktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_islem);
            this.Name = "FrmVeriAktar";
            this.Text = "FrmVeriAktar";
            this.gbox_islem.ResumeLayout(false);
            this.gbox_islem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.GroupBox gbox_islem;
        private System.Windows.Forms.ListBox lbox_aktar;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.TextBox txt_Ad;
    }
}