﻿using MySql.Data.MySqlClient;
using System;
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
        Estudante estudante = new Estudante();
        MeuNamcoDeDados meuNamcoDeDados = new MeuNamcoDeDados();
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
            try
            {
                int idDoAluno = Convert.ToInt32(textBoxId.Text);
                MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `ìd` =@idDoAluno", meuNamcoDeDados.getConexao);
                DataTable tabela = estudante.pegarAlunos(comando);
                comando.Parameters.Add("@idDoAluno", MySqlDbType.Int32).Value = idDoAluno;
                if (tabela.Rows.Count > 0)
                {
                    textBoxNome.Text = tabela.Rows[0]["Nome"].ToString();
                    textBoxSobre.Text = tabela.Rows[0]["Sobenome"].ToString();
                    textBoxTel.Text = tabela.Rows[0]["Telefone"].ToString();
                    textBoxEnde.Text = tabela.Rows[0]["Endereco"].ToString();
                    dateTimePickerNasc.Value = (DateTime)tabela.Rows[0]["Nascimento"];
                    if (tabela.Rows[0]["Genero"].ToString() == "Feminino")
                    {
                        radioButtonFem.Checked = true;
                    }
                    else
                    {
                        radioButtonMasc.Checked = true;
                    }
                    byte[] foto = (byte[])tabela.Rows[0]["Foto"];
                    MemoryStream fotostream = new MemoryStream(foto);
                    pictureBoxAluno.Image = Image.FromStream(fotostream);
                }
            } catch (Exception execao)
            {
                MessageBox.Show("Digite uma ID válida!", "ID inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                int idDoAluno = Convert.ToInt32(textBoxId.Text);
                if (MessageBox.Show("Tem certeza que deseja pagar o aluno em questão?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudante.apagarEstudante(idDoAluno))
                    {
                        MessageBox.Show("Aluno apagado.", "Apagar aluno.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxId.Text = "";
                        textBoxNome.Text = "";
                        textBoxSobre.Text = "";
                        textBoxEnde.Text = "";
                        textBoxTel.Text = "";
                        dateTimePickerNasc.Value = DateTime.Now;
                        pictureBoxAluno.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Aluno não apagado!", "Apagar Estudante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
