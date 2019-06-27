
using Framework.Dominio.Repositorio;
using Framework.Dominio.Servico;
using Microsoft.Extensions.DependencyInjection;
using ServicoLancamento.Repositorio;
using ServicoLancamento.Aplicacao;
using System;

namespace ServicoLancamento.IoC
{
    public class Injecto
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped<IContaCorrenteRepositorio, ContaCorrenteRepositorio>();
            services.AddScoped<ILancamentosRepositorio, LancamentosRepositorio>();
            services.AddScoped<IServicoLancamento, Servico>();

        }
    }
}
