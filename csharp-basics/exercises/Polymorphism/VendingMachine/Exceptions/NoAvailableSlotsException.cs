using System;

namespace VendingMachine.Exceptions
{
    public class NoAvailableSlotsException : Exception
    {
        public NoAvailableSlotsException() : base("No slots available") { }
    }
}
