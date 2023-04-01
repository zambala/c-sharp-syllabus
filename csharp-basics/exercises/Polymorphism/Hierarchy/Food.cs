using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        private string _foodType;
        public int FoodQuantity { get; }
        public abstract string GetFoodType();

        protected Food(string foodType, int foodQuantity)
        {
            _foodType = foodType;
            FoodQuantity = foodQuantity;
        }
    }
}
