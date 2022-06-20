using Microsoft.AspNetCore.Mvc;

namespace CodeBehind.Manutencao.NNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
       

        private readonly ILogger<FornecedorController> _logger;

        public FornecedorController(ILogger<FornecedorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public FornecedorVM Get()
        {
            var usuario = new FornecedorVM();
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