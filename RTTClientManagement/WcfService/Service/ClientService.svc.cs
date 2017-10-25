﻿using WcfService.Models;
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

            SqlCommand cmdClient = new SqlCommand("insert into ClientDetails(name,gender) OUTPUT INSERTED.clientId values(@name,@gender)", dbConn.connection);
            //cmdClient.Parameters.AddWithValue("@clientId", clientDetails.ClientId);
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

        public DataSet GetClientDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=LUTHULCOMP2\SQLEXPRESS;Initial Catalog=ClientManagerDb;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT ClientDetails.clientId, ClientDetails.name,ClientDetails.gender,ClientDetails.cellNumber, ClientDetails.workTel, ClientAddress.resAddress, ClientAddress.workAddress, ClientAddress.posAddress FROM ClientDetails, ClientAddress WHERE  ClientDetails.clientId = ClientAddress.clientId", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return ds;
        }

        public int DeleteClient(int clientId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=LUTHULCOMP2\SQLEXPRESS;Initial Catalog=ClientManagerDb;Integrated Security=True"))
                {

                    string strCommand = "DELETE FROM ClientDetails WHERE clientId = " + clientId;
                    sqlConnection.Open();
                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = sqlConnection;
                    cmdDelete.CommandType = CommandType.Text;
                    cmdDelete.CommandText = strCommand;
                    return cmdDelete.ExecuteNonQuery();
                }
            }
            catch (SqlException exception)
            {
                throw (exception);
            }
        }


    }
}
