using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {   
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }   //kullanıcı email ve şifre girdi api sisteminde CreateToken çalışacak.. eğer doğruysa ilgili kullanıcının
        //claimleri veritabanında jwt oluşturulacak(claim bilgilerini içeren) ve clienta geri gönderilecek..
}
