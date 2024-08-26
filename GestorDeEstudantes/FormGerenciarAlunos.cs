using MySql.Data.MySqlClient;
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

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
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
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Login criado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informações inválidas", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemo_Click(object sender, EventArgs e)
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
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
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
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
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

        private void buttonAtua_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn coluna = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarAlunos(comando);
            coluna = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            coluna.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows = false;
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
}
