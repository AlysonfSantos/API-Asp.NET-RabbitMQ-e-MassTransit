using CadVeicular.Domain.Interfaces.Repositories;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _viculoRepository;

        public VeiculoService(IVeiculoRepository viculoRepository)
        {
            _viculoRepository = viculoRepository;
        }

        public async Task<IEnumerable<Veiculo>> ListarVeiculo()
        {
            return await _viculoRepository.LiscarVeiculo();
        }

        public async Task<Veiculo> CadastrarVeiculo(Veiculo veiculo)
        {
            await _viculoRepository.CadastrarVeiculo(veiculo);
            await _viculoRepository.UnitOfWork.SaveChangesAsync();
            return veiculo;
        }
    }
}
