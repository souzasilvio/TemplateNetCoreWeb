using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(WebAppContext repositoryContext): base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var lista = await FindAllAsync();
            return lista.OrderBy(x => x.Nome);
        }

        public async Task<Cliente> GetByIdAsync(int codigo)
        {
            var item = await FindByConditionAync(o => o.Codigo.Equals(codigo));
            return item.DefaultIfEmpty(new Cliente())
                    .FirstOrDefault();
        }


        public async Task CreateAsync(Cliente cliente)
        {
            Create(cliente);
            await SaveAsync();
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            
            Update(cliente);
            await SaveAsync();
        }

        public async Task DeleteAsync(Cliente cliente)
        {
            Delete(cliente);
            await SaveAsync();
        }
    }
}
