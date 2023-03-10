using Dev.IO.App.Extensions;
using Dev.IO.Business.Intefaces;
using Dev.IO.Business.Interfaces;
using Dev.IO.Business.Notificacoes;
using Dev.IO.Business.Services;
using Dev.IO.Data.Context;
using Dev.IO.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace Dev.IO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
