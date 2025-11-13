using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
        public async Task<IActionResult> Register(Usuariomodel usuario)
        {
            if (ModelState.IsValid)

            {
                await usuarioService.CrearUsuario(usuario);
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }
        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            return View();

        }


    }
}

