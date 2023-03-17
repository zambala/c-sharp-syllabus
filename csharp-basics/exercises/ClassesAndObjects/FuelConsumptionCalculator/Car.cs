namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double _startKilometers;
        public double _endKilometers;
        public double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;

        }

        public double CalculateConsumption()
        {
            double consumption = (_endKilometers - _startKilometers) / _liters;
            return System.Math.Round(consumption, 2);
        }

        public bool GasHog()
        {
            return CalculateConsumption() > 15;
        }

        public bool EconomyCar()
        {
            return CalculateConsumption() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }
    }
}
