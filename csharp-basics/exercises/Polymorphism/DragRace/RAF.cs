using System;
using DragRace.Interfaces;

namespace DragRace
{
    public class RAF : ICar
    {
        private int _currentSpeed;
        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public void SpeedUp()
        {
            _currentSpeed += 2;
        }

        public void StartEngine()
        {
            Console.WriteLine("---Eleganti---");
        }
    }
}
