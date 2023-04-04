namespace _07_Some_Avg_Min_Max_Count
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
            this.btnKaçPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaçPersonel
            // 
            this.btnKaçPersonel.Location = new System.Drawing.Point(76, 56);
            this.btnKaçPersonel.Name = "btnKaçPersonel";
            this.btnKaçPersonel.Size = new System.Drawing.Size(258, 29);
            this.btnKaçPersonel.TabIndex = 0;
            this.btnKaçPersonel.Text = "Kaç Tane Personel Var?";
            this.btnKaçPersonel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaçPersonel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnKaçPersonel;
    }
}