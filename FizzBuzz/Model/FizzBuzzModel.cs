using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzModel
    {
        public string Number { get; set; }
        
        public IEnumerable<string> Result { get; set; }
    }
}
