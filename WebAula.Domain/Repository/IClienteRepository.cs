using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAula.Domain.Models;

namespace WebAula.Domain.Repository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetClientes();
        Cliente? GetClienteById(int id);
        void InsertCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(int id);
    }
}
