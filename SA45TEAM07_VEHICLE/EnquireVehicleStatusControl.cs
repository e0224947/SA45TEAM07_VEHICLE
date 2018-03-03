using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45TEAM07_VEHICLE
{
    public class EnquireVehicleStatusControl : IDisposable
    {
        private MainControl mainControl;
        private FormSearch searchUI;
        private FormVehicleDetails vehicleDetailUI;

        public EnquireVehicleStatusControl(MainControl mainControl)
        {
            this.mainControl = mainControl;
            this.searchUI = new FormSearch(this);
            this.searchUI.displaySearchUI();
        }

        public MainControl MainControl
        {
            get
            {
                return mainControl;
            }
        }


        public FormSearch SearchUI
        {
            get
            {
                return searchUI;
            }
        }


        public void retrieveVehicle(string plateNum)
        {
            try
            {
                VehicleDAO.Instance.OpenConnection();       
                Vehicle vehicle = VehicleDAO.Instance.RetrieveVehicle(plateNum);
                vehicleDetailUI = new FormVehicleDetails(this);
                vehicleDetailUI.displayVehicleDetailUI(vehicle);
            }
            catch(VehicleException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                VehicleDAO.Instance.CloseConnection();
            }
        }

        public void close(BaseForm form)
        {
            form.Close();
            
            if (form is FormVehicleDetails)
            {
                this.searchUI.Activate();
            }
        }

        public void closeUseCase()
        {
            mainControl.closeUseCase(this);
        }

        internal void destroy()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
