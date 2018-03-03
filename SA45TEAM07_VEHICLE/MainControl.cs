using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    public class MainControl
    {
        private EnquireVehicleStatusControl enquiryControl;
        private RentVehicleControl rentControl;
        private FormMain portalUI;

        public MainControl()
        {
            if (portalUI == null)
            {
                portalUI = new FormMain(this);
                portalUI.displayPortalUI();
            }
        }

        public FormMain PortalUI
        {
            get
            {
                return portalUI;
            }
        }

        public EnquireVehicleStatusControl EnquiryControl
        {
            get
            {
                return enquiryControl;
            }
        }

        public RentVehicleControl RentControl
        {
            get
            {
                return rentControl;
            }
        }

        public void initialiseEnquiryControl()
        {
            if(this.enquiryControl == null)
            {
                this.enquiryControl = new EnquireVehicleStatusControl(this);
            }
        }

        public void initialiseRentControl()
        {
            if (this.rentControl == null)
            {
                this.rentControl = new RentVehicleControl(this);
            }
        }

        public void closeUseCase(EnquireVehicleStatusControl enquiryControl)
        {
            enquiryControl.destroy();
            this.enquiryControl = null;
        }

        public void closeUseCase(RentVehicleControl rentControl)
        {
            rentControl.destroy();
            this.rentControl = null;
        }
    }
}
