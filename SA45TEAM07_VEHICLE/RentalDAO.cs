using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SA45TEAM07_VEHICLE
{
    class RentalDAO
    {
        SqlConnection cn;
        SqlCommand cmInsertRentalRecord;
        SqlCommand cmSelCustomerbyUqK;

        private static RentalDAO dbInstance;

        private RentalDAO()
        {
            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|VehicleRental.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            initializeSQLCmd();
        }

        private void initializeSQLCmd()
        {
            cmInsertRentalRecord = new SqlCommand();
            cmSelCustomerbyUqK = new SqlCommand();

            cmInsertRentalRecord.CommandText =
                "Insert into RentalRecord (CustomerID, PlateNum, RentalPeriod, RentStartDate) " +
                " values (@CustomerID, @PlateNum, @RentalPeriod, @RentStartDate)";
            cmInsertRentalRecord.Connection = cn;

            cmSelCustomerbyUqK.CommandText =
               "Select CustomerID, IDNumber, CustomerName, TelNum, Email from Customer WHERE IDNumber =@IDNumber";
            cmSelCustomerbyUqK.Connection = cn;

        }
        public static RentalDAO getInstance()
        {

            if (dbInstance == null)
                dbInstance = new RentalDAO();

            return dbInstance;
        }

        public void openConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }

        public void InsertRentalRecord(RentalRecord record)
        {

            SqlParameter pCustomerId =
                 new SqlParameter("@CustomerID", SqlDbType.BigInt, 8);
            SqlParameter pPlateNum =
                new SqlParameter("@PlateNum", SqlDbType.NVarChar, 10);
            SqlParameter pRentalPeriod =
                new SqlParameter("@RentalPeriod", SqlDbType.SmallInt, 2);
            SqlParameter pRentStartDate =
                new SqlParameter("@RentStartDate", SqlDbType.Date, 3);

            cmInsertRentalRecord.Parameters.Clear();
            cmInsertRentalRecord.Parameters.AddRange(new SqlParameter[]
                      { pCustomerId, pPlateNum, pRentalPeriod, pRentStartDate });

            pCustomerId.Value = record.RentingCustomer.CustomerID;
            pPlateNum.Value = record.RentedVehicle.PlateNum;
            pRentalPeriod.Value = record.RentalPeriod;
            pRentStartDate.Value = record.RentStartDate;

            cmInsertRentalRecord.ExecuteNonQuery();
        }      

        public Customer RetrieveCustomer(String id)
        {
            SqlParameter pIDNumber =
                 new SqlParameter("@IDNumber", SqlDbType.NVarChar, 10);
            pIDNumber.Value = id;

            cmSelCustomerbyUqK.Parameters.Clear();
            cmSelCustomerbyUqK.Parameters.Add(pIDNumber);


            Customer c = new Customer(); ;
            
            // execute reader
            SqlDataReader rd = cmSelCustomerbyUqK.ExecuteReader();
            if (rd.Read())
            {
                c.Name = rd["CustomerName"].ToString();
                c.TelNum = rd["TelNum"].ToString();
                c.Email = rd["Email"].ToString();
                c.CustomerID = Int64.Parse(rd["CustomerID"].ToString());
            }
            else
            {
                throw new VehicleException(VehicleMessage.CustomerRecordNotFound);
            }

            // close reader
            rd.Close();
            return c;
        }

        [STAThread]
        static void Main(string[] args)
        {
            RentalDAO RentalDAO = RentalDAO.getInstance();
            RentalDAO.openConnection();

            Customer c = RentalDAO.RetrieveCustomer("I8877640T");
            RentalDAO.CloseConnection();

            Console.WriteLine(c.Name);
            Console.ReadLine();

        }
    }
}
