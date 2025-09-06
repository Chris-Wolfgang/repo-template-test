using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace RepositoryTemplateTest.App;

public class ProgramApp
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments provided.");
        }
        else
        {
            var sqlCommandText = $" SELECT * FROM {args[0]} WHERE ColumnA = '{args[1]}'";
            Console.WriteLine($"Arguments provided: {string.Join(", ", args)}");
        }

        string connectionString = "Server=myserver;Database=mydb;User Id=admin;Password=SuperSecret123;";

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // Vulnerable to SQL injection!
            string sql = "SELECT * FROM Users WHERE Username = '" + args[0] + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
        }
    }

    void ConnectWithHardcodedPassword()
    {
        string password = "SuperSecret123"; // DevSkim should flag this
        Console.WriteLine($"Password: {password}");
    }

    void UseInsecureCrypto()
    {
        var des = DES.Create(); // DevSkim will flag use of DES as insecure
        byte[] key = des.Key;
        byte[] iv = des.IV;
    }


    void SqlInjectionRisk(string userInput)
    {
        string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'"; // DevSkim will flag this
        Console.WriteLine(query);
    }
}