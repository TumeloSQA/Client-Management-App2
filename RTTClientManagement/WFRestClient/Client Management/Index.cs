using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFRestClient.ClientServiceRef;
using WFRestClient.ClientServiceRef1;

namespace WFRestClient.Client_Management
{
    public partial class Index : Form
    {
        ClientServiceRef1.IClientSPServiceClient clientServiceClient = new IClientSPServiceClient();
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            DataSet ds = clientServiceClient.GetClients();
            var clientTable = ds.Tables[0];

            ClientDGView.DataSource = clientTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientName = textBox1.Text;
            DataSet ds = clientServiceClient.GetClientByName(clientName);
            var clientTable = ds.Tables[0];

            ClientDGView.DataSource = clientTable;
        }
    }
}
