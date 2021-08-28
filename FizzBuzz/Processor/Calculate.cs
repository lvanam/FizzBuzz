using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Processor
{
    public class Calculate : IDisposable
    {
        private bool disposedValue;

        /// <summary>
        /// validate the input text 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool Validate(string number)
        {
            return !string.IsNullOrEmpty(number) && !string.IsNullOrWhiteSpace(number) && Int64.TryParse(number, out long longNumber) && longNumber != 0;
        }

        /// <summary>
        /// Execute the number to verify its dividable by 3 or 5 based on the process
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public string CalcualteNumber(IProcess process)
        {
            if (Validate(process.Number))
            {
                return process.Execute(process.Number);
            }
            return Constants.InvalidItem;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
