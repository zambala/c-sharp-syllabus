using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string _title;
        public bool _flag;
        public List<double> _rating;
        public Video(string title)
        {
            _title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            _flag = false;
        }

        public void BeingReturned()
        {
            _flag = true;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return (_rating.Sum() / _rating.Count);
        }

        public bool Available()
        {
            return _flag;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"Movie: {_title} with average rating: {AverageRating()} available: {Available()}";
        }
    }
}
