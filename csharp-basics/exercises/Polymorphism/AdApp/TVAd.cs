namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private bool _isPeakTime;
        private int _rate;
        public TVAd(int fee, int rate, int seconds, bool isPeakTime) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _isPeakTime = isPeakTime;
        }
        
        public new int Cost() 
        {
            var fee = base.Cost();

            if (_isPeakTime)
            {
                fee += _seconds * (_rate * 2);
            }
            else
            {
                fee += (_seconds * _rate);
            }

            return fee;
        }

        public override string ToString() 
        {
            return $"TV Ad total cost for {_seconds} seconds: {Cost()}";
        }
    }
}