using TesteKeyworks.Cadastros.Dominios.Core.Comandos;
using TesteKeyworks.Cadastros.Infra.Util;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes
{
    public abstract class ComandoCliente : Comando
    {
        private string _telefone;

        public int Codigo { get; protected set; }

        public string Cnpj { get; protected set; }

        public string RazaoSocial { get; protected set; }

        public bool Ativo { get; protected set; }

        public int PlantaId { get; protected set; }

        public int TipoCliente { get; protected set; }

        public int CodigoMaterial { get; protected set; }

        public string ResponsavelNome { get; protected set; }

        public string ResponsavelEmail { get; protected set; }

        public string DDI { get; protected set; }

        public string Telefone
        {
            get => _telefone;
            protected set => _telefone = StringUtil.DeixarApenasNumeros(StringUtil.RemoverEspaco(value));
        }
    }
}
