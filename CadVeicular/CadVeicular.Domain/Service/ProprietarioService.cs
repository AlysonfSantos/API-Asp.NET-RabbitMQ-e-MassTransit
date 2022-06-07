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
    public class ProprietarioService : IProprietarioService
    {
        private readonly IProprietarioRepository _proprietarioRepository;

        public ProprietarioService(IProprietarioRepository proprietarioRepository)
        {
            _proprietarioRepository = proprietarioRepository;
        }
        public async Task<IEnumerable<Proprietario>> ListarProprietario() 
        {
              return await _proprietarioRepository.ListarProprietario();
        }
        public async Task<Proprietario> CadastrarProprietario(Proprietario proprietario)
        {
            await _proprietarioRepository.CadastrarProprietario(proprietario);
            await _proprietarioRepository.UnitOfWork.SaveChangesAsync();
            return proprietario;
        }
    }
}
