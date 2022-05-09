using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wf_Adm.Services
{
    public class Cliente
    {
        public Int64 Cpf { get; set; }
        public string Nome { get; }

        public Cliente(Int64 cpf, string nome)
        {
            Cpf = cpf;
            Nome = nome;
        }

        public override string ToString()
        {
            return Cpf + " - " + Nome;
        }
    }
}
