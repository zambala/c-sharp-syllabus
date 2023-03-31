using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable(string foodType, int foodQuantity) : base(foodType, foodQuantity)
        {
        }

        public override string GetFoodType()
        {
            return "Vegetable";
        }
    }
}
