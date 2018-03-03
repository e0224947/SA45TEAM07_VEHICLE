using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class Car : Vehicle
    {
        int maxSeat;
        string carType;

        public int MaxSeat
        {
            get
            {
                return maxSeat;
            }

            set
            {
                maxSeat = value;
            }
        }

        public string CarType
        {
            get
            {
                return carType;
            }

            set
            {
                carType = value;
            }
        }
    }
}
