namespace AdApp
{
    public class Poster : Advert
    {
        private int _dimensions;
        private int _copies;
        private int _costPerSquareCm;

        public Poster(int fee, int height, int width, int copies, int costPerSquareCm) : base(fee)
        {
            _dimensions = height * width;
            _copies = copies;
            _costPerSquareCm = costPerSquareCm;
        }
        public new decimal Cost()
        {
            var fee = base.Cost();

            fee += (_dimensions * _costPerSquareCm) * _copies;
            return fee;
        }

        public override string ToString()
        {
            return $"Poster total cost for {_copies} copies: {Cost()}";
        }
    }
}
