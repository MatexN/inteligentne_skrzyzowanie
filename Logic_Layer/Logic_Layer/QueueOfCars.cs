using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class QueueOfCars
    {
        public Queue<Vehicle> _up = new Queue<Vehicle>();
        public Queue<Vehicle> _down = new Queue<Vehicle>();
        public Queue<Vehicle> _left = new Queue<Vehicle>();
        public Queue<Vehicle> _right = new Queue<Vehicle>();


    }
}
