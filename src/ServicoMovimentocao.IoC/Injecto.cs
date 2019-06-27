using Framework.Dominio.Repositorio;
using Framework.Dominio.Servico;
using ServicoMovimentocao.Repositorio;
using ServicoMovimentocao.Aplicacao;
using Microsoft.Extensions.DependencyInjection;

namespace ServicoMovimentocao.IoC
{
    public class Injecto
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            services.AddScoped<IContaCorrenteRepositorio, Repositorio.ContaCorrenteRepositorio>();
            services.AddScoped<ILancamentosRepositorio, LancamentosRepositorio>();
            services.AddTransient<IServicoMovimentocao, Servico>();

        }
    }
}
