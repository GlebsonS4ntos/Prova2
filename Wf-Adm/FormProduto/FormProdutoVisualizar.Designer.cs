namespace Wf_Adm.FormProduto
{
    partial class FormProdutoVisualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxProdutos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos: ";
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 20;
            this.lbxProdutos.Location = new System.Drawing.Point(152, 111);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(483, 284);
            this.lbxProdutos.TabIndex = 2;
            // 
            // FormProdutoVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProdutos);
            this.Name = "FormProdutoVisualizar";
            this.Text = "FormProdutoVisualizar";
            this.Load += new System.EventHandler(this.FormProdutoVisualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxProdutos;
    }
}