namespace calcular
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnEje = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(69, 63);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(235, 63);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 23);
            this.txt2.TabIndex = 1;
            // 
            // btnEje
            // 
            this.btnEje.Location = new System.Drawing.Point(247, 136);
            this.btnEje.Name = "btnEje";
            this.btnEje.Size = new System.Drawing.Size(75, 23);
            this.btnEje.TabIndex = 2;
            this.btnEje.Text = "Ejecutar";
            this.btnEje.UseVisualStyleBackColor = true;
            this.btnEje.Click += new System.EventHandler(this.btnEje_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(69, 136);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 23);
            this.txt3.TabIndex = 3;
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(385, 136);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btOrdenar.TabIndex = 4;
            this.btOrdenar.Text = "ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btnEje);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnEje;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btOrdenar;
    }
}
