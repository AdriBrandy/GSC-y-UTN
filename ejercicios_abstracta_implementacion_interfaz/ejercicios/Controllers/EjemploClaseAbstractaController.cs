﻿using ejercicios.EjemploClaseAbstracta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploClaseAbstractaController : ControllerBase
    {
        [HttpGet]
        public string EjemploClaseAbstracta()
        {
            Animal gato = new Gato();
            return gato.Caminar();
        }
    }
}
