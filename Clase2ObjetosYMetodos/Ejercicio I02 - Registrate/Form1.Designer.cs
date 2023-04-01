namespace Ejercicio_I02___Registrate
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonNoBinario = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJs = new System.Windows.Forms.CheckBox();
            this.checkBoxCmas = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.groupBoxPaises = new System.Windows.Forms.GroupBox();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.groupBoxPaises.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelEdad);
            this.groupBoxDatos.Controls.Add(this.numEdad);
            this.groupBoxDatos.Controls.Add(this.labelDireccion);
            this.groupBoxDatos.Controls.Add(this.labelNombre);
            this.groupBoxDatos.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(224, 161);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Detalles del usuario";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEdad.Location = new System.Drawing.Point(6, 117);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(47, 23);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numEdad.Location = new System.Drawing.Point(111, 118);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(100, 26);
            this.numEdad.TabIndex = 4;
            this.numEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDireccion.Location = new System.Drawing.Point(6, 74);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(79, 23);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(6, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 23);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDireccion.Location = new System.Drawing.Point(111, 74);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 26);
            this.textBoxDireccion.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(111, 30);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 26);
            this.textBoxNombre.TabIndex = 0;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonNoBinario);
            this.groupBoxSexo.Controls.Add(this.radioButtonFemenino);
            this.groupBoxSexo.Controls.Add(this.radioBtnMasculino);
            this.groupBoxSexo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSexo.Location = new System.Drawing.Point(296, 12);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(200, 161);
            this.groupBoxSexo.TabIndex = 1;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Genero";
            this.groupBoxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonNoBinario
            // 
            this.radioButtonNoBinario.AutoSize = true;
            this.radioButtonNoBinario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNoBinario.Location = new System.Drawing.Point(32, 113);
            this.radioButtonNoBinario.Name = "radioButtonNoBinario";
            this.radioButtonNoBinario.Size = new System.Drawing.Size(107, 27);
            this.radioButtonNoBinario.TabIndex = 2;
            this.radioButtonNoBinario.TabStop = true;
            this.radioButtonNoBinario.Text = "No binario";
            this.radioButtonNoBinario.UseVisualStyleBackColor = true;
            this.radioButtonNoBinario.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFemenino.Location = new System.Drawing.Point(32, 72);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(96, 27);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            this.radioButtonFemenino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnMasculino.Location = new System.Drawing.Point(32, 28);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(99, 27);
            this.radioBtnMasculino.TabIndex = 0;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            this.radioBtnMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.checkBoxJs);
            this.groupBoxCursos.Controls.Add(this.checkBoxCmas);
            this.groupBoxCursos.Controls.Add(this.checkBoxC);
            this.groupBoxCursos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCursos.Location = new System.Drawing.Point(296, 196);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(200, 143);
            this.groupBoxCursos.TabIndex = 2;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJs
            // 
            this.checkBoxJs.AutoSize = true;
            this.checkBoxJs.Location = new System.Drawing.Point(32, 83);
            this.checkBoxJs.Name = "checkBoxJs";
            this.checkBoxJs.Size = new System.Drawing.Size(118, 23);
            this.checkBoxJs.TabIndex = 2;
            this.checkBoxJs.Text = "JavaScript";
            this.checkBoxJs.UseVisualStyleBackColor = true;
            // 
            // checkBoxCmas
            // 
            this.checkBoxCmas.AutoSize = true;
            this.checkBoxCmas.Location = new System.Drawing.Point(32, 54);
            this.checkBoxCmas.Name = "checkBoxCmas";
            this.checkBoxCmas.Size = new System.Drawing.Size(55, 23);
            this.checkBoxCmas.TabIndex = 1;
            this.checkBoxCmas.Text = "C++";
            this.checkBoxCmas.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(32, 25);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(46, 23);
            this.checkBoxC.TabIndex = 0;
            this.checkBoxC.Text = "C#";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(409, 359);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 41);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 23;
            this.listBoxPaises.Location = new System.Drawing.Point(6, 22);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(205, 165);
            this.listBoxPaises.TabIndex = 4;
            // 
            // groupBoxPaises
            // 
            this.groupBoxPaises.Controls.Add(this.listBoxPaises);
            this.groupBoxPaises.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPaises.Location = new System.Drawing.Point(12, 200);
            this.groupBoxPaises.Name = "groupBoxPaises";
            this.groupBoxPaises.Size = new System.Drawing.Size(224, 200);
            this.groupBoxPaises.TabIndex = 6;
            this.groupBoxPaises.TabStop = false;
            this.groupBoxPaises.Text = "Pais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.groupBoxPaises);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.groupBoxDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.groupBoxPaises.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonNoBinario;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.CheckBox checkBoxJs;
        private System.Windows.Forms.CheckBox checkBoxCmas;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.GroupBox groupBoxPaises;
    }
}
