using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
        //Sen JWT yöneteceksin senin anahtarın ve algoritman budur..
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)//hangi anahtarı kullanacaksın
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature); //hangi anahtar, hangi algoritma kullanılacak..
        }//                               ***********  ******************
    }
}
