using Microsoft.AspNetCore.Mvc;

namespace CodeBehind.Manutencao.ELK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControleController : ControllerBase
    {        
        private readonly ILogger<ControleController> _logger;

        public ControleController(ILogger<ControleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                _logger.LogInformation("Teste Ola Mundo no LINUX-NGROK");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }

            return Ok();
        }
    }
}