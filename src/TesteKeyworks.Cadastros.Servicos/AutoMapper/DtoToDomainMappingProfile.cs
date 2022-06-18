using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            // Cliente
            CreateMap<ResponsavelDto, Responsavel>();
            CreateMap<TelefoneDto, Telefone>();
            CreateMap<ClienteDto, ComandoInsercaoCliente>()
                .ForMember(dtn => dtn.Telefone, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Responsavel, opt => opt.MapFrom(src => src));

            CreateMap<ClienteDto, ComandoAtualizacaoCliente>()
                .ForMember(dtn => dtn.Telefone, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Responsavel, opt => opt.MapFrom(src => src));

            CreateMap<int, ComandoExclusaoCliente>();
        }
    }
}
