using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Processor
{
    public class BuzzProcess :  IProcess
    {
        public string Number { get; private set; }
        public string Message { get { return Constants.Buzz; } }
        public int Divisor { get { return 5; } }

        public BuzzProcess(string number)
        {
            this.Number = number;
        }

        public string Execute(string number)
        {
            return Convert.ToInt64(number) % Divisor == 0 ? Message : string.Format(Constants.NotDivided, Number, Divisor);
        }

    }
}
