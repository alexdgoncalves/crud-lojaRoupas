
namespace clothes_store
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDosLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarUmLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUmLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirUmLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDosLivroToolStripMenuItem,
            this.pesquisarUmLivroToolStripMenuItem,
            this.editarUmLivroToolStripMenuItem,
            this.excluirUmLivroToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastroDosLivroToolStripMenuItem
            // 
            this.cadastroDosLivroToolStripMenuItem.Name = "cadastroDosLivroToolStripMenuItem";
            this.cadastroDosLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDosLivroToolStripMenuItem.Text = "cadastro";
            this.cadastroDosLivroToolStripMenuItem.Click += new System.EventHandler(this.cadastroDosLivroToolStripMenuItem_Click);
            // 
            // pesquisarUmLivroToolStripMenuItem
            // 
            this.pesquisarUmLivroToolStripMenuItem.Name = "pesquisarUmLivroToolStripMenuItem";
            this.pesquisarUmLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarUmLivroToolStripMenuItem.Text = "roupas";
            this.pesquisarUmLivroToolStripMenuItem.Click += new System.EventHandler(this.pesquisarUmLivroToolStripMenuItem_Click);
            // 
            // editarUmLivroToolStripMenuItem
            // 
            this.editarUmLivroToolStripMenuItem.Name = "editarUmLivroToolStripMenuItem";
            this.editarUmLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUmLivroToolStripMenuItem.Text = "editar";
            this.editarUmLivroToolStripMenuItem.Click += new System.EventHandler(this.editarUmLivroToolStripMenuItem_Click);
            // 
            // excluirUmLivroToolStripMenuItem
            // 
            this.excluirUmLivroToolStripMenuItem.Name = "excluirUmLivroToolStripMenuItem";
            this.excluirUmLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirUmLivroToolStripMenuItem.Text = "excluir";
            this.excluirUmLivroToolStripMenuItem.Click += new System.EventHandler(this.excluirUmLivroToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loja de roupas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDosLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarUmLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUmLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirUmLivroToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

