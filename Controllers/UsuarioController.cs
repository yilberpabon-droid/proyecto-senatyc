using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyecto_pabon_yilber.Models;
using proyecto_pabon_yilber.services;

namespace proyecto_pabon_yilber.Controllers
{
    [Route("user")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(Usuariomodel usuario)
        {
            if (usuario != null)
            {
                usuarioService.CrearUsuario(usuario);
                return Ok("Usuario creado");
            }
            else
            {
                return BadRequest("Usuario no puede ser null");
            }
        }
    }
}
