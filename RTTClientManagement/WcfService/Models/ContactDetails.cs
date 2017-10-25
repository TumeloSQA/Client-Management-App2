using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Models
{
    [DataContract]
    public class ContactDetails
    {
        int contactId;
        int clientId;
        string cellNumber = string.Empty;
        string workTel = string.Empty;

        [DataMember]
        public int ContactId
        {
            get { return contactId; }
            set { contactId = value; }
        }
        [DataMember]
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [DataMember]
        public string CellNumber
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }

        [DataMember]
        public string WorkTel
        {
            get { return workTel; }
            set { workTel = value; }
        }
    }
}