using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_pabon_yilber.Models
{
    public class Loginmodel
    {
        public required string login_Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        public required string login_Contrasena { get; set; }  
    }
}