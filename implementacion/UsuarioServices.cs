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

        public UsuarioServices(dbcontex dbContext)
        {
            this.dbContext = dbContext;
        }
        public async void CrearUsuario(Usuariomodel pitufo)
        {
            if (pitufo != null)
            {
                dbContext.Usuarios.Add(pitufo);
                await dbContext.SaveChangesAsync();
            }
        }

    }
}