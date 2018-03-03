using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM07_VEHICLE
{
    public partial class FormVehicleDetails : BaseForm
    {
        private EnquireVehicleStatusControl enquiryControl;

        public FormVehicleDetails()
        {
            InitializeComponent();
        }

        public FormVehicleDetails(EnquireVehicleStatusControl enquiryControl) : this()
        {
            this.enquiryControl = enquiryControl;
        }

        public void displayVehicleDetail(Vehicle vehicle)
        {
            txbModel.Text = vehicle.Model;
            txbColor.Text = vehicle.Color;
            txbPlateNum.Text = vehicle.PlateNum;
            txbEngineSerialNo.Text = vehicle.EngineSN;
            txbStatus.Text = vehicle.Status;
        }

        public void displayVehicleDetailUI(Vehicle vehicle)
        {
            displayVehicleDetail(vehicle);
            this.ShowDialog();          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            enquiryControl.close(this);
        }

        private void FormVehicleDetails_Load(object sender, EventArgs e)
        {
            enquiryControl.close(this);
        }
    }
}
