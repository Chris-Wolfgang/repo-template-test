namespace RepositoryTemplateTest;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Hello, World!");
        }
        else
        {
            Console.WriteLine($"Arguments: {string.Join(", ", args)}");
        }
    }
}

