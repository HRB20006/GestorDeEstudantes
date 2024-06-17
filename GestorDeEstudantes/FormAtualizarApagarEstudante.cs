using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
