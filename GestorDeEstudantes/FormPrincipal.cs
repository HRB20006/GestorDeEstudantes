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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.Show(this);
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudantes formListarEstudantes = new FormListarEstudantes();
            formListarEstudantes.Show(this);
        }

        private void estatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstatisticas formEstatisticas = new FormEstatisticas();
            formEstatisticas.Show(this);
        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtualizarApagarEstudante formAtualizarApagarEstudante = new FormAtualizarApagarEstudante();
            formAtualizarApagarEstudante.Show(this);
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarAlunos formGerenciarAlunos = new FormGerenciarAlunos();
            formGerenciarAlunos.Show(this);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
