using AutoMapper;
using CadVeicular.Application.Messages;
using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Application.ViewModel;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;
using MassTransit;

namespace CadVeicular.Application.Services
{
    public class VeiculoAppService : IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publisher;


        public VeiculoAppService(IVeiculoService veiculoService, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _veiculoService = veiculoService;
            _mapper = mapper;
            _publisher = publishEndpoint;
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

            await _publisher.Publish<CustomerCreatedVeiculoEvent>(new 
            {
                Id = veiculoCadastrado.Id.ToString(),
             RENAVAM = veiculoCadastrado.RENAVAM,
             Modelo =veiculoCadastrado.Modelo,
             AnoFabricacao = veiculoCadastrado.AnoFabricacao,
             AnoModelo = veiculoCadastrado.AnoModelo,
             Quilometragem = veiculoCadastrado.Quilometragem.ToString(),
             Valor =veiculoCadastrado.Valor.ToString(),
             Status =veiculoCadastrado.Status.ToString(),
             ProprietarioId =veiculoCadastrado.ProprietarioId.ToString(),
             MarcaId = veiculoCadastrado.MarcaId.ToString(),
            });
         

            return _mapper.Map<VeiculoViewModel>(veiculoCadastrado);

        }
    }
}
