namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ClienteExclusao : ClienteComando
    {
        public ClienteExclusao(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
