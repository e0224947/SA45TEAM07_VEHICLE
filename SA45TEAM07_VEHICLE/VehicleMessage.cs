using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class VehicleMessage
    {
        public const String GeneralErrorMsg
            = "T07001E Services not available. Please contact helpdesk.";

        public const String VehicleRecordNotFound
            = "T07012E Vehicle record not found.";

        public const String CustomerRecordNotFound
            = "T07013E Customer record not found.";

        public const String InvalidNRIC
            = "T07013E Invalid NRIC/FIN entered.";

        public const String RentalrRecordSuccessful
            = "Rental record successfully created!";

        

        public const String CustomerRecordFound
            = "DFT011E Customer record exist.  Please enter another id.";
        public const String EmptyName
           = "Name is Empty. Please enter your name ";
        public const String CustomerRecordSuccessful
            = "Invalid Customer NRIC.  Please enter correct NRIC ";
        public const String EmptyCustomerID
            = "DFT013E Customer Id cannot be empty.  Please enter a customer id.";
        public const String InvalidEmaildAddress
            = "DFT014E Invalid email address.  Please enter a valid email address.";
        
    }


}


    

