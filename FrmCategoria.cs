using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploCRUD.Class;

namespace ExemploCRUD
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.Descricao = txtDescricao.Text;

            Categoria.salvar(c);

            MessageBox.Show("Categoria cadastrada");


            limpar();
        }

        private void limpar()
        {
            txtDescricao.Focus();
            txtDescricao.Clear();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            
        }
    }
}
