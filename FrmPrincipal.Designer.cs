
namespace ExemploCRUD
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoCadCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoListarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpcaoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoConsultarPorID = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategoria});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCategoria
            // 
            this.MenuCategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcaoCadCategoria,
            this.OpcaoListarCategoria,
            this.OpcaoConsultarPorID,
            this.toolStripSeparator1,
            this.OpcaoSair});
            this.MenuCategoria.Name = "MenuCategoria";
            this.MenuCategoria.Size = new System.Drawing.Size(70, 20);
            this.MenuCategoria.Text = "Categoria";
            // 
            // OpcaoCadCategoria
            // 
            this.OpcaoCadCategoria.Name = "OpcaoCadCategoria";
            this.OpcaoCadCategoria.Size = new System.Drawing.Size(180, 22);
            this.OpcaoCadCategoria.Text = "Cadastrar";
            this.OpcaoCadCategoria.Click += new System.EventHandler(this.OpcaoCadCategoria_Click);
            // 
            // OpcaoListarCategoria
            // 
            this.OpcaoListarCategoria.Name = "OpcaoListarCategoria";
            this.OpcaoListarCategoria.Size = new System.Drawing.Size(180, 22);
            this.OpcaoListarCategoria.Text = "Listar";
            this.OpcaoListarCategoria.Click += new System.EventHandler(this.OpcaoListarCategoria_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // OpcaoSair
            // 
            this.OpcaoSair.Name = "OpcaoSair";
            this.OpcaoSair.Size = new System.Drawing.Size(180, 22);
            this.OpcaoSair.Text = "Sair";
            this.OpcaoSair.Click += new System.EventHandler(this.OpcaoSair_Click);
            // 
            // OpcaoConsultarPorID
            // 
            this.OpcaoConsultarPorID.Name = "OpcaoConsultarPorID";
            this.OpcaoConsultarPorID.Size = new System.Drawing.Size(180, 22);
            this.OpcaoConsultarPorID.Text = "Consultar por ID";
            this.OpcaoConsultarPorID.Click += new System.EventHandler(this.OpcaoConsultarPorID_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "CRUD C# e MySQL";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem OpcaoCadCategoria;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpcaoSair;
        private System.Windows.Forms.ToolStripMenuItem OpcaoListarCategoria;
        private System.Windows.Forms.ToolStripMenuItem OpcaoConsultarPorID;
    }
}

