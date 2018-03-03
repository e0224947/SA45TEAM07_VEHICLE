using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class Customer
    {
        int customerId;
        string idNumber;
        string customerName;
        string telNum;
        string email;



        public int CustomerID
        {
            get
            {
                return customerId;
            }
        }

        public string IDNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string TelNum
        {
            get
            {
                return telNum;
            }
            set
            {
                telNum = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                telNum = email;
            }
        }
    }
}
