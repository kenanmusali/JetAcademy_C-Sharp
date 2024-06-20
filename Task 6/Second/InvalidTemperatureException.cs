using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ITE : Exception
    {
        public ITE() : base("below absolute zero")
        {
        }

        public ITE(string message) : base(message)
        {
        }
    }
}
