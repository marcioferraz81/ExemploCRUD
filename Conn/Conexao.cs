using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ExemploCRUD.Conn
{
    class Conexao
    {
        //conexão com BD
        private static MySqlConnection conn = null;

        //método para estabelecer conexão
        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection("Server=localhost;Database=aula;Uid=root;Pwd=usbw;");
            try
            {
                conn.Open();
                //MessageBox.Show("Conectado com sucesso");
            }
            catch(MySqlException e)
            {
                conn = null;
                //MessageBox.Show(e + " não foi possível estabelecer conexão");
            }
            return conn;
        }//obterConexao

        public static void fecharConexao()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }//fecharConexao
    }
}
