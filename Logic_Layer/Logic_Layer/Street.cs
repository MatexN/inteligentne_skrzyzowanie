using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class Street
    {
        private int _timeToGo = 20;
        private string _type;
        private QueueOfCars _queueOfCars;
        public int _amountOfSTrack;
        public int _amountOfCar;
        public int _amountOfTruck;

        public Street(string type, QueueOfCars queueOfCars)
        {
            _type = type;
            _queueOfCars = queueOfCars;
            _amountOfCar = 0;
            _amountOfSTrack = 0;
            _amountOfTruck = 0;
        }

        public void Leave()
        {
            int side1 = _timeToGo;
            int side2 = _timeToGo;
            while (side1 > 0 && side2 > 0)
            {
                if (_type == "Vertical")
                {
                    var vehicle1 = _queueOfCars.RemoveFromQueue(1);
                    side1 -= vehicle1.GetSpeed();
                    AddAmount(vehicle1);
                    var vehicle2 = _queueOfCars.RemoveFromQueue(2);
                    side2 -= vehicle2.GetSpeed();
                    AddAmount(vehicle2);
                }
                else
                {
                    var vehicle1 = _queueOfCars.RemoveFromQueue(3);
                    side1 -= vehicle1.GetSpeed();
                    AddAmount(vehicle1);
                    var vehicle2 = _queueOfCars.RemoveFromQueue(4);
                    side2 -= vehicle2.GetSpeed();
                    AddAmount(vehicle2);
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

    }
}
