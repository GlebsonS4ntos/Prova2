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
    public partial class FormProdutoVisualizar : Form
    {
        public FormProdutoVisualizar()
        {
            InitializeComponent();
        }

        private void FormProdutoVisualizar_Load(object sender, EventArgs e)
        {
            ProdutoRepository pr = new();
            pr.ProdutosCadastrados();
            pr.TodosProdutos().ForEach(c => lbxProdutos.Items.Add(c));
        }
    }
}
