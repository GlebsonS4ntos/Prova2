using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Adm.Services
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public List<ItemCompra> Itens { get; }
        public double ValorCompra { get; set; } = 0;

        public Pedido(string nomeCliente, List<ItemCompra> itens)
        {
            NomeCliente = nomeCliente;
            Itens = itens;
            ValorCompra = ValorCompraTotal();
        }

        public double ValorCompraTotal()
        {
            Itens.ForEach(i => ValorCompra += (i.QuatidadeEscolhida * i.ValorProduto));
            return ValorCompra;
        }

        public override string ToString()
        {
            return NomeCliente + " - " + ValorCompra.ToString("F2");
        }
    }
}
