using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            // Cliente
            CreateMap<ClienteDto, ComandoInsercaoCliente>();
            CreateMap<ClienteDto, ComandoAtualizacaoCliente>();
            CreateMap<ClienteDto, ComandoExclusaoCliente>();
        }
    }
}
