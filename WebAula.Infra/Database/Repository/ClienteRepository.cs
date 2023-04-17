using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAula.Domain.Models;
using WebAula.Domain.Repository;
using WebAula.Infra.Database;

namespace WebAula.Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _dbContext;

        public ClienteRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Cliente> GetClientes()
        {

            return _dbContext.Clientes.ToList();
        }

        public Cliente? GetClienteById(int id)
        {

            return _dbContext.Clientes.Find(id);

        }

        public void InsertCliente(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();

        }

        public void UpdateCliente(Cliente cliente)
        {

            _dbContext.Entry(cliente).State = EntityState.Modified;
            _dbContext.SaveChanges();

        }

        public void DeleteCliente(int id)
        {
            var cliente = _dbContext.Clientes.Find(id);
            _dbContext.Clientes.Remove(cliente);
            _dbContext.SaveChanges();

        }

    }
}
