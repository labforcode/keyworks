using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Materiais;
using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Materiais;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Materiais
{
    public class MaterialServico : IMaterialServico
    {
        private readonly IMapper _mapper;
        private readonly IComandoHandlerMaterial _comandoHandlerMaterial;
        private readonly IMaterialRepositorio _materialRepositorio;

        public MaterialServico(IMapper mapper,
                              IComandoHandlerMaterial comandoHandlerMaterial,
                              IMaterialRepositorio materialRepositorio)
        {
            _mapper = mapper;
            _comandoHandlerMaterial = comandoHandlerMaterial;
            _materialRepositorio = materialRepositorio;
        }

        public void Adicionar(MaterialDto material)
        {
            var comando = _mapper.Map<ComandoInsercaoMaterial>(material);
            _comandoHandlerMaterial.Handler(comando);
        }

        public void Atualizar(MaterialDto material)
        {
            var comando = _mapper.Map<ComandoAtualizacaoMaterial>(material);
            _comandoHandlerMaterial.Handler(comando);
        }

        public void Excluir(int codigo)
        {
            var comando = _mapper.Map<ComandoExclusaoMaterial>(codigo);
            _comandoHandlerMaterial.Handler(comando);
        }

        public Task<MaterialViewModel> ObterMaterialAsync(int codigo)
        {
            return Task.FromResult(_mapper.Map<MaterialViewModel>(_materialRepositorio.ObterMaterialAsync(codigo)));
        }

        public Task<IEnumerable<MaterialViewModel>> ObterMateriaisAsync()
        {
            return Task.FromResult(_mapper.Map<IEnumerable<MaterialViewModel>>(_materialRepositorio.ObterMateriaisAsync()));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
