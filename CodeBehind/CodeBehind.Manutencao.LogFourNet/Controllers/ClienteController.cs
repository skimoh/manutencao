using log4net;
using Microsoft.AspNetCore.Mvc;

namespace CodeBehind.Manutencao.LogFourNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ClienteVM Get()
        {
            //ILog _logger = LogManager.GetLogger(typeof(Program));
            //_logger.Warn("Manualmente sem injeção");

            var cliente = new ClienteVM();
            try
            {
               _logger.LogWarning("Rastreio - Entrou no Get");
                Convert.ToInt32("ERRO");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");                
            }

            return cliente;
        }
    }
}