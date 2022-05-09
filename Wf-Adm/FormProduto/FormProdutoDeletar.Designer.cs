namespace Wf_Adm.FormProduto
{
    partial class FormProdutoDeletar
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delete: ";
            // 
            // lbxProdutos
            // 
            this.lbxProdutos.FormattingEnabled = true;
            this.lbxProdutos.ItemHeight = 20;
            this.lbxProdutos.Location = new System.Drawing.Point(76, 101);
            this.lbxProdutos.Name = "lbxProdutos";
            this.lbxProdutos.Size = new System.Drawing.Size(437, 244);
            this.lbxProdutos.TabIndex = 4;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(220, 361);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(147, 59);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // FormProdutoDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProdutos);
            this.Name = "FormProdutoDeletar";
            this.Text = "FormProdutoDeletar";
            this.Load += new System.EventHandler(this.FormProdutoDeletar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxProdutos;
        private System.Windows.Forms.Button btnDeletar;
    }
}