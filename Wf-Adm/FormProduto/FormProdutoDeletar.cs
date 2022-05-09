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
    public partial class FormProdutoDeletar : Form
    {
        public FormProdutoDeletar()
        {
            InitializeComponent();
        }

        private void FormProdutoDeletar_Load(object sender, EventArgs e)
        {
            ProdutoRepository cr = new();
            cr.ProdutosCadastrados();
            cr.TodosProdutos().ForEach(c => lbxProdutos.Items.Add(c));
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ProdutoRepository cr = new();
            cr.Deletar(cr.EncontrarProduto(lbxProdutos.SelectedIndex));
            MessageBox.Show("Produto Deletado com sucesso !!");
            lbxProdutos.Items.Clear();
            cr.TodosProdutos().ForEach(c => lbxProdutos.Items.Add(c));
        }
    }
}
