using CadVeicular.Domain.Interfaces.Repositories;
using CadVeicular.Domain.Models;
using CadVeicular.Infra.Data.EF;
using CadVeicular.Infra.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CadVeicular.Infra.Data.Repositories
{
    public class MarcaRepository : BaseRepository<Marca>, IMarcaRepository
    {
        private readonly CadastroVeicularContext _context;

        public MarcaRepository(CadastroVeicularContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Marca>> ListarMarca()
        {
              return await _context.Marcas.ToListAsync();
        }
        public async Task CadastrarMarca(Marca marca)
        {
            await _context.Marcas.AddAsync(marca);
        }
    }
}
