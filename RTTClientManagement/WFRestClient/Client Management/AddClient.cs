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

namespace WFRestClient.Client_Management
{
    public partial class AddClient : Form
    {
        ClientServiceRef.ClientServiceClient clientService = new ClientServiceClient();
        //ServiceReference.ClientServiceClient clientServiceClient = new ServiceReference.ClientServiceClient();
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            clientModel.Name = txtName.Text;
            clientModel.Gender = comboBox1.SelectedItem.ToString();

            
            ContactDetails contactDetails =new ContactDetails();
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

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }
    }
}
