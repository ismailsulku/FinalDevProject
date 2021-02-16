using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message) //data+success+message ve base e yolla
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success) // data+success ve base e yolla
        {
            Data=data;
        }

        public T Data { get; }
    }
}
