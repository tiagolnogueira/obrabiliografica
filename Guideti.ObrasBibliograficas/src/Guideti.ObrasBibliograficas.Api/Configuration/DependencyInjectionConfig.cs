using Guideti.ObrasBibliograficas.Application.Interfaces;
using Guideti.ObrasBibliograficas.Application.Notificacoes;
using Guideti.ObrasBibliograficas.Application.Services;
using Guideti.ObrasBibliograficas.Infra.Context;
using Guideti.ObrasBibliograficas.Infra.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Guideti.ObrasBibliograficas.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IAutorRepository, AutorRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IAutorService, AutorService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

            return services;
        }
    }
}