

using Microsoft.Data.SqlClient;

public class InsecureQuery
{
    public void GetUser(string username)
    {
        var connectionString = "your-connection-string-here";
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // Vulnerable to SQL injection!
            string sql = "SELECT * FROM Users WHERE Username = '" + username + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
        }
    }
}