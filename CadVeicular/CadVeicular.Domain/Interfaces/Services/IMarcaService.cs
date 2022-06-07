using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Interfaces.Services
{
    public interface IMarcaService
    {
        Task<Marca> CadastrarMarca(Marca marca);

        Task<IEnumerable<Marca>> ListarMarca();
    }
}
