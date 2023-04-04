namespace _03_ExtensionMethodİleLinq
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
            this.lbxListe = new System.Windows.Forms.ListBox();
            this.btnYaİleBitenler = new System.Windows.Forms.Button();
            this.btnAİleBaslayanlar = new System.Windows.Forms.Button();
            this.btnZdenAyaSirala = new System.Windows.Forms.Button();
            this.btnAdanZyeSirala = new System.Windows.Forms.Button();
            this.btnAltidanFazlaOlan = new System.Windows.Forms.Button();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxListe
            // 
            this.lbxListe.FormattingEnabled = true;
            this.lbxListe.ItemHeight = 20;
            this.lbxListe.Location = new System.Drawing.Point(349, 9);
            this.lbxListe.Name = "lbxListe";
            this.lbxListe.Size = new System.Drawing.Size(294, 424);
            this.lbxListe.TabIndex = 8;
            // 
            // btnYaİleBitenler
            // 
            this.btnYaİleBitenler.Location = new System.Drawing.Point(12, 202);
            this.btnYaİleBitenler.Name = "btnYaİleBitenler";
            this.btnYaİleBitenler.Size = new System.Drawing.Size(313, 30);
            this.btnYaİleBitenler.TabIndex = 2;
            this.btnYaİleBitenler.Text = "Ya ile Bitenler";
            this.btnYaİleBitenler.UseVisualStyleBackColor = true;
            this.btnYaİleBitenler.Click += new System.EventHandler(this.btnYaİleBitenler_Click);
            // 
            // btnAİleBaslayanlar
            // 
            this.btnAİleBaslayanlar.Location = new System.Drawing.Point(12, 166);
            this.btnAİleBaslayanlar.Name = "btnAİleBaslayanlar";
            this.btnAİleBaslayanlar.Size = new System.Drawing.Size(313, 30);
            this.btnAİleBaslayanlar.TabIndex = 3;
            this.btnAİleBaslayanlar.Text = "A ile Başlayanlar";
            this.btnAİleBaslayanlar.UseVisualStyleBackColor = true;
            this.btnAİleBaslayanlar.Click += new System.EventHandler(this.btnAİleBaslayanlar_Click);
            // 
            // btnZdenAyaSirala
            // 
            this.btnZdenAyaSirala.Location = new System.Drawing.Point(12, 130);
            this.btnZdenAyaSirala.Name = "btnZdenAyaSirala";
            this.btnZdenAyaSirala.Size = new System.Drawing.Size(313, 30);
            this.btnZdenAyaSirala.TabIndex = 4;
            this.btnZdenAyaSirala.Text = "Z\'den A\'ya Sırala";
            this.btnZdenAyaSirala.UseVisualStyleBackColor = true;
            this.btnZdenAyaSirala.Click += new System.EventHandler(this.btnZdenAyaSirala_Click);
            // 
            // btnAdanZyeSirala
            // 
            this.btnAdanZyeSirala.Location = new System.Drawing.Point(12, 94);
            this.btnAdanZyeSirala.Name = "btnAdanZyeSirala";
            this.btnAdanZyeSirala.Size = new System.Drawing.Size(313, 30);
            this.btnAdanZyeSirala.TabIndex = 5;
            this.btnAdanZyeSirala.Text = "A\'dan Z\'ye Sırala";
            this.btnAdanZyeSirala.UseVisualStyleBackColor = true;
            this.btnAdanZyeSirala.Click += new System.EventHandler(this.btnAdanZyeSirala_Click);
            // 
            // btnAltidanFazlaOlan
            // 
            this.btnAltidanFazlaOlan.Location = new System.Drawing.Point(12, 58);
            this.btnAltidanFazlaOlan.Name = "btnAltidanFazlaOlan";
            this.btnAltidanFazlaOlan.Size = new System.Drawing.Size(313, 30);
            this.btnAltidanFazlaOlan.TabIndex = 6;
            this.btnAltidanFazlaOlan.Text = "6 Karakterden Fazla Olanlar";
            this.btnAltidanFazlaOlan.UseVisualStyleBackColor = true;
            this.btnAltidanFazlaOlan.Click += new System.EventHandler(this.btnAltidanFazlaOlan_Click);
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.Location = new System.Drawing.Point(12, 22);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(313, 30);
            this.btnTumunuListele.TabIndex = 7;
            this.btnTumunuListele.Text = "Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = true;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.lbxListe);
            this.Controls.Add(this.btnYaİleBitenler);
            this.Controls.Add(this.btnAİleBaslayanlar);
            this.Controls.Add(this.btnZdenAyaSirala);
            this.Controls.Add(this.btnAdanZyeSirala);
            this.Controls.Add(this.btnAltidanFazlaOlan);
            this.Controls.Add(this.btnTumunuListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbxListe;
        private Button btnYaİleBitenler;
        private Button btnAİleBaslayanlar;
        private Button btnZdenAyaSirala;
        private Button btnAdanZyeSirala;
        private Button btnAltidanFazlaOlan;
        private Button btnTumunuListele;
    }
}