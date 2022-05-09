using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Adm.Services
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int quantidade { get; set; }
        public Produto(int idProduto, string nomeProduto, int quantidade)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return NomeProduto;
        }
    }
}
