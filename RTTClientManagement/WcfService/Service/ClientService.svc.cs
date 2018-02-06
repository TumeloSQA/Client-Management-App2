using WcfService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.DAL;

namespace WcfService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClientDataService.svc or ClientDataService.svc.cs at the Solution Explorer and start debugging.


    public class ClientService : IClientService
    {
        private DbConnection dbConn = new DbConnection();

        public string InsertClientDetails(ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails)
        {
            string message;

            dbConn.openConnection();

            SqlCommand cmdClient = new SqlCommand("insert into ClientDetails(name,gender, status) " +
                "OUTPUT INSERTED.clientId " +
                "values(@name,@gender, 'Active')", dbConn.connection);
            
            cmdClient.Parameters.AddWithValue("@name", clientDetails.Name);
            cmdClient.Parameters.AddWithValue("@gender", clientDetails.Gender);

            var clientId = (int)cmdClient.ExecuteScalar();
            if (clientId > 0)
            {
                message = "Client : " + clientDetails.Name + " Details inserted successfully";
            }
            else
            {
                message = "Client : " + clientDetails.Name + " Details not inserted successfully";
            }

            SqlCommand cmdAddress = new SqlCommand("insert into ClientAddress(resAddress,workAddress,posAddress,clientId) values (@resAddress,@workAddress,@posAddress,@clientId)", dbConn.connection);
            cmdAddress.Parameters.AddWithValue("@resAddress", addressDetails.ResAddress);
            cmdAddress.Parameters.AddWithValue("@workAddress", addressDetails.WorkAddress);
            cmdAddress.Parameters.AddWithValue("@posAddress", addressDetails.PosAddress);
            cmdAddress.Parameters.AddWithValue("@clientId", clientId);

            int result = cmdAddress.ExecuteNonQuery();
            if (result == 1)
            {
                message = "Client : " + clientDetails.Name + " Address Details inserted successfully";
            }
            else
            {
                message = "Client : " + clientDetails.Name + " Address Details not inserted successfully";
            }

            SqlCommand cmdContact = new SqlCommand("insert into ClientContact(cellNumber,workTel,clientId) values (@cellNumber,@workTel,@clientId)", dbConn.connection);
            cmdContact.Parameters.AddWithValue("@cellNumber", contactDetails.CellNumber);
            cmdContact.Parameters.AddWithValue("@workTel", contactDetails.WorkTel);
            cmdContact.Parameters.AddWithValue("@clientId", clientId);

            int contactResult = cmdContact.ExecuteNonQuery();
            if (contactResult == 1)
            {
                message = "Client : " + clientDetails.Name + " Contact Details inserted successfully";
            }
            else
            {
                message = "Client : " + clientDetails.Name + " Contact Details not inserted successfully";
            }

            return message;
        }

        public DataSet GetClient(int clientId)
        {
            dbConn.openConnection();
            string sqlQuery = "SELECT ClientDetails.clientId, ClientDetails.name, ClientDetails.gender, " +
                "ClientAddress.resAddress,  ClientAddress.posAddress,  ClientAddress.workAddress, " +
                "ClientContact.cellNumber, ClientContact.workTel " +
                "FROM ClientDetails " +
                "INNER JOIN ClientAddress ON ClientDetails.clientId = ClientAddress.clientId " +
                "INNER JOIN ClientContact ON ClientDetails.clientId = ClientContact.clientId " +
                "WHERE ClientDetails.clientId = " + clientId;
            string clientQuery = "SELECT ClientDetails.clientId, ClientDetails.name,ClientDetails.gender," +
                "ClientContact.cellNumber, ClientContact.workTel, " +
                "ClientAddress.resAddress, ClientAddress.workAddress, ClientAddress.posAddress " +
                "FROM ClientDetails, ClientAddress, ClientContact " +
                "WHERE  ClientDetails.clientId = ClientAddress.clientId " +
                "AND ClientDetails.clientId = ClientAddress.clientId " +
                "AND ClientDetails.clientId = " + clientId;

            SqlCommand cmdClients = new SqlCommand(sqlQuery, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdClients);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmdClients.ExecuteNonQuery();

            return dataSet;
        }

        public DataSet GetClientDetails()
        {
            dbConn.openConnection();
            string sqlQuery = "SELECT ClientDetails.clientId, ClientDetails.name, ClientDetails.gender, ClientDetails.status , "
                       + "ClientAddress.resAddress,  ClientAddress.posAddress,  ClientAddress.workAddress, "
                       + "ClientContact.cellNumber, ClientContact.workTel "
                       + "FROM ClientDetails "
                       + "INNER JOIN ClientAddress ON ClientDetails.clientId = ClientAddress.clientId "
                       + "INNER JOIN ClientContact ON ClientDetails.clientId = ClientContact.clientId";
            SqlCommand cmdClients = new SqlCommand(sqlQuery, dbConn.connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdClients);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmdClients.ExecuteNonQuery();
            
            return dataSet;
        }

        public int DeleteClient(int clientId)
        {
            dbConn.openConnection();
            string sqlClientDelete = "UPDATE ClientDetails "
                                    + "SET status = '" + "NOT ACTIVE" + "'"
                                    + " WHERE clientId = " + clientId;
            SqlCommand cmdUpdateClient = new SqlCommand(sqlClientDelete, dbConn.connection);
            return cmdUpdateClient.ExecuteNonQuery();
        }

        public int UpdateClient(int clientId, ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails)
        {
            dbConn.openConnection();
            string sqlClientUpdate = "UPDATE ClientDetails "
                                    + "SET name = '" + clientDetails.Name + "'"
                                    + " WHERE clientId = " + clientId;
            SqlCommand cmdUpdateClient = new SqlCommand(sqlClientUpdate, dbConn.connection);
            cmdUpdateClient.ExecuteNonQuery();

            string sqlAddressUpdate = "UPDATE ClientAddress "
                                   + "SET resAddress = '" + addressDetails.ResAddress + "'"
                                   + ", posAddress = '" + addressDetails.PosAddress + "'"
                                   + ", workAddress = '" + addressDetails.WorkAddress + "'"
                                   + "WHERE clientId = " + clientId;
            SqlCommand cmdUpdateAddress = new SqlCommand(sqlAddressUpdate, dbConn.connection);
            cmdUpdateAddress.ExecuteNonQuery();


            string sqlContactUpdate = "UPDATE ClientContact "
                                   + "SET cellNumber = '" + contactDetails.CellNumber + "'"
                                   + ", workTel = '" + contactDetails.WorkTel + "'"
                                   + "WHERE clientId = " + clientId;

            SqlCommand cmdUpdateContact = new SqlCommand(sqlContactUpdate, dbConn.connection);
            int res = cmdUpdateContact.ExecuteNonQuery();


            return res;
        }


    }
}
