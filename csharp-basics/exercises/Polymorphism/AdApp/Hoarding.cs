namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int numDays, int rate, bool isPrimeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _isPrimeLocation = isPrimeLocation;
        }

        public new int Cost() 
        {
            var fee = base.Cost();

            if (_isPrimeLocation)
            {
                fee += _numDays * (_rate * 2);
            }
            else
            {
                fee += _numDays * _rate;
            }
            return fee;
        }

        public override string ToString() 
        {
            return $"Hoarding Ad total cost for {_numDays} days is {Cost()}";
        }
    }
}