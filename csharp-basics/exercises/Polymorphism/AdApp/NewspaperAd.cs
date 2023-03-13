namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _columnCm;
        private int _rate;

        public NewspaperAd(int fee, int columnCm, int rate) : base(fee)
        {
            _columnCm = columnCm;
            _rate = rate;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            fee += _columnCm * _rate;
            return fee;
        }

        public override string ToString()
        {
            return $"News paper Ad, cost for {_columnCm} centimeters column is: {Cost()}";
        }
    }
}