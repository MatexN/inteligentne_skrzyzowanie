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
        public int First { get; set; }
        public int Second { get; set; }

        public Street(string type, QueueOfCars queueOfCars)
        {
            _type = type;
            _queueOfCars = queueOfCars;
        }

        public void LeaveV()
        {
                var leavingVehicle = _queueOfCars.RemoveFromQueue(1);
                var leavingVehicle2 = _queueOfCars.RemoveFromQueue(2);
                if (First > 0 && Second > 0)
                {
                    if (leavingVehicle!=null)
                    {
                        First = First - leavingVehicle.GetSpeed();
                    }
                    if (leavingVehicle2 != null)
                    {
                        Second = Second - leavingVehicle2.GetSpeed();
                    }
                    
                }
        }
        public void LeaveH()
        {
            var leavingVehicle = _queueOfCars.RemoveFromQueue(3);
            var leavingVehicle2 = _queueOfCars.RemoveFromQueue(4);
            if (First > 0 && Second > 0)
            {
                if (leavingVehicle != null)
                {
                    First = First - leavingVehicle.GetSpeed();
                }
                if (leavingVehicle2 != null)
                {
                    Second = Second - leavingVehicle2.GetSpeed();
                }

            }
        }
    }
}
