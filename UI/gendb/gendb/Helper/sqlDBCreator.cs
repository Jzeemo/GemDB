using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gendb.Helper
{
    public static class sqlDBCreator
    {
        public static void Connection()
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand command;
            connetionString = @"Data Source=NB-1608-001\SQLEXPRESS2;Initial Catalog=GENDB;User ID=sa;Password=clw";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                string insertquery = string.Empty;
                for(int i=0;i<=1000000;i++)
                {
                    insertquery += "insert into def_1 (bigint,binary,bit,char,datetime,decimal,float,nvarchar,int,nchar,numeric) Values (1,1,1,'C',GetDate(),0.0,0.0,'test',1,'t',0);";
                }
                command = new SqlCommand(insertquery, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
              
            }
        }
    }
}