using CadVeicular.Domain.Interfaces.Repositories;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;

namespace CadVeicular.Domain.Service
{
    public class MarcaService : IMarcaService
    {
        private readonly IMarcaRepository _marcaRepository;

        public MarcaService(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

          public async Task<IEnumerable<Marca>> ListarMarca() 
         {
            return await _marcaRepository.ListarMarca();
          }

        public async Task<Marca> CadastrarMarca(Marca marca)
        {
            await _marcaRepository.CadastrarMarca(marca);
            await _marcaRepository.UnitOfWork.SaveChangesAsync();
            return marca;
        }

    }
}
