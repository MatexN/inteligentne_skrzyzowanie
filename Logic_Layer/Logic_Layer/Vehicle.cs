using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class Vehicle
    {
        private int _speed;
        private string _type;
        private QueueOfCars _queueOfCars;

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
<<<<<<< HEAD

=======
>>>>>>> 4593f106afdfacf27f3f22c138bf59def06fc906
            _queueOfCars.AddToQueue(this);
        }

        public int GetSpeed()
        {
            return _speed;
<<<<<<< HEAD
=======
        }

        public string GetVehicleType()
        {
            return _type;
>>>>>>> 4593f106afdfacf27f3f22c138bf59def06fc906
        }
    }
}
