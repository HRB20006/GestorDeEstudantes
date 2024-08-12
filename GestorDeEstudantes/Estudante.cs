using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    internal class Estudante
    {
        MeuNamcoDeDados meuNamcoDeDados = new MeuNamcoDeDados();
        public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento,
    string telefone, string genero, string endereco, MemoryStream foto)
        {
            // Removido `id` da lista de parâmetros a serem alterados.
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", meuNamcoDeDados.getConexao);
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            // Incluído o método ToArray() em foto.
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();
            meuNamcoDeDados.abrirconexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuNamcoDeDados.fecharconexao();
                return true;
            }
            else
            {
                meuNamcoDeDados.fecharconexao();
                return false;
            }
        }
        public DataTable pegarAlunos(MySqlCommand comando)
        {
            comando.Connection = meuNamcoDeDados.getConexao;
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            return dt;
        }

        public bool atualizarEstudante(int id, string nome, string sobrenome, DateTime nascimento,
string telefone, string genero, string endereco, MemoryStream foto)
        {
            // Removido `id` da lista de parâmetros a serem alterados.
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `nome`=@nome,`sobrenome`=@sobrenome,`nascimento`=@nascimento,`genero`=@genero,`telefone`=@telefone,`endereco`=@endereco,`foto`=@foto WHERE `id`=@id", meuNamcoDeDados.getConexao);
            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            // Incluído o método ToArray() em foto.
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();
            meuNamcoDeDados.abrirconexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuNamcoDeDados.fecharconexao();
                return true;
            }
            else
            {
                meuNamcoDeDados.fecharconexao();
                return false;
            }
        }
        public bool apagarEstudante(int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM `estudantes` WHERE `id`= @id");
            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            meuNamcoDeDados.abrirconexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuNamcoDeDados.fecharconexao();
                return true;
            }
            else
            {
                meuNamcoDeDados.fecharconexao();
                return false;
            }
        }
        public string fazerContagem(string pesquisa)
        {
            MySqlCommand Comando = new MySqlCommand(pesquisa, meuNamcoDeDados.getConexao);
            meuNamcoDeDados.abrirconexao();
            string contagem = Comando.ExecuteScalar().ToString();
            meuNamcoDeDados.fecharconexao();
            return contagem;
        }
        public string totalDeEstudantes()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes`");
        }
        public string totalDeEstudantesMeninos()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes` WHERE `genero`='Masculino'");
        }
        public string totalDeEstudantesMeninas()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes` WHERE `genero`='Feminino'");
        }
    }
}
