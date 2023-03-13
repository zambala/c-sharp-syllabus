namespace DaysNames
{
    public class Program
    {

        static void Main(string[] args)
        {
            var daysNames = Enum.GetValues(typeof(Enum1.DaysOfWeek)).Cast<Enum1.DaysOfWeek>();

            foreach (var day in daysNames)
            {
                Console.Write($"{day} ");
            }

            Console.ReadKey();
        }
    }
}