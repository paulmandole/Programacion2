namespace Ejercicio_I02___Atrapame_si_puedes
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
            this.lbKilometros = new System.Windows.Forms.Label();
            this.lbLitros = new System.Windows.Forms.Label();
            this.tbxkilometros = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtxbResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbKilometros
            // 
            this.lbKilometros.AutoSize = true;
            this.lbKilometros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbKilometros.Location = new System.Drawing.Point(42, 72);
            this.lbKilometros.Name = "lbKilometros";
            this.lbKilometros.Size = new System.Drawing.Size(89, 23);
            this.lbKilometros.TabIndex = 0;
            this.lbKilometros.Text = "Kilometros";
            this.lbKilometros.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbLitros
            // 
            this.lbLitros.AutoSize = true;
            this.lbLitros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLitros.Location = new System.Drawing.Point(42, 145);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(55, 23);
            this.lbLitros.TabIndex = 1;
            this.lbLitros.Text = "Litros";
            // 
            // tbxkilometros
            // 
            this.tbxkilometros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxkilometros.Location = new System.Drawing.Point(42, 107);
            this.tbxkilometros.Name = "tbxkilometros";
            this.tbxkilometros.Size = new System.Drawing.Size(170, 30);
            this.tbxkilometros.TabIndex = 2;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxLitros.Location = new System.Drawing.Point(42, 171);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(170, 30);
            this.tbxLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(42, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(170, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtxbResultado
            // 
            this.rtxbResultado.Enabled = false;
            this.rtxbResultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxbResultado.Location = new System.Drawing.Point(266, 72);
            this.rtxbResultado.Name = "rtxbResultado";
            this.rtxbResultado.Size = new System.Drawing.Size(167, 171);
            this.rtxbResultado.TabIndex = 5;
            this.rtxbResultado.Text = "";
            this.rtxbResultado.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(477, 311);
            this.Controls.Add(this.rtxbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxkilometros);
            this.Controls.Add(this.lbLitros);
            this.Controls.Add(this.lbKilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKilometros;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.TextBox tbxkilometros;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtxbResultado;
    }
}
