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

        private void tabClientDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientDetails_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientContact_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtWorkTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCell_Click(object sender, EventArgs e)
        {

        }

        private void txtCell_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPosAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtWorkAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtResAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
