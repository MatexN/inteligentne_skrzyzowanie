using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Layer;

namespace Logic_Layer
{
    public class Program
    {
        public Database database = new Database();
        static void Main(string[] args)
        {
            var queueOfCars = new QueueOfCars();
            var sTrack = new Vehicle("jednoslad", queueOfCars);
            var car = new Vehicle("osobowy", queueOfCars);
            var truck = new Vehicle("ciezarowy", queueOfCars);
            var StreetV = new Street("Vertical", queueOfCars);
            var StreetH = new Street("Horizontal", queueOfCars);
        }
    }
}
