using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)//Error-1.constructora gider
        {

        }

        public ErrorResult() : base(false) //Error-2.constructora gider
        {

        }
    }
}
