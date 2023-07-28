using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeviceswithIntefaces
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        bool con;
        public Smartphone(bool con)
        {
            this.con = con;
        }
        public int Charge(int minutes)
        {
            return minutes;
        }

        public bool Connect()
        {
            if (con==true)
            {
                return true;
            }
            return false;
        }

        public string Display()
        {
            string info = "Display Resolution :480*800\nRefresh Rate :60Hz\nColor Format :RGB\nScreen Size :5.5\nPPI :515(***HDPI)";
            return info;
        }
    }
}