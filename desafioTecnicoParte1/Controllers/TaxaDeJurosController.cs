﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace desafioTecnicoParte1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet]
        [Route("taxaJuros")]
        public double GetTaxaDeJuros()
        {
            return 0.01;
        }
    }
}
