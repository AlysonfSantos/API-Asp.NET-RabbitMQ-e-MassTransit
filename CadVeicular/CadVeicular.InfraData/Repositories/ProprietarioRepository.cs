using CadVeicular.Domain.Interfaces.Repositories;
using CadVeicular.Domain.Models;
using CadVeicular.Infra.Data.EF;
using CadVeicular.Infra.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Infra.Data.Repositories
{
    public class ProprietarioRepository : BaseRepository<Proprietario>, IProprietarioRepository
    {
        private readonly CadastroVeicularContext _context;

        public ProprietarioRepository(CadastroVeicularContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Proprietario>> ListarProprietario() 
        {
               return await _context.Proprietarios.ToListAsync();
        }
        public async Task CadastrarProprietario(Proprietario proprietario)
        {
            await _context.AddAsync(proprietario);
        }
    }
}
