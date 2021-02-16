using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message)//Success-1.constructora gider
        {

        }

        public SuccessResult() : base(true) //Success-2.constructora gider
        {

        }
    }
}
