using CadVeicular.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Services.Interfaces
{
    public interface IVeiculoAppService
    {
        Task<IEnumerable<VeiculoViewModel>> ListarVeiculo();
        Task<VeiculoViewModel> CadastrarVeiculo(NovoVeiculoViewModel novoVeiculoViewMocel);
    }

}
