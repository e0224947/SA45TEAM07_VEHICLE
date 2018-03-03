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
    public partial class FormMain : BaseForm
    {
        private MainControl mainControl;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(MainControl mainControl) : this()
        {
            this.mainControl = mainControl;
        }

        public MainControl MainControl
        {
            get
            {
                return mainControl;
            }
        }

        public void displayPortalUI()
        {
            this.ShowDialog();
        }

        public void focus()
        {

        }

        private void enquireStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainControl.initialiseEnquiryControl();        
        }

        private void rentVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainControl.initialiseRentControl();
        }
    }
}
