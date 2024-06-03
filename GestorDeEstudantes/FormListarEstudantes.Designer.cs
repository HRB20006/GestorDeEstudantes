namespace GestorDeEstudantes
{
    partial class FormListarEstudantes
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
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.buttonAtua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(800, 377);
            this.dataGridViewLista.TabIndex = 0;
            this.dataGridViewLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentClick_1);
            this.dataGridViewLista.DoubleClick += new System.EventHandler(this.dataGridViewLista_DoubleClick);
            // 
            // buttonAtua
            // 
            this.buttonAtua.BackColor = System.Drawing.Color.Silver;
            this.buttonAtua.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtua.Location = new System.Drawing.Point(1, 380);
            this.buttonAtua.Name = "buttonAtua";
            this.buttonAtua.Size = new System.Drawing.Size(800, 69);
            this.buttonAtua.TabIndex = 1;
            this.buttonAtua.Text = "Atualizar";
            this.buttonAtua.UseVisualStyleBackColor = false;
            this.buttonAtua.Click += new System.EventHandler(this.buttonAtua_Click);
            // 
            // FormListarEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtua);
            this.Controls.Add(this.dataGridViewLista);
            this.Name = "FormListarEstudantes";
            this.Text = "FormListarEstudantes";
            this.Load += new System.EventHandler(this.FormListarEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button buttonAtua;
    }
}