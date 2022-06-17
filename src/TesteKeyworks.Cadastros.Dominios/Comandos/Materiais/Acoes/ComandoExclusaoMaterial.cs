namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes
{
    public class ComandoExclusaoMaterial : ComandoMaterial
    {
        public ComandoExclusaoMaterial(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
