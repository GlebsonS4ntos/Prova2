using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Adm.Services
{
    public class ItemCompra
    {
        public string NomeProduto { get; set; }
        public double QuatidadeEscolhida { get; set; }
        public double ValorProduto { get; set; }
        public ItemCompra(string nomeProduto, double quatidadeEscolhida, double valorProduto)
        {
            NomeProduto = nomeProduto;
            QuatidadeEscolhida = quatidadeEscolhida;
            ValorProduto = valorProduto;
        }

        public override string ToString()
        {
            return NomeProduto + " - " + QuatidadeEscolhida + " - " + ValorProduto.ToString("F2");
        }
    }
}
