using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45TEAM07_VEHICLE
{
    class CustomerDAO
    {
        public const int CAR = 0;
        public const int TRUCK = 1;
        public const int BUS = 2;

        SqlConnection cn;
        SqlCommand cmRetriCusDetail;
        SqlCommand cmCreateCustomer;
        
        private static CustomerDAO dbInstance;

        private CustomerDAO()
        {
            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|VehicleRental.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            InitializeSQLCmd();
        }

        private void InitializeSQLCmd()
        {
            cmRetriCusDetail = new SqlCommand();
            cmCreateCustomer = new SqlCommand();



            cmRetriCusDetail.CommandText = "SELECT CustomerName, TelNum, Email"
                + " FROM Customer WHERE IDNumber=@IDNumber";
            cmRetriCusDetail.Connection = cn;

            cmCreateCustomer.CommandText = "INSERT INTO Customer(CustomerID,IDNumber,CustomerName,TelNum,Email) Values (@CustomerID,@IDNumber,@CustomerName,@TelNum,@Email)";
            cmCreateCustomer.Connection = cn;

           
        }
        public void CreateCusomter(Customer c)
        {
            SqlParameter pIDNumber = new SqlParameter("@IDNumber", SqlDbType.NVarChar, 10);
            pIDNumber.Value = c.IDNumber;

            SqlParameter pCustomerName = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 65);
            pCustomerName.Value = c.CustomerName;

            SqlParameter pTelNum = new SqlParameter("@TelNum", SqlDbType.NVarChar,10);
            pTelNum.Value = c.TelNum;

            SqlParameter pEmail= new SqlParameter("@Email", SqlDbType.NVarChar, 255);
            pEmail.Value = c.Email;

            // clear any previous parameters set before adding new parameters
            cmCreateCustomer.Parameters.Clear();
            cmCreateCustomer.Parameters.Add(pIDNumber);
            cmCreateCustomer.Parameters.Add(pCustomerName);
            cmCreateCustomer.Parameters.Add(pTelNum);
            cmCreateCustomer.Parameters.Add(pEmail);

            try
            {
               
                cmCreateCustomer.ExecuteNonQuery();
            }
             catch(Exception e)
             {
                Console.WriteLine(e.StackTrace);
            }

           
              
        }
        public Customer retrieveCustomer(string NRIC)
        {
            Customer c = new Customer();
            SqlParameter pIDNumber = new SqlParameter("@IDNumber", SqlDbType.NVarChar, 7);
            pIDNumber.Value = NRIC;
            cmRetriCusDetail.Parameters.Clear();
            cmRetriCusDetail.Parameters.Add(pIDNumber);
            
           
                SqlDataReader rdCustomer = cmRetriCusDetail.ExecuteReader();
               
                if (rdCustomer.Read())
                {
                    c.CustomerName = rdCustomer["CustomerName"].ToString();
                    c.TelNum = rdCustomer["TelNum"].ToString();
                    c.Email = rdCustomer["Email"].ToString();



                }
                    else
                    {
                return null;

                     }
             rdCustomer.Close();
            return c;
            
            }
        

        
        public static CustomerDAO Instance
        {
            get
            {
                if (dbInstance == null)
                {
                    dbInstance = new CustomerDAO();
                }

                return dbInstance;
            }
        }

        public void OpenConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }

 
        static void Main(string[] args)
        {
            CustomerDAO vehicleDAO = CustomerDAO.Instance;
            vehicleDAO.OpenConnection();

          //  Vehicle v = vehicleDAO.("BSS671Z");
            vehicleDAO.CloseConnection();


           // Console.WriteLine(v.PlateNum);
            Console.ReadLine();
        }
    }
}
