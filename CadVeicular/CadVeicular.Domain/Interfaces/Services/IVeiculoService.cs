using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Interfaces.Services
{
    public interface IVeiculoService
    {
        Task<Veiculo> CadastrarVeiculo(Veiculo Veiculo);

        Task<IEnumerable<Veiculo>> ListarVeiculo();
    }
}
