using TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoInsercaoCliente : ComandoCliente
    {
        public ComandoInsercaoCliente(int codigo,
                               string cnpj,
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
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Ativo = ativo;
            PlantaId = plantaId;
            CodigoMaterial = codigoMaterial;
            TipoCliente = tipoCliente;
            ResponsavelNome = responsavelNome;
            ResponsavelEmail = responsavelEmail;
            DDI = ddi;
            Telefone = telefone;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoInsercaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
