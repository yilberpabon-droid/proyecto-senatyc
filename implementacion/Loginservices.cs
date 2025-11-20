using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_pabon_yilber.Data;
using proyecto_pabon_yilber.Models;
using proyecto_pabon_yilber.services;

namespace proyecto_pabon_yilber.implementacion
{
    public class Loginservices : ILoginservices
    {
        public async Task<Usuariomodel?> Login(Loginmodel login)
        {
            var usuario = await dbcontex.Usuarios.FirstOrDefaultAsync(u => u.Usuario_Correo == login.login_Correo);
            if (usuario == null)
            {
                return null;
            }
            bool esContrasenaValida = passwordservices
            .CompararContrasenas(login.login_Contrasena, usuario.Usuario_Contrasena, usuario.Usuario_Salt!);
            if (esContrasenaValida)
            {
                return usuario;
            }
            return null;
        }
        

        private readonly dbcontex dbcontex;

        private readonly IPasswordse  rvices passwordservices;

        public Loginservices(dbcontex dbcontex,IPasswordservices passwordservices)
        {
            this.dbcontex = dbcontex;
            this.passwordservices = passwordservices;
        }
    }
}