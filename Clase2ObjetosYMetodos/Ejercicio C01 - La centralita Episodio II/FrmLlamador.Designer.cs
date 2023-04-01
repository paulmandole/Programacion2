namespace Ejercicio_C01___La_centralita_Episodio_II
{
    partial class FrmLlamador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtNumeroDestino = new System.Windows.Forms.TextBox();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFranja
            // 
            this.cmbFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranja.Enabled = false;
            this.cmbFranja.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbFranja.Location = new System.Drawing.Point(12, 299);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(342, 35);
            this.cmbFranja.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsterisco);
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(17, 175);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(49, 43);
            this.btnAsterisco.TabIndex = 14;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(127, 175);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(49, 43);
            this.btnNumeral.TabIndex = 15;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(72, 175);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(49, 43);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(127, 126);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(49, 43);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(72, 126);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(49, 43);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(17, 126);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(49, 43);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(127, 77);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(49, 43);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(72, 77);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(49, 43);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(17, 77);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(49, 43);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(127, 28);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(49, 43);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 28);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(49, 43);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(17, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(49, 43);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnPanelNumerio_Click);
            // 
            // txtNumeroDestino
            // 
            this.txtNumeroDestino.Enabled = false;
            this.txtNumeroDestino.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNumeroDestino.Name = "txtNumeroDestino";
            this.txtNumeroDestino.Size = new System.Drawing.Size(342, 37);
            this.txtNumeroDestino.TabIndex = 0;
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNroOrigen.Location = new System.Drawing.Point(218, 199);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(136, 24);
            this.txtNroOrigen.TabIndex = 1;
            this.txtNroOrigen.TextChanged += new System.EventHandler(this.txtNroOrigen_TextChanged);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLlamar.Location = new System.Drawing.Point(218, 62);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(136, 41);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLimpiar.Location = new System.Drawing.Point(218, 118);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(136, 40);
            this.btLimpiar.TabIndex = 3;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(218, 254);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 350);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.txtNumeroDestino);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLlamador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLlamador_FormClosing);
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtNumeroDestino;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}