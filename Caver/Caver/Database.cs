using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Caver
{
    public class Database
    {
        string connectionString = @"Data Source=PIETERPC;Initial Catalog=carver;Integrated Security=True";
        SqlConnection connection;

        public void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public bool CheckPhoneExists(string phone)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Prospect WHERE Phone = '{phone}'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            CloseConnection();
            return count > 0;
        }

        public bool CheckEmailExists(string email)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Prospect WHERE Email = '{email}'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            CloseConnection();
            return count > 0;
        }

        public void Insert(string prospectInsert)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(prospectInsert, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Insertion completed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing INSERT query: " + ex.Message);
                }
            }
        }
    }
}