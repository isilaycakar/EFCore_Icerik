namespace _04_Any_All_Contains
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
            this.btnAll1830 = new System.Windows.Forms.Button();
            this.btnAll1840 = new System.Windows.Forms.Button();
            this.btnAge1820 = new System.Windows.Forms.Button();
            this.btnAge1830 = new System.Windows.Forms.Button();
            this.btnAdiAnkara = new System.Windows.Forms.Button();
            this.btnPersonelIsilay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAll1830
            // 
            this.btnAll1830.Location = new System.Drawing.Point(12, 36);
            this.btnAll1830.Name = "btnAll1830";
            this.btnAll1830.Size = new System.Drawing.Size(287, 29);
            this.btnAll1830.TabIndex = 0;
            this.btnAll1830.Text = "18< All <30";
            this.btnAll1830.UseVisualStyleBackColor = true;
            this.btnAll1830.Click += new System.EventHandler(this.btnAll1830_Click);
            // 
            // btnAll1840
            // 
            this.btnAll1840.Location = new System.Drawing.Point(12, 86);
            this.btnAll1840.Name = "btnAll1840";
            this.btnAll1840.Size = new System.Drawing.Size(287, 29);
            this.btnAll1840.TabIndex = 0;
            this.btnAll1840.Text = "18< All <40";
            this.btnAll1840.UseVisualStyleBackColor = true;
            this.btnAll1840.Click += new System.EventHandler(this.btnAll1840_Click);
            // 
            // btnAge1820
            // 
            this.btnAge1820.Location = new System.Drawing.Point(12, 135);
            this.btnAge1820.Name = "btnAge1820";
            this.btnAge1820.Size = new System.Drawing.Size(287, 29);
            this.btnAge1820.TabIndex = 0;
            this.btnAge1820.Text = "18< Age <20";
            this.btnAge1820.UseVisualStyleBackColor = true;
            this.btnAge1820.Click += new System.EventHandler(this.btnAge1820_Click);
            // 
            // btnAge1830
            // 
            this.btnAge1830.Location = new System.Drawing.Point(12, 184);
            this.btnAge1830.Name = "btnAge1830";
            this.btnAge1830.Size = new System.Drawing.Size(287, 29);
            this.btnAge1830.TabIndex = 0;
            this.btnAge1830.Text = "18< Age <30";
            this.btnAge1830.UseVisualStyleBackColor = true;
            this.btnAge1830.Click += new System.EventHandler(this.btnAge1830_Click);
            // 
            // btnAdiAnkara
            // 
            this.btnAdiAnkara.Location = new System.Drawing.Point(12, 272);
            this.btnAdiAnkara.Name = "btnAdiAnkara";
            this.btnAdiAnkara.Size = new System.Drawing.Size(287, 29);
            this.btnAdiAnkara.TabIndex = 0;
            this.btnAdiAnkara.Text = "İsmi Ankara Olan Şehir Var mı?";
            this.btnAdiAnkara.UseVisualStyleBackColor = true;
            this.btnAdiAnkara.Click += new System.EventHandler(this.btnAdiAnkara_Click);
            // 
            // btnPersonelIsilay
            // 
            this.btnPersonelIsilay.Location = new System.Drawing.Point(12, 319);
            this.btnPersonelIsilay.Name = "btnPersonelIsilay";
            this.btnPersonelIsilay.Size = new System.Drawing.Size(287, 29);
            this.btnPersonelIsilay.TabIndex = 0;
            this.btnPersonelIsilay.Text = "İsmi Işılay Olan Personel Var mı?";
            this.btnPersonelIsilay.UseVisualStyleBackColor = true;
            this.btnPersonelIsilay.Click += new System.EventHandler(this.btnPersonelIsilay2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 378);
            this.Controls.Add(this.btnPersonelIsilay);
            this.Controls.Add(this.btnAdiAnkara);
            this.Controls.Add(this.btnAge1830);
            this.Controls.Add(this.btnAge1820);
            this.Controls.Add(this.btnAll1840);
            this.Controls.Add(this.btnAll1830);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAll1830;
        private Button btnAll1840;
        private Button btnAge1820;
        private Button btnAge1830;
        private Button btnAdiAnkara;
        private Button btnPersonelIsilay;
    }
}