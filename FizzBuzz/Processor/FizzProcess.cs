using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Processor
{
    public class FizzProcess : IProcess
    {
        public string Number { get; private set; }
        public string Message { get { return Constants.Fizz; } }
        public int Divisor { get { return 3; } }

        public FizzProcess(string number)
        {
            this.Number = number;
        }

        public string Execute(string number)
        {
            return Convert.ToInt64(number) % Divisor == 0 ? Message : string.Format(Constants.NotDivided, Number, Divisor);
        }
    }
}
