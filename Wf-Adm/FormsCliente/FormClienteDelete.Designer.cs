﻿namespace Wf_Adm.FormsCliente
{
    partial class FormClienteDelete
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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lbxDeletar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(246, 348);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(140, 65);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lbxDeletar
            // 
            this.lbxDeletar.FormattingEnabled = true;
            this.lbxDeletar.ItemHeight = 20;
            this.lbxDeletar.Location = new System.Drawing.Point(126, 82);
            this.lbxDeletar.Name = "lbxDeletar";
            this.lbxDeletar.Size = new System.Drawing.Size(379, 244);
            this.lbxDeletar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete";
            // 
            // FormClienteDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxDeletar);
            this.Controls.Add(this.btnDeletar);
            this.Name = "FormClienteDelete";
            this.Text = "FormClienteDelete";
            this.Load += new System.EventHandler(this.FormClienteDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ListBox lbxDeletar;
        private System.Windows.Forms.Label label1;
    }
}