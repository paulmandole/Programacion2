namespace Trabajo_Práctico_N_1
{
    partial class MiCalculadora
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
            this.textN1 = new System.Windows.Forms.TextBox();
            this.textN2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvDec = new System.Windows.Forms.Button();
            this.btnConvBin = new System.Windows.Forms.Button();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.labResultado = new System.Windows.Forms.Label();
            this.lisBOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textN1
            // 
            this.textN1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textN1.Location = new System.Drawing.Point(25, 53);
            this.textN1.Name = "textN1";
            this.textN1.Size = new System.Drawing.Size(126, 30);
            this.textN1.TabIndex = 0;
            // 
            // textN2
            // 
            this.textN2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textN2.Location = new System.Drawing.Point(336, 53);
            this.textN2.Name = "textN2";
            this.textN2.Size = new System.Drawing.Size(126, 30);
            this.textN2.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.Location = new System.Drawing.Point(25, 104);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(126, 37);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(184, 104);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 37);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(336, 104);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 37);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvDec
            // 
            this.btnConvDec.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvDec.Location = new System.Drawing.Point(248, 147);
            this.btnConvDec.Name = "btnConvDec";
            this.btnConvDec.Size = new System.Drawing.Size(214, 36);
            this.btnConvDec.TabIndex = 6;
            this.btnConvDec.Text = "Convertir a Decimal";
            this.btnConvDec.UseVisualStyleBackColor = true;
            // 
            // btnConvBin
            // 
            this.btnConvBin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvBin.Location = new System.Drawing.Point(25, 147);
            this.btnConvBin.Name = "btnConvBin";
            this.btnConvBin.Size = new System.Drawing.Size(213, 36);
            this.btnConvBin.TabIndex = 7;
            this.btnConvBin.Text = "Convertir a Binario";
            this.btnConvBin.UseVisualStyleBackColor = true;
            this.btnConvBin.Click += new System.EventHandler(this.btnConvBin_Click);
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperaciones.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperaciones.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperaciones.Location = new System.Drawing.Point(205, 52);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(80, 31);
            this.cmbOperaciones.TabIndex = 8;
            // 
            // labResultado
            // 
            this.labResultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labResultado.Location = new System.Drawing.Point(248, 27);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(214, 23);
            this.labResultado.TabIndex = 9;
            this.labResultado.Text = "0";
            this.labResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lisBOperaciones
            // 
            this.lisBOperaciones.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lisBOperaciones.FormattingEnabled = true;
            this.lisBOperaciones.ItemHeight = 16;
            this.lisBOperaciones.Location = new System.Drawing.Point(480, 3);
            this.lisBOperaciones.Name = "lisBOperaciones";
            this.lisBOperaciones.Size = new System.Drawing.Size(131, 180);
            this.lisBOperaciones.TabIndex = 10;
            // 
            // MiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 214);
            this.Controls.Add(this.lisBOperaciones);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.btnConvBin);
            this.Controls.Add(this.btnConvDec);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.textN2);
            this.Controls.Add(this.textN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Paul Mandole";
            this.Load += new System.EventHandler(this.MiCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textN1;
        private System.Windows.Forms.TextBox textN2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvDec;
        private System.Windows.Forms.Button btnConvBin;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.ListBox lisBOperaciones;
    }
}
