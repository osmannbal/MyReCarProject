using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<V> : Result, IDataResult<V>
    {
        public DataResult(V data, bool success, string message) :base(success,message)
        {
            Data = data;
        }

        public DataResult(V data, bool success) : base(success)
        {
            Data = data;
        }
        public V Data { get; }
    }
}
