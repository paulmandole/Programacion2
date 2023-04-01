namespace Ejercicio_C01___Cotizador_desktop
{
    partial class FormConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConversor));
            this.labCotizacion = new System.Windows.Forms.Label();
            this.labEuro = new System.Windows.Forms.Label();
            this.labDolar = new System.Windows.Forms.Label();
            this.labPeso = new System.Windows.Forms.Label();
            this.textBmontoEuro = new System.Windows.Forms.TextBox();
            this.textBmontoPeso = new System.Windows.Forms.TextBox();
            this.textBmontoDolar = new System.Windows.Forms.TextBox();
            this.btnCandado = new System.Windows.Forms.Button();
            this.btnConvertir1 = new System.Windows.Forms.Button();
            this.btnConvertir2 = new System.Windows.Forms.Button();
            this.btnConvetir3 = new System.Windows.Forms.Button();
            this.textBCotzPeso = new System.Windows.Forms.TextBox();
            this.textBCotzDolar = new System.Windows.Forms.TextBox();
            this.textBCotzEuro = new System.Windows.Forms.TextBox();
            this.labPesoConv = new System.Windows.Forms.Label();
            this.labDolarConv = new System.Windows.Forms.Label();
            this.labEuroConv = new System.Windows.Forms.Label();
            this.textBPesoPeso = new System.Windows.Forms.TextBox();
            this.textBPesoDolar = new System.Windows.Forms.TextBox();
            this.textBPesoEuro = new System.Windows.Forms.TextBox();
            this.textBDolarPeso = new System.Windows.Forms.TextBox();
            this.textBDolarDolar = new System.Windows.Forms.TextBox();
            this.textBDolarEuro = new System.Windows.Forms.TextBox();
            this.textBEuroEuro = new System.Windows.Forms.TextBox();
            this.textBEuroDolar = new System.Windows.Forms.TextBox();
            this.textBEuroPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labCotizacion
            // 
            this.labCotizacion.AutoSize = true;
            this.labCotizacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCotizacion.Location = new System.Drawing.Point(68, 30);
            this.labCotizacion.Name = "labCotizacion";
            this.labCotizacion.Size = new System.Drawing.Size(86, 23);
            this.labCotizacion.TabIndex = 0;
            this.labCotizacion.Text = "Cotizacion";
            // 
            // labEuro
            // 
            this.labEuro.AutoSize = true;
            this.labEuro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEuro.Location = new System.Drawing.Point(12, 107);
            this.labEuro.Name = "labEuro";
            this.labEuro.Size = new System.Drawing.Size(44, 23);
            this.labEuro.TabIndex = 1;
            this.labEuro.Text = "Euro";
            // 
            // labDolar
            // 
            this.labDolar.AutoSize = true;
            this.labDolar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDolar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDolar.Location = new System.Drawing.Point(12, 146);
            this.labDolar.Name = "labDolar";
            this.labDolar.Size = new System.Drawing.Size(51, 23);
            this.labDolar.TabIndex = 2;
            this.labDolar.Text = "Dolar";
            // 
            // labPeso
            // 
            this.labPeso.AutoSize = true;
            this.labPeso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPeso.Location = new System.Drawing.Point(12, 188);
            this.labPeso.Name = "labPeso";
            this.labPeso.Size = new System.Drawing.Size(44, 23);
            this.labPeso.TabIndex = 3;
            this.labPeso.Text = "Peso";
            // 
            // textBmontoEuro
            // 
            this.textBmontoEuro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBmontoEuro.Location = new System.Drawing.Point(68, 104);
            this.textBmontoEuro.Name = "textBmontoEuro";
            this.textBmontoEuro.Size = new System.Drawing.Size(100, 30);
            this.textBmontoEuro.TabIndex = 4;
            this.textBmontoEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBmontoEuro.Leave += new System.EventHandler(this.textBmontoEuro_Leave);
            // 
            // textBmontoPeso
            // 
            this.textBmontoPeso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBmontoPeso.Location = new System.Drawing.Point(68, 185);
            this.textBmontoPeso.Name = "textBmontoPeso";
            this.textBmontoPeso.Size = new System.Drawing.Size(100, 30);
            this.textBmontoPeso.TabIndex = 5;
            this.textBmontoPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBmontoPeso.Leave += new System.EventHandler(this.textBmontoPeso_Leave);
            // 
            // textBmontoDolar
            // 
            this.textBmontoDolar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBmontoDolar.Location = new System.Drawing.Point(68, 143);
            this.textBmontoDolar.Name = "textBmontoDolar";
            this.textBmontoDolar.Size = new System.Drawing.Size(100, 30);
            this.textBmontoDolar.TabIndex = 6;
            this.textBmontoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBmontoDolar.Leave += new System.EventHandler(this.textBmontoDolar_Leave);
            // 
            // btnCandado
            // 
            this.btnCandado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCandado.Image = ((System.Drawing.Image)(resources.GetObject("btnCandado.Image")));
            this.btnCandado.Location = new System.Drawing.Point(184, 19);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(75, 36);
            this.btnCandado.TabIndex = 7;
            this.btnCandado.UseVisualStyleBackColor = true;
            this.btnCandado.Click += new System.EventHandler(this.btnCandado_Click);
            // 
            // btnConvertir1
            // 
            this.btnConvertir1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir1.Location = new System.Drawing.Point(184, 103);
            this.btnConvertir1.Name = "btnConvertir1";
            this.btnConvertir1.Size = new System.Drawing.Size(75, 31);
            this.btnConvertir1.TabIndex = 8;
            this.btnConvertir1.Text = "->";
            this.btnConvertir1.UseVisualStyleBackColor = true;
            this.btnConvertir1.Click += new System.EventHandler(this.btnConvertir1_Click);
            // 
            // btnConvertir2
            // 
            this.btnConvertir2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertir2.Location = new System.Drawing.Point(184, 142);
            this.btnConvertir2.Name = "btnConvertir2";
            this.btnConvertir2.Size = new System.Drawing.Size(75, 31);
            this.btnConvertir2.TabIndex = 9;
            this.btnConvertir2.Text = "->";
            this.btnConvertir2.UseVisualStyleBackColor = true;
            this.btnConvertir2.Click += new System.EventHandler(this.btnConvertir2_Click);
            // 
            // btnConvetir3
            // 
            this.btnConvetir3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvetir3.Location = new System.Drawing.Point(184, 186);
            this.btnConvetir3.Name = "btnConvetir3";
            this.btnConvetir3.Size = new System.Drawing.Size(75, 29);
            this.btnConvetir3.TabIndex = 10;
            this.btnConvetir3.Text = "->";
            this.btnConvetir3.UseVisualStyleBackColor = true;
            this.btnConvetir3.Click += new System.EventHandler(this.btnConvetir3_Click);
            // 
            // textBCotzPeso
            // 
            this.textBCotzPeso.Enabled = false;
            this.textBCotzPeso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBCotzPeso.Location = new System.Drawing.Point(500, 27);
            this.textBCotzPeso.Name = "textBCotzPeso";
            this.textBCotzPeso.Size = new System.Drawing.Size(100, 30);
            this.textBCotzPeso.TabIndex = 11;
            this.textBCotzPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBCotzPeso.Leave += new System.EventHandler(this.textBCotzEuro_Leave);
            // 
            // textBCotzDolar
            // 
            this.textBCotzDolar.Enabled = false;
            this.textBCotzDolar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBCotzDolar.Location = new System.Drawing.Point(394, 27);
            this.textBCotzDolar.Name = "textBCotzDolar";
            this.textBCotzDolar.Size = new System.Drawing.Size(100, 30);
            this.textBCotzDolar.TabIndex = 12;
            this.textBCotzDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBCotzDolar.Leave += new System.EventHandler(this.textBCotzEuro_Leave);
            // 
            // textBCotzEuro
            // 
            this.textBCotzEuro.Enabled = false;
            this.textBCotzEuro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBCotzEuro.Location = new System.Drawing.Point(288, 27);
            this.textBCotzEuro.Name = "textBCotzEuro";
            this.textBCotzEuro.Size = new System.Drawing.Size(100, 30);
            this.textBCotzEuro.TabIndex = 13;
            this.textBCotzEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBCotzEuro.TextChanged += new System.EventHandler(this.textBCotzEuro_TextChanged);
            this.textBCotzEuro.Leave += new System.EventHandler(this.textBCotzEuro_Leave);
            // 
            // labPesoConv
            // 
            this.labPesoConv.AutoSize = true;
            this.labPesoConv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labPesoConv.Location = new System.Drawing.Point(526, 70);
            this.labPesoConv.Name = "labPesoConv";
            this.labPesoConv.Size = new System.Drawing.Size(44, 23);
            this.labPesoConv.TabIndex = 14;
            this.labPesoConv.Text = "Peso";
            // 
            // labDolarConv
            // 
            this.labDolarConv.AutoSize = true;
            this.labDolarConv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDolarConv.Location = new System.Drawing.Point(418, 70);
            this.labDolarConv.Name = "labDolarConv";
            this.labDolarConv.Size = new System.Drawing.Size(51, 23);
            this.labDolarConv.TabIndex = 15;
            this.labDolarConv.Text = "Dolar";
            // 
            // labEuroConv
            // 
            this.labEuroConv.AutoSize = true;
            this.labEuroConv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEuroConv.Location = new System.Drawing.Point(308, 70);
            this.labEuroConv.Name = "labEuroConv";
            this.labEuroConv.Size = new System.Drawing.Size(44, 23);
            this.labEuroConv.TabIndex = 16;
            this.labEuroConv.Text = "Euro";
            // 
            // textBPesoPeso
            // 
            this.textBPesoPeso.Enabled = false;
            this.textBPesoPeso.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBPesoPeso.Location = new System.Drawing.Point(500, 185);
            this.textBPesoPeso.Name = "textBPesoPeso";
            this.textBPesoPeso.Size = new System.Drawing.Size(100, 26);
            this.textBPesoPeso.TabIndex = 17;
            this.textBPesoPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBPesoDolar
            // 
            this.textBPesoDolar.Enabled = false;
            this.textBPesoDolar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBPesoDolar.Location = new System.Drawing.Point(394, 185);
            this.textBPesoDolar.Name = "textBPesoDolar";
            this.textBPesoDolar.Size = new System.Drawing.Size(100, 26);
            this.textBPesoDolar.TabIndex = 18;
            this.textBPesoDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBPesoEuro
            // 
            this.textBPesoEuro.Enabled = false;
            this.textBPesoEuro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBPesoEuro.Location = new System.Drawing.Point(288, 185);
            this.textBPesoEuro.Name = "textBPesoEuro";
            this.textBPesoEuro.Size = new System.Drawing.Size(100, 26);
            this.textBPesoEuro.TabIndex = 19;
            this.textBPesoEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBDolarPeso
            // 
            this.textBDolarPeso.Enabled = false;
            this.textBDolarPeso.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBDolarPeso.Location = new System.Drawing.Point(500, 143);
            this.textBDolarPeso.Name = "textBDolarPeso";
            this.textBDolarPeso.Size = new System.Drawing.Size(100, 26);
            this.textBDolarPeso.TabIndex = 20;
            this.textBDolarPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBDolarDolar
            // 
            this.textBDolarDolar.Enabled = false;
            this.textBDolarDolar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBDolarDolar.Location = new System.Drawing.Point(394, 143);
            this.textBDolarDolar.Name = "textBDolarDolar";
            this.textBDolarDolar.Size = new System.Drawing.Size(100, 26);
            this.textBDolarDolar.TabIndex = 21;
            this.textBDolarDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBDolarEuro
            // 
            this.textBDolarEuro.Enabled = false;
            this.textBDolarEuro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBDolarEuro.Location = new System.Drawing.Point(288, 143);
            this.textBDolarEuro.Name = "textBDolarEuro";
            this.textBDolarEuro.Size = new System.Drawing.Size(100, 26);
            this.textBDolarEuro.TabIndex = 22;
            this.textBDolarEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBEuroEuro
            // 
            this.textBEuroEuro.Enabled = false;
            this.textBEuroEuro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBEuroEuro.Location = new System.Drawing.Point(288, 104);
            this.textBEuroEuro.Name = "textBEuroEuro";
            this.textBEuroEuro.Size = new System.Drawing.Size(100, 26);
            this.textBEuroEuro.TabIndex = 25;
            this.textBEuroEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBEuroDolar
            // 
            this.textBEuroDolar.Enabled = false;
            this.textBEuroDolar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBEuroDolar.Location = new System.Drawing.Point(394, 104);
            this.textBEuroDolar.Name = "textBEuroDolar";
            this.textBEuroDolar.Size = new System.Drawing.Size(100, 26);
            this.textBEuroDolar.TabIndex = 24;
            this.textBEuroDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBEuroPeso
            // 
            this.textBEuroPeso.Enabled = false;
            this.textBEuroPeso.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBEuroPeso.Location = new System.Drawing.Point(500, 104);
            this.textBEuroPeso.Name = "textBEuroPeso";
            this.textBEuroPeso.Size = new System.Drawing.Size(100, 26);
            this.textBEuroPeso.TabIndex = 23;
            this.textBEuroPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 266);
            this.Controls.Add(this.textBEuroEuro);
            this.Controls.Add(this.textBEuroDolar);
            this.Controls.Add(this.textBEuroPeso);
            this.Controls.Add(this.textBDolarEuro);
            this.Controls.Add(this.textBDolarDolar);
            this.Controls.Add(this.textBDolarPeso);
            this.Controls.Add(this.textBPesoEuro);
            this.Controls.Add(this.textBPesoDolar);
            this.Controls.Add(this.textBPesoPeso);
            this.Controls.Add(this.labEuroConv);
            this.Controls.Add(this.labDolarConv);
            this.Controls.Add(this.labPesoConv);
            this.Controls.Add(this.textBCotzEuro);
            this.Controls.Add(this.textBCotzDolar);
            this.Controls.Add(this.textBCotzPeso);
            this.Controls.Add(this.btnConvetir3);
            this.Controls.Add(this.btnConvertir2);
            this.Controls.Add(this.btnConvertir1);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.textBmontoDolar);
            this.Controls.Add(this.textBmontoPeso);
            this.Controls.Add(this.textBmontoEuro);
            this.Controls.Add(this.labPeso);
            this.Controls.Add(this.labDolar);
            this.Controls.Add(this.labEuro);
            this.Controls.Add(this.labCotizacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.FormConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCotizacion;
        private System.Windows.Forms.Label labEuro;
        private System.Windows.Forms.Label labDolar;
        private System.Windows.Forms.Label labPeso;
        private System.Windows.Forms.TextBox textBmontoEuro;
        private System.Windows.Forms.TextBox textBmontoPeso;
        private System.Windows.Forms.TextBox textBmontoDolar;
        private System.Windows.Forms.Button btnCandado;
        private System.Windows.Forms.Button btnConvertir1;
        private System.Windows.Forms.Button btnConvertir2;
        private System.Windows.Forms.Button btnConvetir3;
        private System.Windows.Forms.TextBox textBCotzPeso;
        private System.Windows.Forms.TextBox textBCotzDolar;
        private System.Windows.Forms.TextBox textBCotzEuro;
        private System.Windows.Forms.Label labPesoConv;
        private System.Windows.Forms.Label labDolarConv;
        private System.Windows.Forms.Label labEuroConv;
        private System.Windows.Forms.TextBox textBPesoPeso;
        private System.Windows.Forms.TextBox textBPesoDolar;
        private System.Windows.Forms.TextBox textBPesoEuro;
        private System.Windows.Forms.TextBox textBDolarPeso;
        private System.Windows.Forms.TextBox textBDolarDolar;
        private System.Windows.Forms.TextBox textBDolarEuro;
        private System.Windows.Forms.TextBox textBEuroEuro;
        private System.Windows.Forms.TextBox textBEuroDolar;
        private System.Windows.Forms.TextBox textBEuroPeso;
    }
}
