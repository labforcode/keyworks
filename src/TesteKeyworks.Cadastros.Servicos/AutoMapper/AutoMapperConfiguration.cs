using AutoMapper;

namespace TesteKeyworks.Cadastros.Servicos.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<DomainToViewModelMappingProfile>();
                configuration.AddProfile<DtoToDomainMappingProfile>();
            });
        }
    }
}
