using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
