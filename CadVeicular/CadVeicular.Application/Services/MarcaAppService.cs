using AutoMapper;
using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Application.ViewModel;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Services
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMarcaService _marcaService;
        private readonly IMapper _mapper;


        public MarcaAppService(IMarcaService marcaService, IMapper mapper)
        {
            _marcaService = marcaService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MarcaViewModel>> ListarMarca()

        {
            var marca = await _marcaService.ListarMarca();
            return _mapper.Map<IEnumerable<MarcaViewModel>>(marca);
        }
        public async Task<MarcaViewModel> CadastrarMarca(NovaMarcaViewModel novaMarcaViewModel)
        {
            var novaMarca = new Marca(novaMarcaViewModel.Nome, novaMarcaViewModel.Status);
            var marcaCadastrada = await _marcaService.CadastrarMarca(novaMarca);
            return _mapper.Map<MarcaViewModel>(marcaCadastrada);
        }
    }
}
