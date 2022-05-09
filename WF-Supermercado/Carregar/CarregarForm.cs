using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wf_Adm.Repository;
using Wf_Adm.Services;

namespace WF_Supermercado
{
    public class CarregarForm
    {
        public List<Cliente> CarregarFormClientes()
        {
            ClienteRepository clienteRepository = new();
            List<Cliente> c = clienteRepository.TodosClientes();
            clienteRepository.ClientesCadastrados();

            return c;
        }
        public List<Produto> CarregarFormProdutos()
        {
            ProdutoRepository produtoRepository = new();
            List<Produto> p = produtoRepository.TodosProdutos();
            produtoRepository.ProdutosCadastrados();

            return p;
        }
    }
}
