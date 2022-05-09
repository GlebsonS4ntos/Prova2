using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wf_Adm.Services;

namespace Wf_Adm.Repository
{
    public class PedidoRepository
    {
        public static List<Pedido> Pedidos = new();

        public void AddPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public List<Pedido> TodosPedidos()
        {
            return Pedidos;
        }

        public Pedido EncontrarPedido(int n)
        {
            return Pedidos[n];
        }

        public void Deletar(Pedido c)
        {
            Pedidos.Remove(c);
        }
    }
}
