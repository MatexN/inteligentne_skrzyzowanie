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

        public Street(string type)
        {
            _type = type;
        }


    }
}
