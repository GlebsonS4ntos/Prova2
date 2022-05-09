using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wf_Adm.Repository;

namespace Wf_Adm.FormProduto
{
    public partial class FormProdutoCadastrar : Form
    {
        public FormProdutoCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoRepository pr = new();
                pr.AddProduto(new(txtNome.Text, int.Parse(txtQuantidade.Text), 
                    double.Parse(txtValor.Text)));
                MessageBox.Show("Produto Cadastrado com sucesso !!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
