using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class VehicleCategory
    {
        static string car;
        static string truck;
        static string bus;

        public static string Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public static string Truck
        {
            get
            {
                return truck;
            }

            set
            {
                truck = value;
            }
        }

        public static string Bus
        {
            get
            {
                return bus;
            }

            set
            {
                bus = value;
            }
        }
    }
}
