using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Models
{
    [DataContract]
    public class ClientDetails
    {
        int clientId;
        string name = string.Empty;
        string gender = string.Empty;
        string status = string.Empty;

        [DataMember]
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}