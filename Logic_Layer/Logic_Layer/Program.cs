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
<<<<<<< HEAD
            var queueOfCars = new QueueOfCars();
            var sTrack = new Vehicle("jednoslad", queueOfCars);
            var car = new Vehicle("osobowy", queueOfCars);
            var truck = new Vehicle("ciezarowy", queueOfCars);
            var StreetV = new Street("Vertical", queueOfCars);
            var StreetH = new Street("Horizontal", queueOfCars);
=======
            var kolejkaSamochodow = new QueueOfCars();
            var jednoslad = new Vehicle("jednoslad",kolejkaSamochodow);
            var osobowy = new Vehicle("osobowy",kolejkaSamochodow);
            var ciezarowy = new Vehicle("ciezarowy",kolejkaSamochodow);
            var jezdniaV = new Street("Vertical",kolejkaSamochodow);
            var jezdniaH = new Street("Horizontal",kolejkaSamochodow);
            Console.ReadLine();
>>>>>>> 4593f106afdfacf27f3f22c138bf59def06fc906
        }
    }
}
