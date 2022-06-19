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
            var clientes = _clienteServico.ObterClientesAsync().Result;
            ViewBag.Clientes = clientes;

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
            //cadastro
            var client1e = new ClienteDto
            {
                Cnpj = "12345678901236",
                RazaoSocial = "Teste 3",
                PlantaId = 1,
                TipoCliente = 1,
                CodigoMaterial = 1,
                ResponsavelNome = "Cadastro Teste",
                ResponsavelEmail = "teste3@teste.com.br",
                DDI = "55",
                DDD = "43",
                Telefone = "988106324",
            };

            _clienteServico.Adicionar(client1e);

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
