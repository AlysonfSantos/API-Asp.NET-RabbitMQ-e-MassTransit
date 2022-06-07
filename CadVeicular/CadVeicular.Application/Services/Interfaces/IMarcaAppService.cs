using CadVeicular.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Services.Interfaces
{
    public interface IMarcaAppService
    {
        Task<MarcaViewModel> CadastrarMarca(NovaMarcaViewModel novaMarcaViewModel);

        Task<IEnumerable<MarcaViewModel>> ListarMarca();
    }
}
