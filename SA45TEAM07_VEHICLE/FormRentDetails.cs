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
    public partial class FormRentDetails : BaseForm
    {
        private RentVehicleControl rentvehiclecontrol;
        public FormRentDetails()
        {
            InitializeComponent();
            
        }

        public FormRentDetails(RentVehicleControl rentvehiclecontrol) : this()
        {
            this.rentvehiclecontrol = rentvehiclecontrol;
        }

        internal void displayRentalDetails(string plateNum)
        {
            this.Show();
            toolStripStatusLabelRentInfo.Text = "Vehicle selected: " + plateNum;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!VehicleUtility.isNRICValid(txbNRIC.Text))
            {
                MessageBox.Show(VehicleMessage.InvalidNRIC);

            }
            else
            {
                Customer c = rentvehiclecontrol.retrieveCustomerDetails(txbNRIC.Text.Trim());

                if (c != null)
                {
                    name.Text = c.CustomerName;
                    telphone.Text = c.TelNum;
                    email.Text = c.Email;
                }
                else
                {
                    MessageBox.Show("Your NRIC is not found, Enter your information ");
                    name.Enabled = true;
                    telphone.Enabled = true;
                    email.Enabled = true;

                }

            }     
                
              
            }
        public void insertCustomer()
        {
         
            try
            {
                if (VehicleUtility.isEmpty(name.Text))
                {
                    MessageBox.Show(VehicleMessage.EmptyName);
                    return;
                }

                if (!VehicleUtility.isNRICValid(txbNRIC.Text))
                {
                    MessageBox.Show(VehicleMessage.InvalidNRIC);
                    return;
                }

                if (!VehicleUtility.isEmailValid(email.Text))
                {
                    MessageBox.Show(VehicleMessage.InvalidEmaildAddress);

                }

                Customer customer = new Customer();
                customer.IDNumber = txbNRIC.Text;
                customer.CustomerName = name.Text;
                customer.TelNum = telphone.Text;
                customer.Email = email.Text;


                rentvehiclecontrol.createCustomer(customer);
                MessageBox.Show(VehicleMessage.CustomerRecordSuccessful);


            }
            catch (Exception excep)
            {
                Console.WriteLine("Exception !!!");
                Console.WriteLine(excep.Message);
                Console.WriteLine(excep.StackTrace);
                MessageBox.Show(VehicleMessage.GeneralErrorMsg);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            insertCustomer();
            ///sale info
            

        }
    }
      
        
            

       
    }
