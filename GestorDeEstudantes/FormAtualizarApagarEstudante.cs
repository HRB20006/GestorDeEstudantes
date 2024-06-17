﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    public partial class FormAtualizarApagarEstudante : Form
    {
        public FormAtualizarApagarEstudante()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog procurarFoto = new OpenFileDialog();

                procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

                if (procurarFoto.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAluno.Image = Image.FromFile(procurarFoto.FileName);
                }
            }
            bool Verificar()
            {
                if ((textBoxNome.Text.Trim() == "") ||
                   (textBoxSobre.Text.Trim() == "") ||
                   (textBoxTel.Text.Trim() == "") ||
                   (textBoxEnde.Text.Trim() == "") ||
                   (pictureBoxAluno.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            int id = Convert.ToInt32(textBoxId.Text); 
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobre.Text;
            DateTime nascimento = dateTimePickerNasc.Value;
            string telefone = textBoxTel.Text;
            string endereco = textBoxEnde.Text;
            string genero = "Outro";

            if (radioButtonMasc.Checked == true)
            {
                genero = "Masculino";
            }
            else if (radioButtonFem.Checked == true)
            {
                genero = "Feminino";
            }
            MemoryStream foto = new MemoryStream();

            int Birthday = dateTimePickerNasc.Value.Year;
            int todayDate = DateTime.Now.Year;

            if ((todayDate - Birthday) < 10 || (todayDate - Birthday) > 100)
            {
                MessageBox.Show("Idade do aluno inválida.", "Data de nascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxAluno.Image.Save(foto, pictureBoxAluno.Image.RawFormat);
                if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Atualizado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no na atualização", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações inválidas", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
               (textBoxSobre.Text.Trim() == "") ||
               (textBoxTel.Text.Trim() == "") ||
               (textBoxEnde.Text.Trim() == "") ||
               (pictureBoxAluno.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}