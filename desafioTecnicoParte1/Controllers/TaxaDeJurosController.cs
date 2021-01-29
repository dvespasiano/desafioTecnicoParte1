using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioTecnicoParte1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet]
        [Route("/taxaJuros")]
        public double GetTaxaDeJuros()
        {
            return 0.01;
        }
    }
}
