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

        var insecure = new InsecureQuery();
        insecure.GetUser("admin' --");
    }
}