using CodeBehind.Manutencao.Beijo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//***CODE BEHIND - BY RODOLFO.FONSECA***//
namespace CodeBehind.Manutencao.Beijo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }
                

        public PessoaVM Get()
        {
            var pessoa = new PessoaVM();
            try
            {                
                _logger.LogInformation("Informação Youtube Agora");

                Convert.ToInt32("ERRO");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "ERRO");
            }

            return pessoa;
        }
    }
}