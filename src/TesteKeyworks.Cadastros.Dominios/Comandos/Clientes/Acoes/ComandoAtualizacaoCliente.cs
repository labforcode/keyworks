using TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoAtualizacaoCliente : ComandoCliente
    {
        public ComandoAtualizacaoCliente(int codigo,
                                  string razaoSocial,
                                  bool ativo,
                                  int plantaId,
                                  int tipoCliente,
                                  int codigoMaterial,
                                  string responsavelNome,
                                  string responsavelEmail,
                                  string ddi,
                                  string telefone)
        {
            Codigo = codigo;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            TipoCliente = tipoCliente;
            CodigoMaterial = codigoMaterial;
            ResponsavelNome = responsavelNome;
            ResponsavelEmail = responsavelEmail;
            DDI = ddi;
            Telefone = telefone;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoAtualizacaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
