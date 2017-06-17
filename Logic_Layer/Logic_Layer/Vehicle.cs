using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Logic_Layer
{
    public class Vehicle
    {
        private int _speed;
        private string _type;
        private QueueOfCars _queueOfCars;
        private bool _running = true;

        public Vehicle(string type, QueueOfCars queueOfCars)
        {
            _type = type;
            if (type == "jednoslad")
                _speed = 1;
            if (type == "ciezarowy")
                _speed = 3;
            if (type == "osobowy")
                _speed = 2;
            _queueOfCars = queueOfCars;
        }

        public void Arrive()
        {
            var choosing = new Random();
            while (_running)
            {
                int chosenQueue = choosing.Next(1, 5);
                if (_queueOfCars.QueueLenght(chosenQueue) < 20)
                {
                    _queueOfCars.AddToQueue(this, chosenQueue);
                }
                Thread.Sleep(_speed *40);
            }
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public string GetVehicleType()
        {
            return _type;
        }

        public void Stop()
        {
            _running = false;
        }
    }
}
