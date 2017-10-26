using WcfService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;

namespace WcfService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientDataService" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        string InsertClientDetails(ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        DataSet GetClientDetails();
        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        DataSet GetClient(int clientID);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        int DeleteClient(int clientId);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]   
        int UpdateClient(int clientId, ClientDetails clientDetails, AddressDetails addressDetails, ContactDetails contactDetails);

    }

}
