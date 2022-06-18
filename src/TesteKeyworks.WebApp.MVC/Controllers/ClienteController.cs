using Microsoft.AspNetCore.Mvc;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais;

namespace TesteKeyworks.WebApp.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;
        private readonly IMaterialServico _materialServico;

        public ClienteController(IClienteServico clienteServico,
                                 IMaterialServico materialServico)
        {
            _clienteServico = clienteServico;
            _materialServico = materialServico;
        }

        public IActionResult Index()
        {
            //cadastro
            var cliente = new ClienteDto
            {
                Cnpj = "12345678901236",
                RazaoSocial = "Teste 3",
                PlantaId = 1,
                TipoCliente = 1,
                Responsavel = new ResponsavelDto { Email = "teste3@teste.com.br", Nome = "Cadastro Teste" },
                Telefone = new TelefoneDto { DDI = "55", DDD = "43", Numero = "988106324" },
                Materiais = new List<MaterialDto> { new MaterialDto { Codigo = 1, Descricao = "aço" } }
            };

            _clienteServico.Adicionar(cliente);


            //var aco = new MaterialDto 
            //{
            //    Descricao = "aço"
            //};

            //_materialServico.Adicionar(aco);

            //var aluminio = new MaterialDto
            //{
            //    Descricao = "alumínio"
            //};

            //_materialServico.Adicionar(aluminio);

            //var ferro = new MaterialDto
            //{
            //    Descricao = "ferro"
            //};

            //_materialServico.Adicionar(ferro);

            //var zinco = new MaterialDto
            //{
            //    Descricao = "zinco"
            //};

            //_materialServico.Adicionar(zinco);

            //var magnesio = new MaterialDto
            //{
            //    Descricao = "magnésio"
            //};

            //_materialServico.Adicionar(magnesio);

            //var cobre = new MaterialDto
            //{
            //    Descricao = "cobre"
            //};

            //_materialServico.Adicionar(cobre);






            return View();
        }
    }
}
