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
using ExemploCRUD.Conn;

namespace ExemploCRUD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

       

        private void OpcaoSair_Click(object sender, EventArgs e)
        {
            string msg = "Deseja realmente sair?";
            string titulo = "Está de saída?";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;

            DialogResult dialogo = MessageBox.Show(msg, titulo, btns);

            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Conexao.obterConexao();
        }

        private void OpcaoCadCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCategoria>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCategoria>().First().Focus();
            }
            else
            {
                FrmCategoria frm = new FrmCategoria();
                frm.Show();
            }
        }

        private void OpcaoListarCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmListarCategoria>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmListarCategoria>().First().Focus();
            }
            else
            {
                FrmListarCategoria frm = new FrmListarCategoria();
                frm.Show();
            }
        }

        private void OpcaoConsultarPorID_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmConsultarPorID>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmConsultarPorID>().First().Focus();
            }
            else
            {
                FrmConsultarPorID frm = new FrmConsultarPorID();
                frm.Show();
            }
        }

    }
}
