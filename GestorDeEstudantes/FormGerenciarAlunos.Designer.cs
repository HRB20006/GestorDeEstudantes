namespace GestorDeEstudantes
{
    partial class FormGerenciarAlunos
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonRemo = new System.Windows.Forms.Button();
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.pictureBoxAluno = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMasc = new System.Windows.Forms.RadioButton();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNasc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSobre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEnde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBaixar = new System.Windows.Forms.Button();
            this.buttonAtua = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.buttonBuscarDado = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDado = new System.Windows.Forms.TextBox();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonRedef = new System.Windows.Forms.Button();
            this.labelTotalAlunos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Silver;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscar.Location = new System.Drawing.Point(207, 8);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(122, 31);
            this.buttonBuscar.TabIndex = 60;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 31);
            this.label7.TabIndex = 59;
            this.label7.Text = "Id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(57, 10);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(144, 28);
            this.textBoxId.TabIndex = 58;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Silver;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalvar.Location = new System.Drawing.Point(12, 341);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(166, 47);
            this.buttonSalvar.TabIndex = 57;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonRemo
            // 
            this.buttonRemo.BackColor = System.Drawing.Color.Silver;
            this.buttonRemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRemo.Location = new System.Drawing.Point(184, 342);
            this.buttonRemo.Name = "buttonRemo";
            this.buttonRemo.Size = new System.Drawing.Size(216, 47);
            this.buttonRemo.TabIndex = 56;
            this.buttonRemo.Text = "Remover";
            this.buttonRemo.UseVisualStyleBackColor = false;
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.BackColor = System.Drawing.Color.Silver;
            this.buttonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviarFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEnviarFoto.Location = new System.Drawing.Point(435, 394);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(178, 47);
            this.buttonEnviarFoto.TabIndex = 55;
            this.buttonEnviarFoto.Text = "Enviar Foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = false;
            this.buttonEnviarFoto.Click += new System.EventHandler(this.buttonEnviarFoto_Click);
            // 
            // pictureBoxAluno
            // 
            this.pictureBoxAluno.Location = new System.Drawing.Point(435, 10);
            this.pictureBoxAluno.Name = "pictureBoxAluno";
            this.pictureBoxAluno.Size = new System.Drawing.Size(235, 378);
            this.pictureBoxAluno.TabIndex = 54;
            this.pictureBoxAluno.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasc);
            this.groupBox1.Controls.Add(this.radioButtonFem);
            this.groupBox1.Location = new System.Drawing.Point(122, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 36);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonMasc
            // 
            this.radioButtonMasc.AutoSize = true;
            this.radioButtonMasc.Location = new System.Drawing.Point(6, 13);
            this.radioButtonMasc.Name = "radioButtonMasc";
            this.radioButtonMasc.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasc.TabIndex = 17;
            this.radioButtonMasc.TabStop = true;
            this.radioButtonMasc.Text = "Masculino";
            this.radioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Location = new System.Drawing.Point(98, 14);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFem.TabIndex = 18;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Feminino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNasc
            // 
            this.dateTimePickerNasc.Location = new System.Drawing.Point(164, 140);
            this.dateTimePickerNasc.Name = "dateTimePickerNasc";
            this.dateTimePickerNasc.Size = new System.Drawing.Size(265, 20);
            this.dateTimePickerNasc.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 51;
            this.label6.Text = "Sobrenome:";
            // 
            // textBoxSobre
            // 
            this.textBoxSobre.Location = new System.Drawing.Point(164, 92);
            this.textBoxSobre.Multiline = true;
            this.textBoxSobre.Name = "textBoxSobre";
            this.textBoxSobre.Size = new System.Drawing.Size(265, 28);
            this.textBoxSobre.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 31);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nascimento:";
            // 
            // textBoxEnde
            // 
            this.textBoxEnde.Location = new System.Drawing.Point(136, 245);
            this.textBoxEnde.Multiline = true;
            this.textBoxEnde.Name = "textBoxEnde";
            this.textBoxEnde.Size = new System.Drawing.Size(293, 76);
            this.textBoxEnde.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Telefone:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(136, 205);
            this.textBoxTel.Multiline = true;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(293, 28);
            this.textBoxTel.TabIndex = 44;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(6, 46);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(94, 31);
            this.labelUser.TabIndex = 43;
            this.labelUser.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(106, 46);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(323, 28);
            this.textBoxNome.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // buttonBaixar
            // 
            this.buttonBaixar.BackColor = System.Drawing.Color.Silver;
            this.buttonBaixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaixar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBaixar.Location = new System.Drawing.Point(629, 394);
            this.buttonBaixar.Name = "buttonBaixar";
            this.buttonBaixar.Size = new System.Drawing.Size(41, 47);
            this.buttonBaixar.TabIndex = 61;
            this.buttonBaixar.Text = "⇩";
            this.buttonBaixar.UseVisualStyleBackColor = false;
            this.buttonBaixar.Click += new System.EventHandler(this.buttonBaixar_Click);
            // 
            // buttonAtua
            // 
            this.buttonAtua.BackColor = System.Drawing.Color.Silver;
            this.buttonAtua.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtua.Location = new System.Drawing.Point(679, 377);
            this.buttonAtua.Name = "buttonAtua";
            this.buttonAtua.Size = new System.Drawing.Size(561, 64);
            this.buttonAtua.TabIndex = 63;
            this.buttonAtua.Text = "Atualizar";
            this.buttonAtua.UseVisualStyleBackColor = false;
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(679, 35);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(561, 336);
            this.dataGridViewLista.TabIndex = 62;
            this.dataGridViewLista.Click += new System.EventHandler(this.dataGridViewLista_Click);
            // 
            // buttonBuscarDado
            // 
            this.buttonBuscarDado.BackColor = System.Drawing.Color.Silver;
            this.buttonBuscarDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBuscarDado.Location = new System.Drawing.Point(976, 1);
            this.buttonBuscarDado.Name = "buttonBuscarDado";
            this.buttonBuscarDado.Size = new System.Drawing.Size(122, 31);
            this.buttonBuscarDado.TabIndex = 66;
            this.buttonBuscarDado.Text = "Buscar";
            this.buttonBuscarDado.UseVisualStyleBackColor = false;
            this.buttonBuscarDado.Click += new System.EventHandler(this.buttonBuscarDado_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(666, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 65;
            this.label8.Text = "Inserir dado:";
            // 
            // textBoxDado
            // 
            this.textBoxDado.Location = new System.Drawing.Point(823, 4);
            this.textBoxDado.Multiline = true;
            this.textBoxDado.Name = "textBoxDado";
            this.textBoxDado.Size = new System.Drawing.Size(147, 28);
            this.textBoxDado.TabIndex = 64;
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.BackColor = System.Drawing.Color.Silver;
            this.buttonIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIncluir.Location = new System.Drawing.Point(12, 394);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(166, 47);
            this.buttonIncluir.TabIndex = 68;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = false;
            // 
            // buttonRedef
            // 
            this.buttonRedef.BackColor = System.Drawing.Color.Silver;
            this.buttonRedef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedef.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRedef.Location = new System.Drawing.Point(185, 394);
            this.buttonRedef.Name = "buttonRedef";
            this.buttonRedef.Size = new System.Drawing.Size(215, 47);
            this.buttonRedef.TabIndex = 67;
            this.buttonRedef.Text = "Redefinir";
            this.buttonRedef.UseVisualStyleBackColor = false;
            this.buttonRedef.Click += new System.EventHandler(this.buttonRedef_Click);
            // 
            // labelTotalAlunos
            // 
            this.labelTotalAlunos.AutoSize = true;
            this.labelTotalAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAlunos.Location = new System.Drawing.Point(1104, 14);
            this.labelTotalAlunos.Name = "labelTotalAlunos";
            this.labelTotalAlunos.Size = new System.Drawing.Size(111, 17);
            this.labelTotalAlunos.TabIndex = 69;
            this.labelTotalAlunos.Text = "Total de Alunos:";
            // 
            // FormGerenciarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 455);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.buttonRedef);
            this.Controls.Add(this.buttonBuscarDado);
            this.Controls.Add(this.textBoxDado);
            this.Controls.Add(this.buttonAtua);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.buttonBaixar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonRemo);
            this.Controls.Add(this.buttonEnviarFoto);
            this.Controls.Add(this.pictureBoxAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSobre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEnde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalAlunos);
            this.Controls.Add(this.label8);
            this.Name = "FormGerenciarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGerenciarAlunos";
            this.Load += new System.EventHandler(this.FormGerenciarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonRemo;
        private System.Windows.Forms.Button buttonEnviarFoto;
        internal System.Windows.Forms.PictureBox pictureBoxAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton radioButtonMasc;
        internal System.Windows.Forms.RadioButton radioButtonFem;
        internal System.Windows.Forms.DateTimePicker dateTimePickerNasc;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxSobre;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBoxEnde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelUser;
        internal System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBaixar;
        private System.Windows.Forms.Button buttonAtua;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button buttonBuscarDado;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBoxDado;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonRedef;
        private System.Windows.Forms.Label labelTotalAlunos;
    }
}