﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }
        Estudante estudante = new Estudante();
        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

        }
        public void preencheTabela(MySqlCommand comando)
        {
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn coluna = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarAlunos(comando);
            coluna = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            coluna.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows = false;
            labelTotalAlunos.Text = "Total de Alunos: " + dataGridViewLista.Rows.Count;
        }

        private void dataGridViewLista_Click(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridViewLista.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewLista.CurrentRow.Cells[1].Value.ToString();
            textBoxSobre.Text = dataGridViewLista.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNasc.Value = (DateTime)dataGridViewLista.CurrentRow.Cells[3].Value;
            if (dataGridViewLista.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFem.Checked = true;
            }
            else 
            {
                radioButtonMasc.Checked = false;
            }
            textBoxTel.Text = dataGridViewLista.CurrentRow.Cells[5].Value.ToString();
            textBoxEnde.Text = dataGridViewLista.CurrentRow.Cells[6].Value.ToString();
            byte[] imagem;
            imagem = (byte[])dataGridViewLista.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream();
            pictureBoxAluno.Image = Image.FromStream(fotoDoAluno);
        }

        private void buttonRedef_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNome.Text = "";
            textBoxSobre.Text = "";
            dateTimePickerNasc.Value = DateTime.Now;
            radioButtonFem.Checked = true;
            textBoxTel.Text = "";
            textBoxEnde.Text = "";
            pictureBoxAluno.Image = null;
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
        }

        private void buttonBaixar_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarFoto = new SaveFileDialog();
            salvarFoto.FileName = "Aluno_" + textBoxId.Text;
            if (pictureBoxAluno.Image == null)
            {
                MessageBox.Show("Não tem foto para baixar.");
            }
            else 
            {
                pictureBoxAluno.Image.Save(salvarFoto.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBuscarDado_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT(`nome`,`sobrenome`,`endereco`) lIKE'%"+textBoxDado.Text+"%'"; 
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencheTabela(comando);
        }
    }
}
