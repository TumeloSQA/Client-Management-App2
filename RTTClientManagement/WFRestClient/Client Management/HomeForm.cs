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

namespace WFRestClient.Client_Management
{
    public partial class HomeForm : Form
    {
        ServiceReference.ClientServiceClient clientServiceClient = new ServiceReference.ClientServiceClient();
        //ClientServiceRef.ClientServiceClient clientServiceClient = new ClientServiceRef.ClientServiceClient();
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
            DataSet ds = clientServiceClient.GetClientDetails();
            var clientTable = ds.Tables[0];

            ClientDGView.DataSource = clientTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClient addClient  = new AddClient();
            addClient.Show();
        }

       
    }
}
