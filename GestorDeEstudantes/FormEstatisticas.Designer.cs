namespace GestorDeEstudantes
{
    partial class FormEstatisticas
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
            this.panelTotaldeEstu = new System.Windows.Forms.Panel();
            this.labelEstu = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelTotaldeEstu.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotaldeEstu
            // 
            this.panelTotaldeEstu.Controls.Add(this.labelEstu);
            this.panelTotaldeEstu.Location = new System.Drawing.Point(12, 12);
            this.panelTotaldeEstu.Name = "panelTotaldeEstu";
            this.panelTotaldeEstu.Size = new System.Drawing.Size(776, 206);
            this.panelTotaldeEstu.TabIndex = 0;
            // 
            // labelEstu
            // 
            this.labelEstu.AutoSize = true;
            this.labelEstu.Location = new System.Drawing.Point(1, 3);
            this.labelEstu.Name = "labelEstu";
            this.labelEstu.Size = new System.Drawing.Size(129, 13);
            this.labelEstu.TabIndex = 0;
            this.labelEstu.Text = "Total de Esteudantes 000";
            this.labelEstu.MouseEnter += new System.EventHandler(this.labelEstu_MouseEnter);
            this.labelEstu.MouseLeave += new System.EventHandler(this.labelEstu_MouseLeave);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(410, 224);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(378, 214);
            this.panelMeninas.TabIndex = 1;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Location = new System.Drawing.Point(3, 2);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(70, 13);
            this.labelMeninas.TabIndex = 1;
            this.labelMeninas.Text = "Meninas 00%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(12, 224);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(392, 214);
            this.panelMeninos.TabIndex = 1;
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Location = new System.Drawing.Point(1, 2);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(70, 13);
            this.labelMeninos.TabIndex = 2;
            this.labelMeninos.Text = "Meninos 00%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.labelMeninos_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.labelMeninos_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelTotaldeEstu);
            this.Name = "FormEstatisticas";
            this.Text = "Estatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotaldeEstu.ResumeLayout(false);
            this.panelTotaldeEstu.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotaldeEstu;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelEstu;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
    }
}