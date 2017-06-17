using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class QueueOfCars
    {
        private Queue<Vehicle> _up = new Queue<Vehicle>();
        private Queue<Vehicle> _down = new Queue<Vehicle>();
        private Queue<Vehicle> _left = new Queue<Vehicle>();
        private Queue<Vehicle> _right = new Queue<Vehicle>();
        private Object _monitor = new Object();

        public void AddToQueue(Vehicle vehicle, int chosenQueue)
        {
            switch (chosenQueue)
            {
                case 1:
                    _up.Enqueue(vehicle);
                    break;
                case 2:
                    _down.Enqueue(vehicle);
                    break;
                case 3:
                    _left.Enqueue(vehicle);
                    break;
                case 4:
                    _right.Enqueue(vehicle);
                    break;
            }
        }

        public Vehicle RemoveFromQueue(int side)
        {
            switch (side)
            {
                case 1:
                    return _up.Dequeue();
                case 2:
                    return _down.Dequeue();
                case 3:
                    return _left.Dequeue();
                case 4:
                    return _right.Dequeue();
                default:
                    return null; //Tu jakiejs funkcji się używa ale nie pamiętam, zapytamy się na zajęciach;
            }
        }

        public int QueueLenght(int side)
        {
            int amountOfVehicles;
            switch (side)
            {
                case 1:
                    amountOfVehicles = _up.Count();
                    break;
                case 2:
                    amountOfVehicles = _down.Count();
                    break;
                case 3:
                    amountOfVehicles = _left.Count();
                    break;
                case 4:
                    amountOfVehicles = _right.Count();
                    break;
                default:
                    return 0;  //warunek dotyczący wyboru 1 z 4 jezdni będzie wyznaczany przed wywołaniem funkcji, te defaulty są tylko po to by visual skompilował
            }
            return amountOfVehicles;
        }

    }
}
