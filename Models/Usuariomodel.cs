using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace proyecto_pabon_yilber.Models
{
    public class Usuariomodel
    {
        public int UserID { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Apellido { get; set; }
        public string Usuario_Correo { get; set; }
        public string Usuario_Contrasena { get; set; }
    }
}  
