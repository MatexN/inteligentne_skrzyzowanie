using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kolejkaSamochodow = new QueueOfCars();
            var jednoslad = new Vehicle("jednoslad",kolejkaSamochodow);
            var osobowy = new Vehicle("osobowy",kolejkaSamochodow);
            var ciezarowy = new Vehicle("ciezarowy",kolejkaSamochodow);
            var jezdniaV = new Street("Vertical",kolejkaSamochodow);
            var jezdniaH = new Street("Horizontal",kolejkaSamochodow);
            Console.ReadLine();
        }
    }
}
