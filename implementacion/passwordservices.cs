using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using proyecto_pabon_yilber.services;

namespace proyecto_pabon_yilber.implementacion
{
    public class Passwordservices : IPasswordservices
    {

        public bool CompararContrasenas(string Contrasena, string ContrasenaBD, string Salt)
        {
           byte[] SaltBytes = Convert.FromBase64String(Salt);
           string hsshedPasswordTocheck = EncryptPassword(Contrasena,SaltBytes);
           return hsshedPasswordTocheck == ContrasenaBD;
        }

        public string Hashpassword(string password, out string salt)
        {
            string hashedPassword;
            byte[] saltBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            salt = Convert.ToBase64String(saltBytes );
            hashedPassword = EncryptPassword(password, saltBytes);
            return hashedPassword;
        }
        private string EncryptPassword(string Contrasena, byte[] saltBytes)
        {
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Contrasena,
                salt: saltBytes,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            return hashedPassword;
        }
    }
}