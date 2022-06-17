namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoExclusaoCliente : ComandoCliente
    {
        public ComandoExclusaoCliente(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
