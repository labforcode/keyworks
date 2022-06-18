using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis;
using TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;

namespace TesteKeyworks.Cadastros.Servicos.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {

            // Material
            CreateMap<MaterialDto, Material>();
            CreateMap<MaterialDto, ComandoAtualizacaoMaterial>();
            CreateMap<MaterialDto, ComandoInsercaoMaterial>();
            CreateMap<int, ComandoExclusaoMaterial>();

            // Cliente
            CreateMap<ResponsavelDto, Responsavel>();
            CreateMap<TelefoneDto, Telefone>();
            CreateMap<ClienteDto, ComandoInsercaoCliente>()
                .ForMember(dtn => dtn.Materiais, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Telefone, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Responsavel, opt => opt.MapFrom(src => src));

            CreateMap<ClienteDto, ComandoAtualizacaoCliente>()
                .ForMember(dtn => dtn.Materiais, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Telefone, opt => opt.MapFrom(src => src))
                .ForMember(dtn => dtn.Responsavel, opt => opt.MapFrom(src => src));

            CreateMap<int, ComandoExclusaoCliente>();
        }
    }
}
