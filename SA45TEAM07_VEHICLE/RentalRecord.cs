using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class RentalRecord
    {
        Customer rentingCustomer;
        Vehicle rentedVehicle;
        int rentalPeriod;
        DateTime rentStartDate;
        DateTime actualReturnDate;


        public int RentalPeriod
        {
            get
            {
                return rentalPeriod;
            }

            set
            {
                rentalPeriod = value;
            }
        }

        public DateTime RentStartDate
        {
            get
            {
                return rentStartDate;
            }

            set
            {
                rentStartDate = value;
            }
        }

        public DateTime ActualReturnDate
        {
            get
            {
                return actualReturnDate;
            }

            set
            {
                actualReturnDate = value;
            }
        }

        internal Customer RentingCustomer
        {
            get
            {
                return rentingCustomer;
            }

            set
            {
                rentingCustomer = value;
            }
        }

        public Vehicle RentedVehicle
        {
            get
            {
                return rentedVehicle;
            }

            set
            {
                rentedVehicle = value;
            }
        }
    }
}