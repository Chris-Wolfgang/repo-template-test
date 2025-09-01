namespace RepositoryTemplateTest;

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
            Console.WriteLine($"Arguments provided: {string.Join(", ", args)}");
        }
    }
}

