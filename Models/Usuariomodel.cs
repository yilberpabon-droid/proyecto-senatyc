using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace proyecto_pabon_yilber.Models
{
    public class Usuariomodel
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Usuario_Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public required string Usuario_Apellido { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio ")]
        public required string Usuario_Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        public required string Usuario_Contrasena { get; set; } 
        public string? Usuario_Salt { get; set; } 
     }
    }
  
    
