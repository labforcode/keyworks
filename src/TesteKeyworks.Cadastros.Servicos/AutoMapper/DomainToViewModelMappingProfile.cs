using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
