using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wf_Adm.Services;

namespace Wf_Adm.Repository
{
    public class ClienteRepository
    {

        public List<Cliente> Clientes = new();

        public void AddCliente(Cliente cliente)
        {
            ClientesCadastrados();
            Clientes.Add(cliente);
        }

        public List<Cliente> TodosClientes()
        {
            return Clientes;
        }

        public void ClientesCadastrados()
        {
            if (Clientes.Count == 0) 
            {
                AddCliente(new(2352345, "Maria"));
                AddCliente(new(2352345, "Joao"));
                AddCliente(new(2352345, "Valentina"));
            }
        }

    }
}
