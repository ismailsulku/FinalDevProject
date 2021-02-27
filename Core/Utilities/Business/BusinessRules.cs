using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params istediğin kadar parametreyi yazabiliriz
        {
            foreach (var logic in logics) //tüm kuralları gez
            {
                if (!logic.Success) //kurala uymayan varsa
                {
                    return logic; // kuralı döndür
                }
            }

            return null;
        }
    }
}
