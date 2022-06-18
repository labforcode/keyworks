using Microsoft.AspNetCore.Mvc;
using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;

namespace TesteKeyworks.WebApp.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
   

            return View();
        }

        [HttpGet]
        public IActionResult PesquisarCliente(int codigo)
        {


            return View();
        }

        [HttpGet]
        public IActionResult CadastrarCliente()
        {


            return Ok();
        }

        [HttpGet]
        public IActionResult AtualizarCliente()
        {


            return Ok();
        }


        [HttpPost]
        public IActionResult CadastrarCliente([FromBody] ClienteDto cliente)
        {
            ////cadastro
            //var cliente = new ClienteDto
            //{
            //    Cnpj = "12345678901236",
            //    RazaoSocial = "Teste 3",
            //    PlantaId = 1,
            //    TipoCliente = 1,
            //    CodigoMaterial = 1,
            //    Responsavel = new ResponsavelDto { Email = "teste3@teste.com.br", Nome = "Cadastro Teste" },
            //    Telefone = new TelefoneDto { DDI = "55", DDD = "43", Numero = "988106324" },
            //};

            //_clienteServico.Adicionar(cliente);

            return Ok();
        }

        [HttpPost]
        public IActionResult AtualizarCliente([FromBody] ClienteDto cliente)
        {


            return Ok();
        }

        [HttpDelete]
        public IActionResult ExcluirCliente(int codigo)
        {


            return Ok();
        }
    }
}
