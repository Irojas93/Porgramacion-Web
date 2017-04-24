using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class ClienteNego
    {

        ClienteRepo clienteRepo = new ClienteRepo();
        public void GuardarCliente(ClienteDom clienteDom)
        {    
                    
            clienteRepo.GuardarCliente(clienteDom);
        }

        public void Modificar(int clienteId, ClienteDom clienteDom)
        {
            clienteRepo.Modificar(clienteId,clienteDom);
        }

        public DataTable ListaClientes()
        {
            
            return clienteRepo.ListCliente();
        }

        public DataTable LlenarGrilla(int clienteId)
        {
            
            return clienteRepo.LlenarCampos(clienteId);
        }
    }
}
