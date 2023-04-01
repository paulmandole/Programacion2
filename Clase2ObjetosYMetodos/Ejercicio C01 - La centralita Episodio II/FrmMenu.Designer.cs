namespace Ejercicio_C01___La_centralita_Episodio_II
{
    partial class FrmMenu
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFactTotal = new System.Windows.Forms.Button();
            this.btnFactLocal = new System.Windows.Forms.Button();
            this.btnFactProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarLlamada.Location = new System.Drawing.Point(35, 15);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(204, 56);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFactTotal
            // 
            this.btnFactTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactTotal.Location = new System.Drawing.Point(35, 77);
            this.btnFactTotal.Name = "btnFactTotal";
            this.btnFactTotal.Size = new System.Drawing.Size(204, 56);
            this.btnFactTotal.TabIndex = 1;
            this.btnFactTotal.Text = "Facturacion Total";
            this.btnFactTotal.UseVisualStyleBackColor = true;
            this.btnFactTotal.Click += new System.EventHandler(this.btnFactTotal_Click);
            // 
            // btnFactLocal
            // 
            this.btnFactLocal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactLocal.Location = new System.Drawing.Point(35, 139);
            this.btnFactLocal.Name = "btnFactLocal";
            this.btnFactLocal.Size = new System.Drawing.Size(204, 56);
            this.btnFactLocal.TabIndex = 2;
            this.btnFactLocal.Text = "Facturacion Local";
            this.btnFactLocal.UseVisualStyleBackColor = true;
            this.btnFactLocal.Click += new System.EventHandler(this.btnFactLocal_Click);
            // 
            // btnFactProv
            // 
            this.btnFactProv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFactProv.Location = new System.Drawing.Point(35, 201);
            this.btnFactProv.Name = "btnFactProv";
            this.btnFactProv.Size = new System.Drawing.Size(204, 56);
            this.btnFactProv.TabIndex = 3;
            this.btnFactProv.Text = "Facturacion Provincial";
            this.btnFactProv.UseVisualStyleBackColor = true;
            this.btnFactProv.Click += new System.EventHandler(this.btnFactProv_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(35, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 351);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFactProv);
            this.Controls.Add(this.btnFactLocal);
            this.Controls.Add(this.btnFactTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFactTotal;
        private System.Windows.Forms.Button btnFactLocal;
        private System.Windows.Forms.Button btnFactProv;
        private System.Windows.Forms.Button btnSalir;
    }
}
