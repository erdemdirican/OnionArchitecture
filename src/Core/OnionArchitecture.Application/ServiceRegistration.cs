using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Mapping;
using System.Reflection;

namespace OnionArchitecture.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assm = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assm));

            var config = new MapperConfiguration(x =>
            {
                x.AddProfile<GeneralMapping>();
            });
            services.AddScoped(x => config.CreateMapper());
        }
    }
}
