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
    public class VeiculoResitory : BaseRepository<Veiculo>, IVeiculoRepository
    {
        private readonly CadastroVeicularContext _context;

        public VeiculoResitory(CadastroVeicularContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Veiculo>> LiscarVeiculo()
        {
            return await _context.Veiculos.ToListAsync();
        }

        public async Task CadastrarVeiculo(Veiculo veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
        }
    }
}
