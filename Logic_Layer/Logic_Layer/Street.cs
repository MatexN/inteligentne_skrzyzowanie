using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Logic_Layer
{
    public class Street
    {
        private int _timeToGo = 20;
        private string _type;
        private QueueOfCars _queueOfCars;
        private Object _monitor;
        private bool _running = true;
        public int _amountOfSTrack;
        public int _amountOfCar;
        public int _amountOfTruck;

        public Street(string type, QueueOfCars queueOfCars, Object monitor)
        {
            _monitor = monitor;
            _type = type;
            _queueOfCars = queueOfCars;
            _amountOfCar = 0;
            _amountOfSTrack = 0;
            _amountOfTruck = 0;
        }

        public void Leave()
        {
            while (_running)
            {
                int side1 = _timeToGo;
                int side2 = _timeToGo;
                lock (_monitor)
                {
                    Thread.Sleep(600);
                    Monitor.PulseAll(_monitor);   
                }
                while (side1 > 0 && side2 > 0)
                {

                    if (_type == "Vertical")
                    {
                        if (_queueOfCars.QueueLenght(1) > 0)
                        {
                            var vehicle1 = _queueOfCars.RemoveFromQueue(1);
                            side1 -= vehicle1.GetSpeed();
                            AddAmount(vehicle1);
                        }
                        if (_queueOfCars.QueueLenght(2) > 0)
                        {
                            var vehicle2 = _queueOfCars.RemoveFromQueue(2);
                            side2 -= vehicle2.GetSpeed();
                            AddAmount(vehicle2);
                        }
                        if (_queueOfCars.QueueLenght(1) == 0 && _queueOfCars.QueueLenght(2) == 0)
                            break;
                    }
                    else
                    {
                        if (_queueOfCars.QueueLenght(3) > 0)
                        {
                            var vehicle1 = _queueOfCars.RemoveFromQueue(3);
                            side1 -= vehicle1.GetSpeed();
                            AddAmount(vehicle1);
                        }
                        if (_queueOfCars.QueueLenght(4) > 0)
                        {
                            var vehicle2 = _queueOfCars.RemoveFromQueue(4);
                            side2 -= vehicle2.GetSpeed();
                            AddAmount(vehicle2);
                        }
                        if (_queueOfCars.QueueLenght(3) == 0 && _queueOfCars.QueueLenght(4) == 0)
                            break;
                    }
                }
            }
        }

        private void AddAmount(Vehicle vehicle)
        {
            string vehicleType = vehicle.GetVehicleType();
            if (vehicleType == "jednoslad")
            {
                _amountOfSTrack++;
            }
            if (vehicleType == "osobowy")
            {
                _amountOfCar++;
            }
            if (vehicleType == "ciezarowy")
            {
                _amountOfTruck++;
            }
        }

        public void Stop()
        {
            _running = false;
        }
    }
}
