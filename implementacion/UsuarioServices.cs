using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto_pabon_yilber.Data;
using proyecto_pabon_yilber.Models;
using proyecto_pabon_yilber.services;

namespace proyecto_pabon_yilber.implementacion
{
    public class UsuarioServices : IUsuarioService
    {
        private readonly dbcontex dbContext;
        private readonly IPasswordservices passwordservices;


        public UsuarioServices(dbcontex dbContext, IPasswordservices passwordservices)
        {

            this.dbContext = dbContext;
            this.passwordservices = passwordservices;
        }
        public async Task CrearUsuario(Usuariomodel pitufo)
        {
            if (pitufo != null)
            {
                pitufo.Usuario_Contrasena = passwordservices.Hashpassword(pitufo.Usuario_Contrasena, out string salt);
                pitufo.Usuario_Salt = salt; 
                dbContext.Usuarios.Add(pitufo);
                await dbContext.SaveChangesAsync();
            }
        }

    }

    internal class dbContext
    {
    }
}