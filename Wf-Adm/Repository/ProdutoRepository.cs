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

        public void AddProduto(Produto p)
        {
            p.IdProduto = Produtos.Count + 1;
            Produtos.Add(p);
        }

        public List<Produto> TodosProdutos()
        {
            return Produtos;
        }
        public void ProdutosCadastrados()
        {
            if (Produtos.Count == 0)
            {
                AddProduto(new(Produtos.Count + 1, "Feijão", 300, 5.40));
                AddProduto(new(Produtos.Count + 1, "Arroz", 100, 3.20));
                AddProduto(new(Produtos.Count + 1, "Macarrão", 300,4.00));
                AddProduto(new(Produtos.Count + 1, "Miojo", 700,0.75));
            }
        }

        public Produto EncontrarProduto(int n)
        {
            return Produtos[n];
        }

        public void Deletar(Produto c)
        {
            Produtos.Remove(c);
        }
    }
}
