using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer
{
    public class Vehicle
    {
        private int _speed;
        private string _type;

        public Vehicle(string type)
        {
            _type = type;
            if (type == "jednoslad")
                _speed = 1;
            if (type == "ciezarowy")
                _speed = 3;
            if (type == "osobowy")
                _speed = 2;
        }
    }
}
