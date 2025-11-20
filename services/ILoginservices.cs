using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_pabon_yilber.Models;

namespace proyecto_pabon_yilber.services
{
    public interface ILoginservices
    {
        Task<Usuariomodel?>  Login(Loginmodel login);
        
    }
}