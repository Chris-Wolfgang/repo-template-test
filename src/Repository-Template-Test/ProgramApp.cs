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

        var username = "admin";
        string sql = "SELECT * FROM Users WHERE Username = '" + username + "'";
        string password = "SuperSecret123!";
        var md5 = System.Security.Cryptography.MD5.Create();
    }
}