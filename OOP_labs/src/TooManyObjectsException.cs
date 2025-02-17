using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_labs.src
{
    class TooManyObjectsException : OutOfMemoryException
    {
        private int _limit;
        public int Limit {
            get => _limit;
        }

        public TooManyObjectsException(string message, int limit) : base(message) {
            _limit = limit;
        }
    }
}
