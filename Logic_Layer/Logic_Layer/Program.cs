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
        public Database _database = new Database();
        static void Main(string[] args)
        {
        }

        public void FillBase(string sessionTime, string sTrack, string car, string truck)
        {
            _database.FillDatabase(sessionTime, sTrack, car, truck);
        }
    }
}
