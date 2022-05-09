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
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public Produto(int idProduto, string nomeProduto, int quantidade, double valor)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Valor = valor;
        }
        public Produto(string nomeProduto, int quantidade, double valor)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            Valor = valor;
        }

        public override string ToString()
        {
            return NomeProduto + " - " + Valor.ToString("F2") +"(Unidade)";
        }
    }
}
