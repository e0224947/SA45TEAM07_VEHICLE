using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class Truck: Vehicle
    {
        int maxCargo;
        int wheelQty;

        public int MaxCargo
        {
            get
            {
                return maxCargo;
            }

            set
            {
                maxCargo = value;
            }
        }

        public int WheelQty
        {
            get
            {
                return wheelQty;
            }

            set
            {
                wheelQty = value;
            }
        }
    }
}
