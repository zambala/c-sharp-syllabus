namespace Hierarchy
{
    public class Meat : Food
    {
        public Meat(string foodType, int foodQuantity) : base(foodType, foodQuantity)
        {
        }

        public override string GetFoodType()
        {
            return "Meat";
        }
    }
}
