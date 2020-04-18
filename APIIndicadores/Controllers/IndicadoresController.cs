using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using APIIndicadores.Models;

namespace APIIndicadores.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndicadoresController : ControllerBase
    {
        [HttpGet]
        public RelacaoIndicadores Get([FromServices]IConfiguration configuration)
        {
            var relacaoIndicadores = new RelacaoIndicadores();
            new ConfigureFromConfigurationOptions<RelacaoIndicadores>(
                configuration.GetSection("Indicadores"))
                    .Configure(relacaoIndicadores);

            return relacaoIndicadores;
        }
    }
}