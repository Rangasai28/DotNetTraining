using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODisconnectedArchDemo
{
    internal class DatasetHelper
    {
        SqlConnection? connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PRODUCTDB;Integrated Security=True;Pooling=False");
        DataSet dataset = new DataSet();
        SqlDataAdapter adapter;
        SqlCommandBuilder? command;
       
        public DataSet fetchData()
        {
            
            string query = "SELECT * FROM PRODUCT";
            adapter = new SqlDataAdapter(query,connect);
            command = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset);
            return dataset;
        }


        public void  modifyData()
        {
            adapter.Update(dataset);
        }
    }
}
