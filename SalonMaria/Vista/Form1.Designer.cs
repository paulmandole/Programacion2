namespace Vista
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
            this.btnInv = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(77, 44);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(199, 61);
            this.btnInv.TabIndex = 0;
            this.btnInv.Text = "Inventario";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(77, 136);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(199, 68);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 435);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnInv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnClientes;
    }
}
