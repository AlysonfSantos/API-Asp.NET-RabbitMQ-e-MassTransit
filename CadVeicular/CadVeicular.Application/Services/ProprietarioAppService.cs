using AutoMapper;
using CadVeicular.Application.Messages;
using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Application.ViewModel;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;
using MassTransit;

namespace CadVeicular.Application.Services
{
    public class ProprietarioAppService : IProprietarioAppService
    {
        private readonly IProprietarioService _proprietarioService;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publisher;
        public ProprietarioAppService(IProprietarioService proprietarioService, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _proprietarioService = proprietarioService;
            _mapper = mapper;
            _publisher = publishEndpoint;
        }

        public async Task<IEnumerable<ProprietarioViewModel>> ListarProprietario()

        {
            var proprietario = await _proprietarioService.ListarProprietario();
            return _mapper.Map<IEnumerable<ProprietarioViewModel>>(proprietario);
        }
        public async Task<ProprietarioViewModel> CadastrarProprietario(NovoProprietarioViewModel novoProprietarioViewModel)
        {
            var novoProprietario = new Proprietario(novoProprietarioViewModel.Nome,
                novoProprietarioViewModel.E_mail,
                novoProprietarioViewModel.Documento,
                novoProprietarioViewModel.Status,
                novoProprietarioViewModel.Cidade,
                novoProprietarioViewModel.CEP,
                novoProprietarioViewModel.Estado,
                novoProprietarioViewModel.Numero,
                novoProprietarioViewModel.Loradouro);

            var ProprietarioCadastrado = await _proprietarioService.CadastrarProprietario(novoProprietario);

            return _mapper.Map<ProprietarioViewModel>(ProprietarioCadastrado);

        }


    }
}
