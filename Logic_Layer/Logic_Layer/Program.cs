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
        static void Main(string[] args)
        {
            var jednoslad = new Vehicle("jednoslad");
            var osobowy = new Vehicle("osobowy");
            var ciezarowy = new Vehicle("ciezarowy");
            var jezdniaV = new Street("Vertical");
            var jezdniaH = new Street("Horizontal");
            var kolejkaSamochodow = new QueueOfCars();
        }
        public List<DataItem> GetList()
        {
            var tmp = new Database().GetData();
            return tmp;
        }
    }
}
