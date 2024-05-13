using MySql.Data.MySqlClient;
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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MeuNamcoDeDados meuNamcoDeDados = new MeuNamcoDeDados();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();
            MySqlCommand comandSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`= @usuario AND `senha`= @senha", meuNamcoDeDados.getConexao);
            comandSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxUser.Text;
            comandSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;
            mySqlDataAdapter.SelectCommand = comandSql;
            mySqlDataAdapter.Fill(tabelaDeDados);
            if (tabelaDeDados.Rows.Count > 0)
            {
                MessageBox.Show("SIM");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
