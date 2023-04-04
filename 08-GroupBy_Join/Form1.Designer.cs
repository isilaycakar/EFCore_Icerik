namespace _08_GroupBy_Join
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGroupAge = new System.Windows.Forms.Button();
            this.btnPersonelDepartman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(325, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGroupAge
            // 
            this.btnGroupAge.Location = new System.Drawing.Point(33, 66);
            this.btnGroupAge.Name = "btnGroupAge";
            this.btnGroupAge.Size = new System.Drawing.Size(231, 46);
            this.btnGroupAge.TabIndex = 1;
            this.btnGroupAge.Text = "Yaşa Göre Gruplama";
            this.btnGroupAge.UseVisualStyleBackColor = true;
            this.btnGroupAge.Click += new System.EventHandler(this.btnGroupAge_Click);
            // 
            // btnPersonelDepartman
            // 
            this.btnPersonelDepartman.Location = new System.Drawing.Point(33, 118);
            this.btnPersonelDepartman.Name = "btnPersonelDepartman";
            this.btnPersonelDepartman.Size = new System.Drawing.Size(231, 46);
            this.btnPersonelDepartman.TabIndex = 1;
            this.btnPersonelDepartman.Text = "Personel Departman Bilgileri";
            this.btnPersonelDepartman.UseVisualStyleBackColor = true;
            this.btnPersonelDepartman.Click += new System.EventHandler(this.btnPersonelDepartman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnPersonelDepartman);
            this.Controls.Add(this.btnGroupAge);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGroupAge;
        private Button btnPersonelDepartman;
    }
}