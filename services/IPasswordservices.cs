using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_pabon_yilber.services
{
    public interface IPasswordservices
    {
        string Hashpassword(string password, out String salt);
        bool CompararContrasenas(string Contrasena, string ContrasenaBD, string Salt);

    }
}