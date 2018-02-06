using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.DAL;
using WcfService.Models;

namespace WcfService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IClientSPService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IClientSPService.svc or IClientSPService.svc.cs at the Solution Explorer and start debugging.
    public class IClientSPService : IIClientSPService
    {
        private DbConnection dbConn = new DbConnection();
        public string InsertClientDetails(ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails)
        {
            string message;

            dbConn.openConnection();

            SqlCommand cmd = new SqlCommand("nsp_createClient @name,@gender" +
                ",@cellNumber,@workTel," +
                "@resAddress,@workAddress,@posAddress", dbConn.connection);

            //Insert Client Details
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = clientDetails.Name;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar, 100).Value = clientDetails.Gender;

            //Insert Client Contact
            cmd.Parameters.Add("@cellNumber", SqlDbType.VarChar, 100).Value = contactDetails.CellNumber;
            cmd.Parameters.Add("@workTel", SqlDbType.VarChar, 100).Value = contactDetails.WorkTel;

            //Insert Client Address
            cmd.Parameters.Add("@resAddress", SqlDbType.VarChar, 100).Value = addressDetails.ResAddress;
            cmd.Parameters.Add("@workAddress", SqlDbType.VarChar, 100).Value = addressDetails.WorkAddress;
            cmd.Parameters.Add("@posAddress", SqlDbType.VarChar, 100).Value = addressDetails.PosAddress;

            cmd.ExecuteNonQuery();

            message = clientDetails.Name + " Added Succesfully";

            return message;
        }

        public DataSet GetClientByName(string clientName)
        {

            dbConn.openConnection();

            SqlCommand cmd = new SqlCommand("nsp_selectClientDetails @clientName", dbConn.connection);

            //Filter Client Details
            cmd.Parameters.Add("@clientName", SqlDbType.VarChar, 100).Value = clientName;


            //SqlCommand cmdClients = new SqlCommand(cmd, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmd.ExecuteNonQuery();

            return dataSet;


        }

        public DataSet GetClients()
        {

            dbConn.openConnection();

            SqlCommand cmd = new SqlCommand("nsp_selectClients", dbConn.connection);

            
            //SqlCommand cmdClients = new SqlCommand(cmd, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmd.ExecuteNonQuery();

            return dataSet;


        }
    }
}
