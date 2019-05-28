using System;
using System.Data;
using System.Data.SqlClient;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("DB Test");

                string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTemp;
                 Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                 ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                string queryString = @"insert into Descriptions (Name, Description) 
                                    values (@Name, @Description)";

                string description = "A description of sorts";


                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    SqlCommand command = new SqlCommand(queryString, conn);
                    command.Parameters.Add("@Name", SqlDbType.VarChar);
                    command.Parameters.Add("@Description", SqlDbType.VarChar);

                    command.Parameters["@Name"].Value = "Howdy";
                    command.Parameters["@Description"].Value = description;

                    conn.Open();
                    int rows = command.ExecuteNonQuery();

                    Console.WriteLine("Rows: {0}", rows);
                    


                }

            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
