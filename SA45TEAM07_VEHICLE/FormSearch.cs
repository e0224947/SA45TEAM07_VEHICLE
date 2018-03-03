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
    public partial class FormSearch : BaseForm
    {
        private EnquireVehicleStatusControl enquiryControl;

        public FormSearch()
        {
            InitializeComponent();
        }

        public FormSearch(EnquireVehicleStatusControl enquiryControl) : this()
        {
            this.enquiryControl = enquiryControl;
            this.MdiParent = enquiryControl.MainControl.PortalUI;
        }

        public void displaySearchUI()
        {
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            enquiryControl.retrieveVehicle(txbPlateNum.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            enquiryControl.close(this);
            enquiryControl.closeUseCase();
        }

        private void FormSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            enquiryControl.closeUseCase();
        }

    }
}
