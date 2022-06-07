using AutoMapper;
using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Application.ViewModel;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;

namespace CadVeicular.Application.Services
{
    public class VeiculoAppService : IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IMapper _mapper;


        public VeiculoAppService(IVeiculoService veiculoService, IMapper mapper)
        {
            _veiculoService = veiculoService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<VeiculoViewModel>> ListarVeiculo()

        {
            var veiculo = await _veiculoService.ListarVeiculo();
            return _mapper.Map<IEnumerable<VeiculoViewModel>>(veiculo);
        }
        public async Task<VeiculoViewModel> CadastrarVeiculo(NovoVeiculoViewModel novoVeiculoViewModel)
        {
            var novoVeiculo = new Veiculo(
                novoVeiculoViewModel.RENAVAM,
                novoVeiculoViewModel.Modelo,
                novoVeiculoViewModel.AnoFabricacao,
                novoVeiculoViewModel.AnoModelo,
                novoVeiculoViewModel.Quilometragem,
                novoVeiculoViewModel.Valor,
                novoVeiculoViewModel.Status,
                novoVeiculoViewModel.ProprietarioId,
                novoVeiculoViewModel.MarcaId);

            var veiculoCadastrado = await _veiculoService.CadastrarVeiculo(novoVeiculo);
            return _mapper.Map<VeiculoViewModel>(veiculoCadastrado);

        }
    }
}
