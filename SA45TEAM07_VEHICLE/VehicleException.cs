using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class VehicleException: ApplicationException
    {
        public VehicleException() : base()    {
        }

        public VehicleException(string message) : base(message)   {
        }

        public VehicleException(string message, Exception innerExc) 
            : base(message, innerExc)   {
        }
    }
}
