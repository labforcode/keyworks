using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.Core.Notificacoes;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.UoW;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes
{
    public class ComandoHandlerCliente : IComandoHandlerCliente
    {
        private readonly IUnitOfWork _uow;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ComandoHandlerCliente(IUnitOfWork uow,
                                     IClienteRepositorio clienteRepositorio)
        {
            _uow = uow;
            _clienteRepositorio = clienteRepositorio;
        }

        public void Handler(ComandoAtualizacaoCliente comando)
        {
            try
            {
                if (comando.EhValido() == false) return;

                var clienteExistente = _clienteRepositorio.ObterClienteAsync(comando.Codigo).Result;
                if (clienteExistente == null)
                {
                    Notificacao.RegistrarNotificacao($"Cliente não cadastrado, verifique!");
                    return;
                }

                var cliente = new Cliente(clienteExistente.Codigo,
                                          clienteExistente.Cnpj,
                                          comando.RazaoSocial,
                                          comando.Ativo,
                                          comando.PlantaId,
                                          comando.TipoCliente,
                                          comando.Responsavel,
                                          comando.Telefone,
                                          comando.Materiais);

                _clienteRepositorio.Atualizar(cliente);
                if (_uow.Commit() == false)
                {
                    Notificacao.RegistrarNotificacao($"Não foi possível atualizar o cliente, tente novamente mais tarde!");
                    return;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Handler(ComandoExclusaoCliente comando)
        {
            try
            {
                if (comando.EhValido() == false) return;

                var clienteExistente = _clienteRepositorio.ObterClienteAsync(comando.Codigo).Result;
                if (clienteExistente == null)
                {
                    Notificacao.RegistrarNotificacao($"Cliente não cadastrado, verifique!");
                    return;
                }

                _clienteRepositorio.Excluir(clienteExistente);
                if (_uow.Commit() == false)
                {
                    Notificacao.RegistrarNotificacao($"Não foi possível excluir o cliente, tente novamente mais tarde!");
                    return;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Handler(ComandoInsercaoCliente comando)
        {
            try
            {
                if (comando.EhValido() == false) return;

                var clienteExistente = _clienteRepositorio.ObterClienteAsync(comando.Cnpj).Result;
                if (clienteExistente != null)
                {
                    Notificacao.RegistrarNotificacao($"Cliente já cadastrado, verifique!");
                    return;
                }

                var cliente = new Cliente(0,
                                          comando.Cnpj,
                                          comando.RazaoSocial,
                                          true,
                                          comando.PlantaId,
                                          comando.TipoCliente,
                                          comando.Responsavel,
                                          comando.Telefone,
                                          comando.Materiais);

                _clienteRepositorio.Adicionar(cliente);
                if (_uow.Commit() == false)
                {
                    Notificacao.RegistrarNotificacao($"Não foi possível cadastrar o cliente, tente novamente mais tarde!");
                    return;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
