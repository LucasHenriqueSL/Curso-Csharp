using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIv2.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIv2.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]


    public class UsuarioController : ControllerBase
    {
        ///<summary>
        ///teste    
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModeInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}