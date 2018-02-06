using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService.DAL
{
    class DBConnect
    {
        public static SqlConnection myCon = null;

        public void CreateConnection()
        {
            myCon = new SqlConnection("Data Source=RTTJHB_PMO02;Initial Catalog=ClientManagerDb;Integrated Security=True");
            myCon.Open();

        }
    }
}