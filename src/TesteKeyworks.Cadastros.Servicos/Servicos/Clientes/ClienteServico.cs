using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Clientes
{
    public class ClienteServico : IClienteServico
    {
        public void Adicionar(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(ClienteDto cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<ClienteViewModel> ObterCliente(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClienteViewModel>> ObterClientes()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
