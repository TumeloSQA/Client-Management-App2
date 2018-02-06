using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFRestClient.ClientServiceRef1;

namespace WFRestClient.Client_Management
{
    public partial class CreateClient : Form
    {
        ClientServiceRef1.IClientSPServiceClient clientService = new IClientSPServiceClient();
        public CreateClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            clientModel.Name = txtName.Text;
            clientModel.Gender = comboBox1.SelectedItem.ToString();


            ContactDetails contactDetails = new ContactDetails();
            //Client Contact
            contactDetails.CellNumber = txtCell.Text;
            contactDetails.WorkTel = txtWorkTel.Text;

            //Client Address
            AddressDetails clientAddress = new AddressDetails();
            clientAddress.WorkAddress = txtWorkAddress.Text;
            clientAddress.ResAddress = txtResAddress.Text;
            clientAddress.PosAddress = txtPosAddress.Text;

            clientService.InsertClientDetails(clientModel, clientAddress, contactDetails);

            MessageBox.Show("Client Added Succesfully", "Create Status", MessageBoxButtons.OK);

            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }

        private void CreateClient_Load(object sender, EventArgs e)
        {

        }
    }
}
