namespace Ejercicio_I01____Hola__Windows_Forms_
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
            this.comboMaterias = new System.Windows.Forms.ComboBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboMaterias
            // 
            this.comboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaterias.Location = new System.Drawing.Point(26, 120);
            this.comboMaterias.Name = "comboMaterias";
            this.comboMaterias.Size = new System.Drawing.Size(260, 23);
            this.comboMaterias.TabIndex = 5;
            this.comboMaterias.SelectedIndexChanged += new System.EventHandler(this.comboMaterias_SelectedIndexChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(26, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(186, 41);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(60, 17);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(26, 61);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 23);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(186, 61);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 23);
            this.textBoxApellido.TabIndex = 3;
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(331, 61);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaterias.Location = new System.Drawing.Point(26, 102);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(61, 17);
            this.labelMaterias.TabIndex = 6;
            this.labelMaterias.Text = "Materias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 164);
            this.Controls.Add(this.labelMaterias);
            this.Controls.Add(this.comboMaterias);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox comboMaterias;
        private System.Windows.Forms.Label labelMaterias;
    }
}
