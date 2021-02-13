using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<V> : DataResult<V>
    {
        public ErrorDataResult(V data, string message):base(data, false, message)
        {

        }

        public ErrorDataResult(string message):base(default, false, message)
        {

        }

        public ErrorDataResult(V data):base(data, false)
        {

        }

        public ErrorDataResult():base(default, false)
        {

        }
    }
}
