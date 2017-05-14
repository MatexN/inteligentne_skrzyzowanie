using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            var jednoslad = new Vehicle("jednoslad");
            var osobowy = new Vehicle("osobowy");
            var ciezarowy = new Vehicle("ciezarowy");
            var jezdniaV = new Street("Vertical");
            var jezdniaH = new Street("Horizontal");
            var kolejkaSamochodow = new QueueOfCars();
            Console.ReadLine();
        }
    }
}
