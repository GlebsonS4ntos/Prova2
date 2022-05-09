using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wf_Adm.Services;

namespace Wf_Adm.Repository
{
    public class ProdutoRepository
    {
        public static List<Produto> Produtos = new List<Produto>();

        public void AddProduto(Produto cliente)
        {
            Produtos.Add(cliente);
        }

        public List<Produto> TodosProdutos()
        {
            return Produtos;
        }

        public void ProdutosCadastrados()
        {
            if (Produtos.Count == 0)
            {
                AddProduto(new(Produtos.Count + 1, "Sla", 40));
                AddProduto(new(Produtos.Count + 1, "Sla1", 50));
                AddProduto(new(Produtos.Count + 1, "Sla2", 60));
            }
        }
    }
}
