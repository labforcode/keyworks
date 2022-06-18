using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;
using TesteKeyworks.Cadastros.Dominios.Core.Notificacoes;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Materiais;
using TesteKeyworks.Cadastros.Dominios.Interfaces.UoW;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais
{
    public class ComandoHandlerMaterial : IComandoHandlerMaterial
    {
        private readonly IUnitOfWork _uow;
        private readonly IMaterialRepositorio _materialRepositorio;

        public ComandoHandlerMaterial(IUnitOfWork uow,
                                      IMaterialRepositorio materialRepositorio)
        {
            _uow = uow;
            _materialRepositorio = materialRepositorio;
        }

        public void Handler(ComandoAtualizacaoMaterial comando)
        {
            if (comando.EhValido() == false) return;

            var materialExistente = _materialRepositorio.ObterMaterialAsync(comando.Codigo).Result;
            if (materialExistente == null)
            {
                Notificacao.RegistrarNotificacao($"Material não cadastrado, verifique!");
                return;
            }

            var material = new Material(materialExistente.Codigo,
                                        comando.Descricao);

            _materialRepositorio.Atualizar(material);
            if (_uow.Commit() == false)
            {
                Notificacao.RegistrarNotificacao($"Não foi possível atualizar o material, tente novamente mais tarde!");
                return;
            }
        }

        public void Handler(ComandoExclusaoMaterial comando)
        {
            if (comando.EhValido() == false) return;

            var materialExistente = _materialRepositorio.ObterMaterialAsync(comando.Codigo).Result;
            if (materialExistente == null)
            {
                Notificacao.RegistrarNotificacao($"Material não cadastrado, verifique!");
                return;
            }

            _materialRepositorio.Excluir(materialExistente);
            if (_uow.Commit() == false)
            {
                Notificacao.RegistrarNotificacao($"Não foi possível excluir o material, tente novamente mais tarde!");
                return;
            }
        }

        public void Handler(ComandoInsercaoMaterial comando)
        {
            if (comando.EhValido() == false) return;

            var material = new Material(0,
                                        comando.Descricao);

            _materialRepositorio.Adicionar(material);
            if (_uow.Commit() == false)
            {
                Notificacao.RegistrarNotificacao($"Não foi possível cadastrar o material, tente novamente mais tarde!");
                return;
            }
        }
    }
}
