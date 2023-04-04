namespace _06_Take_Skip_Distinct
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTumunuGetir = new System.Windows.Forms.Button();
            this.btnIlk2Kayit = new System.Windows.Forms.Button();
            this.btnSonraki2Kayit = new System.Windows.Forms.Button();
            this.btnPersonelİsimTekil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTumunuGetir
            // 
            this.btnTumunuGetir.Location = new System.Drawing.Point(48, 93);
            this.btnTumunuGetir.Name = "btnTumunuGetir";
            this.btnTumunuGetir.Size = new System.Drawing.Size(292, 29);
            this.btnTumunuGetir.TabIndex = 0;
            this.btnTumunuGetir.Text = "Tümünü Getir";
            this.btnTumunuGetir.UseVisualStyleBackColor = true;
            this.btnTumunuGetir.Click += new System.EventHandler(this.btnTumunuGetir_Click);
            // 
            // btnIlk2Kayit
            // 
            this.btnIlk2Kayit.Location = new System.Drawing.Point(48, 153);
            this.btnIlk2Kayit.Name = "btnIlk2Kayit";
            this.btnIlk2Kayit.Size = new System.Drawing.Size(292, 29);
            this.btnIlk2Kayit.TabIndex = 0;
            this.btnIlk2Kayit.Text = "İlk 2 Kaydı Getir";
            this.btnIlk2Kayit.UseVisualStyleBackColor = true;
            this.btnIlk2Kayit.Click += new System.EventHandler(this.btnIlk2Kayit_Click);
            // 
            // btnSonraki2Kayit
            // 
            this.btnSonraki2Kayit.Location = new System.Drawing.Point(48, 208);
            this.btnSonraki2Kayit.Name = "btnSonraki2Kayit";
            this.btnSonraki2Kayit.Size = new System.Drawing.Size(292, 29);
            this.btnSonraki2Kayit.TabIndex = 0;
            this.btnSonraki2Kayit.Text = "İlk 2 Kaydı Atla Sonraki 2 Kaydı Getir";
            this.btnSonraki2Kayit.UseVisualStyleBackColor = true;
            this.btnSonraki2Kayit.Click += new System.EventHandler(this.btnSonraki2Kayit_Click);
            // 
            // btnPersonelİsimTekil
            // 
            this.btnPersonelİsimTekil.Location = new System.Drawing.Point(48, 261);
            this.btnPersonelİsimTekil.Name = "btnPersonelİsimTekil";
            this.btnPersonelİsimTekil.Size = new System.Drawing.Size(292, 29);
            this.btnPersonelİsimTekil.TabIndex = 0;
            this.btnPersonelİsimTekil.Text = "Personel İsimlerini Tekil Olarak Getir";
            this.btnPersonelİsimTekil.UseVisualStyleBackColor = true;
            this.btnPersonelİsimTekil.Click += new System.EventHandler(this.btnPersonelİsimTekil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(418, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPersonelİsimTekil);
            this.Controls.Add(this.btnSonraki2Kayit);
            this.Controls.Add(this.btnIlk2Kayit);
            this.Controls.Add(this.btnTumunuGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTumunuGetir;
        private Button btnIlk2Kayit;
        private Button btnSonraki2Kayit;
        private Button btnPersonelİsimTekil;
        private DataGridView dataGridView1;
    }
}