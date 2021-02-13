using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<V> : DataResult<V> 
    {
        public SuccessDataResult(V data, string message):base(data, true, message)
        {

        }
        public SuccessDataResult(V data):base(data, true)
        {

        }

        public SuccessDataResult(string message):base(default, true, message)
        {

        }
         
        public SuccessDataResult():base(default, true)
        {

        }
    }
}
