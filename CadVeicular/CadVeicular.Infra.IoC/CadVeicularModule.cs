using AutoMapper;
using CadVeicular.Application.Mapper;
using CadVeicular.Application.Services;
using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Domain.Interfaces.Repositories;
using CadVeicular.Domain.Interfaces.Services;
using CadVeicular.Domain.Service;
using CadVeicular.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace CadVeicular.Infra.IoC
{
    public static class CadVeicularModule
    {
        private static void ConfigureMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToViewModelProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper());
        }

        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services.ConfigureMapper();

            return services;
        }
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IVeiculoAppService, VeiculoAppService>();
            services.AddScoped<IMarcaAppService, MarcaAppService>();
            services.AddScoped<IProprietarioAppService, ProprietarioAppService>();
            services.AddScoped<IVeiculoRepository, VeiculoResitory>();
            services.AddScoped<IVeiculoService, VeiculoService>();
            services.AddScoped<IMarcaService, MarcaService>();
            services.AddScoped<IProprietarioService, ProprietarioService>();
            services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IProprietarioRepository, ProprietarioRepository>();

            return services;
        }
    }
}
