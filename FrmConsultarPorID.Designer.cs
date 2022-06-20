
namespace ExemploCRUD
{
    partial class FrmConsultarPorID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_mostrarDescricao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(38, 87);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(79, 16);
            this.lbl_descricao.TabIndex = 6;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(39, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(106, 20);
            this.txt_id.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(35, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(110, 20);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Informe o ID";
            // 
            // lbl_mostrarDescricao
            // 
            this.lbl_mostrarDescricao.AutoSize = true;
            this.lbl_mostrarDescricao.Location = new System.Drawing.Point(38, 109);
            this.lbl_mostrarDescricao.Name = "lbl_mostrarDescricao";
            this.lbl_mostrarDescricao.Size = new System.Drawing.Size(144, 13);
            this.lbl_mostrarDescricao.TabIndex = 7;
            this.lbl_mostrarDescricao.Text = "aqui vai aparecer o resultado";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(41, 145);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(141, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "pesquisar...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmConsultarPorID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 193);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lbl_mostrarDescricao);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "FrmConsultarPorID";
            this.Text = "Consultar por ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_mostrarDescricao;
        private System.Windows.Forms.Button btnPesquisar;
    }
}