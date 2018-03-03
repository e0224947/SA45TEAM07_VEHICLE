using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SA45TEAM07_VEHICLE
{
    public class RentVehicleControl
    {
        private MainControl mainControl;
        private FormCategorySearch formCategorySearch;
        private FormRentDetails formRentDetails;

        public MainControl MainControl
        {
            get
            {
                return mainControl;
            }

            set
            {
                mainControl = value;
            }
        }

        public FormCategorySearch FormCategorySearch
        {
            get
            {
                return formCategorySearch;
            }

            set
            {
                formCategorySearch = value;
            }
        }

        public FormRentDetails FormRentDetails
        {
            get
            {
                return formRentDetails;
            }

            set
            {
                formRentDetails = value;
            }
        }

        internal Customer retrieveCustomerDetails(string NRIC)
        {

            Customer c;
            
             CustomerDAO.Instance.OpenConnection();
             c = CustomerDAO.Instance.retrieveCustomer(NRIC);

            CustomerDAO.Instance.CloseConnection();
            return c;

        }
        internal void createCustomer(Customer c)
        {

            try
            {
                CustomerDAO.Instance.OpenConnection();
                CustomerDAO.Instance.CreateCusomter(c);

                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CustomerDAO.Instance.CloseConnection();
            }
        }

        public RentVehicleControl(MainControl mainControl)
        {
            this.MainControl = mainControl;
            this.FormCategorySearch = new FormCategorySearch(this);
            FormCategorySearch.displayCategorySearchUI();
            List<string> vehicleCategory = VehicleDAO.Instance.RetrieveCategoryList();//retrieve via DAO
            FormCategorySearch.displayCategory(vehicleCategory);
        }

        public void SelectCategory(string category)
        {
            try
            {
                VehicleDAO.Instance.OpenConnection();
                DataTable dt = new DataTable();
                switch (category)
                {
                    case "Car":
                        dt = VehicleDAO.Instance.RetrieveAvailableCarList();
                        break;
                    case "Bus":
                        dt = VehicleDAO.Instance.RetrieveAvailableBusList();
                        break;
                    case "Truck":
                        dt = VehicleDAO.Instance.RetrieveAvailableTruckList();
                        break;
                    default:
                        break;
                }
                FormCategorySearch.displayAvailableVehicle(dt);
            }
            catch (VehicleException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                VehicleDAO.Instance.CloseConnection();
            }
        }

        public void SelectVehicle(string plateNum)
        {
            FormRentDetails = new FormRentDetails(this);
            FormRentDetails.displayRentalDetails(plateNum);
            

            //keep this plateNum, create a transaction, add this plate number
            //take customer, add into this transaction object's attribute value
            //pass this object to the DAO to save it to database

        }

        public void close(BaseForm form)
        {
            form.Close();

            if (form is FormRentDetails)
            {
                this.formCategorySearch.Activate();
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
