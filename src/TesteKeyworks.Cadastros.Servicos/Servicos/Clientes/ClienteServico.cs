using AutoMapper;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Clientes
{
    public class ClienteServico : IClienteServico
    {
        private readonly IMapper _mapper;
        private readonly IComandoHandlerCliente _comandoHandlerCliente;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IMapper mapper,
                              IComandoHandlerCliente comandoHandlerCliente,
                              IClienteRepositorio clienteRepositorio)
        {
            _mapper = mapper;
            _comandoHandlerCliente = comandoHandlerCliente;
            _clienteRepositorio = clienteRepositorio;
        }

        public void Adicionar(ClienteDto cliente)
        {
            var comando = _mapper.Map<ComandoInsercaoCliente>(cliente);
            _comandoHandlerCliente.Handler(comando);
        }

        public void Atualizar(ClienteDto cliente)
        {
            var comando = _mapper.Map<ComandoAtualizacaoCliente>(cliente);
            _comandoHandlerCliente.Handler(comando);
        }

        public void Excluir(int codigo)
        {
            var comando = _mapper.Map<ComandoExclusaoCliente>(codigo);
            _comandoHandlerCliente.Handler(comando);
        }

        public Task<ClienteViewModel> ObterClienteAsync(int codigo)
        {
            return Task.FromResult(_mapper.Map<ClienteViewModel>(_clienteRepositorio.ObterClienteAsync(codigo).Result));
        }

        public Task<IEnumerable<ClienteViewModel>> ObterClientesAsync()
        {
            return Task.FromResult(_mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepositorio.ObterClientesAsync().Result));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
