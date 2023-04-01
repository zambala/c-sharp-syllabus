using System;

namespace Hierarchy.Exceptions
{
    public class AnimalDoesNotEatThisFoodException : Exception
    {
        public AnimalDoesNotEatThisFoodException() : base("Animal Does Not Eat This Food") { }
    }
}
