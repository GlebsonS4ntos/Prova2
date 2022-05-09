namespace Wf_Adm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClienteRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClienteVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutosAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutosRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutosAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutosVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienteAdicionar,
            this.MenuClienteRemover,
            this.menuClienteAtualizar,
            this.MenuClienteVisualizar});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(75, 24);
            this.menuClientes.Text = "Clientes";
            // 
            // menuClienteAdicionar
            // 
            this.menuClienteAdicionar.Name = "menuClienteAdicionar";
            this.menuClienteAdicionar.Size = new System.Drawing.Size(224, 26);
            this.menuClienteAdicionar.Text = "Adicionar";
            this.menuClienteAdicionar.Click += new System.EventHandler(this.MenuClienteAdicionar_Click);
            // 
            // MenuClienteRemover
            // 
            this.MenuClienteRemover.Name = "MenuClienteRemover";
            this.MenuClienteRemover.Size = new System.Drawing.Size(224, 26);
            this.MenuClienteRemover.Text = "Remover";
            // 
            // menuClienteAtualizar
            // 
            this.menuClienteAtualizar.Name = "menuClienteAtualizar";
            this.menuClienteAtualizar.Size = new System.Drawing.Size(224, 26);
            this.menuClienteAtualizar.Text = "Atualizar";
            // 
            // MenuClienteVisualizar
            // 
            this.MenuClienteVisualizar.Name = "MenuClienteVisualizar";
            this.MenuClienteVisualizar.Size = new System.Drawing.Size(224, 26);
            this.MenuClienteVisualizar.Text = "Visualizar Clientes";
            this.MenuClienteVisualizar.Click += new System.EventHandler(this.MenuClienteVisualizar_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProdutosAdicionar,
            this.menuProdutosRemover,
            this.menuProdutosAtualizar,
            this.menuProdutosVisualizar});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // menuProdutosAdicionar
            // 
            this.menuProdutosAdicionar.Name = "menuProdutosAdicionar";
            this.menuProdutosAdicionar.Size = new System.Drawing.Size(211, 26);
            this.menuProdutosAdicionar.Text = "Adicionar";
            // 
            // menuProdutosRemover
            // 
            this.menuProdutosRemover.Name = "menuProdutosRemover";
            this.menuProdutosRemover.Size = new System.Drawing.Size(211, 26);
            this.menuProdutosRemover.Text = "Remover";
            // 
            // menuProdutosAtualizar
            // 
            this.menuProdutosAtualizar.Name = "menuProdutosAtualizar";
            this.menuProdutosAtualizar.Size = new System.Drawing.Size(211, 26);
            this.menuProdutosAtualizar.Text = "Atualizar";
            // 
            // menuProdutosVisualizar
            // 
            this.menuProdutosVisualizar.Name = "menuProdutosVisualizar";
            this.menuProdutosVisualizar.Size = new System.Drawing.Size(211, 26);
            this.menuProdutosVisualizar.Text = "Visualizar Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuClienteAdicionar;
        private System.Windows.Forms.ToolStripMenuItem MenuClienteRemover;
        private System.Windows.Forms.ToolStripMenuItem menuClienteAtualizar;
        private System.Windows.Forms.ToolStripMenuItem MenuClienteVisualizar;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosAdicionar;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosRemover;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosAtualizar;
        private System.Windows.Forms.ToolStripMenuItem menuProdutosVisualizar;
    }
}
