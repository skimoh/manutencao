//***CODE BEHIND - BY RODOLFO.FONSECA***//
using Microsoft.AspNetCore.Mvc;

namespace CodeBehind.Manutencao.SeriNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {        
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public UsuarioVM Get()
        {
            var usuario = new UsuarioVM();
            try
            {
                _logger.LogInformation("Rastreio - Entrou no Get");
                Convert.ToInt32("ERRO");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
            }

            return usuario;
        }
    }
}