using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)
        {
            Message = message;
            //Success = success; //DRY prensibi gereği burayı siliyoruz.. 19.satırda çalışacak 
        }

        public Result(bool success) //message yollamasın 
        {  
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
