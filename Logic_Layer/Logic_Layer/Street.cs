using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class Street
    {
        public int _amountOfVehicles;
        private int _timeToGo = 20;
        private string _type;
        private QueueOfCars _queueOfCars;

        public Street(string type, QueueOfCars queueOfCars)
        {
            _type = type;
            _queueOfCars = queueOfCars;
        }

        public void Leave()
        {

        }

    }
}
