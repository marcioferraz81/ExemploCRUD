using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using ExemploCRUD.Class;
using MySql.Data.MySqlClient;


namespace ExemploCRUD
{
    public partial class FrmConsultarPorID : Form
    {
        public FrmConsultarPorID()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text != "")
                {
                    Categoria cat = new Categoria();
                    string id = txt_id.Text;
                    string query = "SELECT * FROM categoria WHERE id = " + id + "";
                    DataRowCollection res = cat.listar(query).Rows;

                    lbl_mostrarDescricao.Text = res.Count > 0 ? res[0]["descricao"].ToString() : "Não encontrado";
                }
                else
                {
                    lbl_mostrarDescricao.Text = "Informe o ID";
                }

                txt_id.Focus();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
