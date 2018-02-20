using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;

namespace WcfService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIClientSPService" in both code and config file together.
    [ServiceContract]
    public interface IIClientSPService
    {
        [OperationContract]
        string InsertClientDetails(ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        DataSet GetClientByName(string clientName);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        DataSet GetClients();

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int UpdateClient(ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails);
    }
}
