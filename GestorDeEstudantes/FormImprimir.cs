using MySql.Data.MySqlClient;
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
    public partial class FormImprimir : Form
    {
        public FormImprimir()
        {
            InitializeComponent();
        }
        Estudante estudante = new Estudante();

        public void preencheTabela(MySqlCommand comando)
        {
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn coluna = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.pegarAlunos(comando);
            coluna = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            coluna.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows = false;
            //labelTotalAlunos.Text = "Total de Alunos: " + dataGridViewLista.Rows.Count;
        }

        private void FormImprimir_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM 'estudantes'"));
            if (radioButtonN.Checked == true)
            {
                dateTimePickerIni.Enabled = false;
                dateTimePickerFim.Enabled = false;
            }
        }

        private void radioButtonN_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerIni.Enabled = false;
            dateTimePickerFim.Enabled = false;
        }

        private void radioButtonS_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerIni.Enabled = true;
            dateTimePickerFim.Enabled = true;
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            MySqlCommand comando;
            string busca;
            if (radioButtonS.Checked == true)
            {
                string dataInicial = dateTimePickerIni.Value.ToString("dd-MM-yyyy");
                string dataFinal = dateTimePickerFim.Value.ToString("dd-MM-yyyy");
                if (radioButtonMasc.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' AND genero = 'Masculino'";
                }
                else if (radioButtonFem.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' AND genero = 'Feminino'";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }
                comando = new MySqlCommand(busca);
                preencheTabela(comando);
            }
            else
            {
                if (radioButtonMasc.Checked)
                {
                    busca = "SELECT * FROM `estudantes`";
                }
                else if (radioButtonFem.Checked)
                {
                    busca = "SELECT * FROM `estudantes`";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes`";
                }
                comando = new MySqlCommand(busca);
                preencheTabela(comando);
            }
        }

        private void buttonImpri_Click(object sender, EventArgs e)
        {
            string camimho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +@"\lista_de_estudantes.txt";
            using (var escritor = new StreamWriter (camimho))
            {
                if (File.Exists (camimho) == false) 
                {
                    File.Create (camimho);
                }
                DateTime nascimento;
                for (int i = 0; i < dataGridViewLista.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewLista.Rows.Count; j++)
                    {
                        if (j == 3) 
                        {
                            nascimento = Convert.ToDateTime(dataGridViewLista.Rows[i].Cells[j].Value.ToString());
                            escritor.Write("\t" + nascimento.ToString("dd-MM-yyyy") + "\t" + "|");
                        }
                        else if (j == dataGridViewLista.Columns.Count - 2)
                        {
                            escritor.Write("\t" + dataGridViewLista.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        else
                        {
                            escritor.Write("\t" + dataGridViewLista.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        
                    }
                    escritor.WriteLine();
                }
                escritor.Close();
                MessageBox.Show("Dados salvos");
            }
        }
    }
}
