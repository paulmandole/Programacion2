namespace Ejercicio_I01___La_lista_del_super
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
            this.lstObjetos = new System.Windows.Forms.ListBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstObjetos
            // 
            this.lstObjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstObjetos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstObjetos.FormattingEnabled = true;
            this.lstObjetos.ItemHeight = 23;
            this.lstObjetos.Location = new System.Drawing.Point(27, 14);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(272, 418);
            this.lstObjetos.TabIndex = 0;
            // 
            // btnMas
            // 
            this.btnMas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMas.Location = new System.Drawing.Point(331, 14);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(44, 39);
            this.btnMas.TabIndex = 1;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(331, 70);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(44, 39);
            this.btnMenos.TabIndex = 2;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(331, 130);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 39);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "M";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.lstObjetos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstObjetos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnModificar;
    }
}
