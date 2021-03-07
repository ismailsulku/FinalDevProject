using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash 
            (string password, out byte[] passwordHash, out byte[] passwordSalt) //password vereceğiz dışarıya (out olanlar) iki değeri çıkartacağız
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())//hash oluştururken bu algoritmayı kullandık..
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }                                  //üstteki yapı passwordu byte array şeklinde verir.
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {   //elde ettiğimiz hash (passwordSalt) ile hesaplanan hash doğrulanacak..
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//aynı algoritmayı kullanarak daha önce oluşturduğumuz passwordSalt ile onu doğruluyoruz..
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            
        }
    }
}
