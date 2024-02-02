using System.Data.SqlClient;

namespace ConsoleApp25
{
    internal class Program
    {
        public static string StrConn => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2;Integrated Security=True;Connect Timeout=30;";

        public SqlConnection _conn;

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first name: ");
            //string? FirstName = Console.ReadLine();
            //Console.WriteLine("Enter last name: ");
            //string? LastName = Console.ReadLine();
            //Console.WriteLine("Enter email: ");
            //string? Email = Console.ReadLine();
            //Console.WriteLine("Enter birthdate: ");
            //string? Date = Console.ReadLine();

            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2;Integrated Security=True;Connect Timeout=30;

            using(SqlConnection conn = new SqlConnection(StrConn))
            {
                var query = "SELECT * from Users";
                var cmd = new SqlCommand(query, conn);
                
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"{reader["FirstName"]}, {reader["LastName"]}, {reader["Email"]}, {reader["DateOfBirth"]}");
                    }
                }
            }

            Console.WriteLine("Hello, World!");
        }

        static void InsertQuery(string? FirstName, string? LastName, string? Email, string? Date)
        {
            try
            {

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}