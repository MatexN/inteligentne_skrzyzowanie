using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Layer
{
    public class Database
    {
        private List<DataItem> _dataItems = new List<DataItem>();
        static void Main(string[] args)
        {
        }
        public void FillDatabase(string sessionTime, string sTrack, string car, string truck)
        {
            string sessionNumber = _dataItems.Count().ToString();
            var session = new DataItem
            {
                SessionNumber = sessionNumber,
                SessionTime = sessionTime,
                STrack = sTrack,
                Car = car,
                Truck = truck
            };
            _dataItems.Add(session);
        }

        public List<DataItem> GetData()
        {
            var tmp = _dataItems;
            return tmp;
        }
    }
}

