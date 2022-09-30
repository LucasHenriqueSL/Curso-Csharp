using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Usuarios;

namespace WebApplication1.Controllers
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
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}