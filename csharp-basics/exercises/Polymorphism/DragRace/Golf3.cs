using System;
using DragRace.Interfaces;

namespace DragRace
{
    public class Golf3 : ICar
    {
        private int _currentSpeed;

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void SlowDown()
        {
            _currentSpeed -= 3;
        }

        public void SpeedUp()
        {
            _currentSpeed += 11;
        }

        public void StartEngine()
        {
            Console.WriteLine("klak, klak, klak");
        }
    }
}
