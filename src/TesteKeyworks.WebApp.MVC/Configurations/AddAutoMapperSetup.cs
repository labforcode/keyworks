using TesteKeyworks.Cadastros.Servicos.AutoMapper;

namespace TesteKeyworks.WebApp.MVC.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(Program));

            // Registering Mappings automatically only works if the
            // Automapper Profile classes are in ASP.NET project
            services.AddSingleton<AutoMapper.IConfigurationProvider>(AutoMapperConfiguration.RegisterMappings());
        }
    }
}
