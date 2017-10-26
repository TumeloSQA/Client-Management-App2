using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using WFRestClient.ClientServiceRef;

namespace WFRestClient.Client_Management
{
    public partial class HomeForm : Form
    {
        ClientServiceRef.ClientServiceClient clientServiceClient = new ClientServiceClient();
        //ClientServiceRef.ClientServiceClient clientServiceClient = new ClientServiceRef.ClientServiceClient();
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            
            DataSet ds = clientServiceClient.GetClientDetails();
            var clientTable = ds.Tables[0];

            ClientDGView.DataSource = clientTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClient addClient  = new AddClient();
            Hide();
            addClient.Show();
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Tumelo\RTTClients.txt");
            for (int i = 0; i < ClientDGView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < ClientDGView.Columns.Count - 2; j++)
                {
                    writer.Write("\t" + ClientDGView.Rows[i].Cells[j].Value.ToString() + "\t" + ",");
                }
                writer.WriteLine("");
                writer.WriteLine("-----------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            Hide();
            addClient.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            int i = ClientDGView.SelectedCells[0].RowIndex;
            clientModel.ClientId = (int)ClientDGView.CurrentRow.Cells[0].Value;
            clientModel.Name = ClientDGView.Rows[i].Cells[1].Value.ToString();


            ContactDetails contactDetails = new ContactDetails();
            //Client Contact
            contactDetails.CellNumber = ClientDGView.Rows[i].Cells[7].Value.ToString();
            contactDetails.WorkTel = ClientDGView.Rows[i].Cells[8].Value.ToString();

            //Client Address
            AddressDetails clientAddress = new AddressDetails();
            clientAddress.WorkAddress = ClientDGView.Rows[i].Cells[5].Value.ToString();
            clientAddress.ResAddress = ClientDGView.Rows[i].Cells[4].Value.ToString();
            clientAddress.PosAddress = ClientDGView.Rows[i].Cells[6].Value.ToString();

            clientServiceClient.UpdateClient(clientModel.ClientId, clientModel, clientAddress, contactDetails);

            MessageBox.Show("Client Updated Succesfully", "Update Status", MessageBoxButtons.OK);

            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            int i = ClientDGView.SelectedCells[0].RowIndex;
            clientModel.ClientId = (int)ClientDGView.CurrentRow.Cells[0].Value;
            clientModel.Status = "NOT ACTIVE";
            

            clientServiceClient.DeleteClient(clientModel.ClientId);

            MessageBox.Show("Client Deleted Succesfully", "Delete Status", MessageBoxButtons.OK);

            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            int i = ClientDGView.SelectedCells[0].RowIndex;
            clientModel.ClientId = (int)ClientDGView.CurrentRow.Cells[0].Value;
            clientModel.Name = ClientDGView.Rows[i].Cells[1].Value.ToString();


            ContactDetails contactDetails = new ContactDetails();
            //Client Contact
            contactDetails.CellNumber = ClientDGView.Rows[i].Cells[7].Value.ToString();
            contactDetails.WorkTel = ClientDGView.Rows[i].Cells[8].Value.ToString();

            //Client Address
            AddressDetails clientAddress = new AddressDetails();
            clientAddress.WorkAddress = ClientDGView.Rows[i].Cells[5].Value.ToString();
            clientAddress.ResAddress = ClientDGView.Rows[i].Cells[4].Value.ToString();
            clientAddress.PosAddress = ClientDGView.Rows[i].Cells[6].Value.ToString();

            clientServiceClient.UpdateClient(clientModel.ClientId, clientModel, clientAddress, contactDetails);

            MessageBox.Show("Client Updated Succesfully", "Update Status", MessageBoxButtons.OK);

            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDetails clientModel = new ClientDetails();
            //Client Details
            int i = ClientDGView.SelectedCells[0].RowIndex;
            clientModel.ClientId = (int)ClientDGView.CurrentRow.Cells[0].Value;
            clientModel.Status = "NOT ACTIVE";


            clientServiceClient.DeleteClient(clientModel.ClientId);

            MessageBox.Show("Client Deleted Succesfully", "Delete Status", MessageBoxButtons.OK);

            HomeForm home = new HomeForm();
            Hide();
            home.Show();
        }
    }
}
