using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            Estudante estudante = new Estudante();
            double totalEstudantes = Convert.ToDouble(estudante.totalDeEstudantes());
            double totalMeninos = Convert.ToDouble(estudante.totalDeEstudantesMeninos());
            double totalMeninas = Convert.ToDouble(estudante.totalDeEstudantesMeninas());
            double porcentagemMeninos = totalMeninos * 100 / totalEstudantes;
            double porcentagemMeninas = totalMeninas * 100 / totalEstudantes;
            labelEstu.Text = "Total de Estudantes: " + totalEstudantes.ToString();
            labelMeninos.Text = "Total de Meninos: " + porcentagemMeninos.ToString() + "%";
            labelMeninas.Text = "Total de Meninas: " + porcentagemMeninas.ToString() + "%";
        }

        private void labelEstu_MouseEnter(object sender, EventArgs e)
        {
            panelTotaldeEstu.BackColor = Color.Black;
            labelEstu.ForeColor = corPainelTotal;
        }

        private void labelEstu_MouseLeave(object sender, EventArgs e)
        {
            panelTotaldeEstu.BackColor = corPainelTotal;
            labelEstu.ForeColor = Color.Black;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Cyan;
            labelMeninos.ForeColor = corPainelMeninos;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPainelMeninos;
            labelMeninos.ForeColor= Color.Cyan;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.DeepPink;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninas.BackColor = corPainelMeninas;
            labelMeninas.ForeColor= Color.DeepPink;
        }
    }
}
