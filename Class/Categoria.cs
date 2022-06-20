using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using ExemploCRUD.Conn;
using MySql.Data.MySqlClient;
using System.Data;

namespace ExemploCRUD.Class
{
    class Categoria
    {
        private int id;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public static void salvar(Categoria c)
        {
            try
            {
                //conectando ao bd
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO categoria VALUES (null, @descricao)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@descricao", c.Descricao);
                cmd.ExecuteNonQuery();

                Conexao.fecharConexao();                
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }

        public static void excluir(Categoria c)
        {
            try
            {
                //conectando ao bd
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM categoria WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();

                Conexao.fecharConexao();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public static void editar(Categoria c)
        {
            try
            {
                //conectando ao bd
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "UPDATE categoria SET descricao = @descricao WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@descricao", c.Descricao);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();

                Conexao.fecharConexao();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public DataTable listar(string query)
        {
            //conectando ao bd
            MySqlConnection conn = Conexao.obterConexao();
            //vamos receber o sql select
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                //adaptador para trazer a table mysql para uma lista datatable
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                //criação da lista datatable
                DataTable lista = new DataTable();
                //preenche a lista
                adp.Fill(lista);

                Conexao.fecharConexao();

                return lista;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

    }
}
