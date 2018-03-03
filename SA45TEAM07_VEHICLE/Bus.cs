using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class Bus: Vehicle
    {
        int maxPassenger;
        int tvQty;

        public int MaxPassenger
        {
            get
            {
                return maxPassenger;
            }

            set
            {
                maxPassenger = value;
            }
        }

        public int TvQty
        {
            get
            {
                return tvQty;
            }

            set
            {
                tvQty = value;
            }
        }
    }
}
