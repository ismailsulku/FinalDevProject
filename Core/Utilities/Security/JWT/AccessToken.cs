using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {   //kullanıcı email password girdiğinde (erişim anahtarı ile istekte bulunduğunda) 
        //biz de ona token(jeton) vereceğiz.. adı ve bitiş süresi olacak..
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
