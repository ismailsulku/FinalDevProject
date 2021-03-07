using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //elimizde string türünde securitykey var..(mysupersecretkeymysupersecretkey) securitykeyhelper onu byte array haline getirmeye yarıyor. 
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));//byte array halinde simetrik security anahtarına getirildi..
        }
    }
}
