using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Processor
{
    public interface IProcess
    {
        string Number { get; }
        int Divisor { get;  }
        string Message { get; }
        string Execute(string number);
    }
}
