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
using MySql.Data.MySqlClient;

namespace GestorDeEstudantes
{
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();
        private void FormListarEstudantes_Load(object sender, EventArgs e)
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


        private void dataGridViewLista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizarApagarEstudante formAtualizarApagarEstudante = new FormAtualizarApagarEstudante();
            formAtualizarApagarEstudante.textBoxId.Text = dataGridViewLista.CurrentRow.Cells[0].Value.ToString();
            formAtualizarApagarEstudante.textBoxNome.Text = dataGridViewLista.CurrentRow.Cells[1].Value.ToString();
            formAtualizarApagarEstudante.textBoxSobre.Text = dataGridViewLista.CurrentRow.Cells[2].Value.ToString();
            formAtualizarApagarEstudante.dateTimePickerNasc.Value = (DateTime) dataGridViewLista.CurrentRow.Cells[3].Value; 
            if (dataGridViewLista.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                formAtualizarApagarEstudante.radioButtonFem.Checked = true; 
            }
            else
            {
                formAtualizarApagarEstudante.radioButtonMasc.Checked = true;
            }
            formAtualizarApagarEstudante.textBoxTel.Text = dataGridViewLista.CurrentRow.Cells[5].Value.ToString();
            formAtualizarApagarEstudante.textBoxEnde.Text = dataGridViewLista.CurrentRow.Cells[6].Value.ToString();
            byte[] foto;
            foto = (byte[]) dataGridViewLista.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(foto);
            formAtualizarApagarEstudante.pictureBoxAluno.Image = Image.FromStream(fotoDoAluno);
            formAtualizarApagarEstudante.Show();
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
    }
}
