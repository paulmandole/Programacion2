namespace Ejercicio_C01___La_centralita_Episodio_II
{
    partial class FrmMostrar
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
            this.rtbxMostrarInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxMostrarInfo
            // 
            this.rtbxMostrarInfo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbxMostrarInfo.Location = new System.Drawing.Point(10, 12);
            this.rtbxMostrarInfo.Name = "rtbxMostrarInfo";
            this.rtbxMostrarInfo.Size = new System.Drawing.Size(303, 412);
            this.rtbxMostrarInfo.TabIndex = 0;
            this.rtbxMostrarInfo.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.rtbxMostrarInfo);
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxMostrarInfo;
    }
}