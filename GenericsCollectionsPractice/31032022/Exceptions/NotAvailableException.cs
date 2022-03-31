using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022.Exceptions
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message)
        {
        }
    }
}
