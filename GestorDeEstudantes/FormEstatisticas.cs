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
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotaldeEstu.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void panelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.White;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void panelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPainelMeninas
            label
        }

        private void panelMeninos_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelMeninos_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelTotaldeEstu_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelTotaldeEstu_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
