namespace _05_First_Single_Last
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnLastOrDefault = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnSingleOrDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 29);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(295, 29);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First()";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(12, 64);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(295, 29);
            this.btnFirstOrDefault.TabIndex = 0;
            this.btnFirstOrDefault.Text = "FirstOrDefault()";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(378, 29);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(295, 29);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = "Last()";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnLastOrDefault
            // 
            this.btnLastOrDefault.Location = new System.Drawing.Point(378, 64);
            this.btnLastOrDefault.Name = "btnLastOrDefault";
            this.btnLastOrDefault.Size = new System.Drawing.Size(295, 29);
            this.btnLastOrDefault.TabIndex = 0;
            this.btnLastOrDefault.Text = "LastOrDefault()";
            this.btnLastOrDefault.UseVisualStyleBackColor = true;
            this.btnLastOrDefault.Click += new System.EventHandler(this.btnLastOrDefault_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(742, 29);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(295, 29);
            this.btnSingle.TabIndex = 0;
            this.btnSingle.Text = "Single()";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnSingleOrDefault
            // 
            this.btnSingleOrDefault.Location = new System.Drawing.Point(742, 64);
            this.btnSingleOrDefault.Name = "btnSingleOrDefault";
            this.btnSingleOrDefault.Size = new System.Drawing.Size(295, 29);
            this.btnSingleOrDefault.TabIndex = 0;
            this.btnSingleOrDefault.Text = "SingleOrDefault()";
            this.btnSingleOrDefault.UseVisualStyleBackColor = true;
            this.btnSingleOrDefault.Click += new System.EventHandler(this.btnSingleOrDefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 111);
            this.Controls.Add(this.btnSingleOrDefault);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.btnLastOrDefault);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFirst;
        private Button btnFirstOrDefault;
        private Button btnLast;
        private Button btnLastOrDefault;
        private Button btnSingle;
        private Button btnSingleOrDefault;
    }
}