using AutoMapper;
using CadVeicular.Application.ViewModel;
using CadVeicular.Domain.Models;

namespace CadVeicular.Application.Mapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Veiculo, VeiculoViewModel>();
            CreateMap<Proprietario, ProprietarioViewModel>();
            CreateMap<Marca, MarcaViewModel>();
        }
    }
}
