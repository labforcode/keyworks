using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.Servicos.Clientes
{
    public class ClienteServico : IClienteServico
    {

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
