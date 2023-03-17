using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        public List<Video> _inventory;

        public VideoStore()
        {
            _inventory = new List<Video>();
            
        }

        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));

            for (int i = 0; i < _inventory.Count; i++)
            {
                _inventory[i]._flag = true;
            }
        }
        
        public void Checkout(string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].BeingCheckedOut();
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (Video video in _inventory)
            {
                if (video.Title == title && video.Available() == false)
                {
                    video.BeingReturned();
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                if (_inventory[i].Title == title)
                {
                    _inventory[i].ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine(video);
            }
        }
    }
}
