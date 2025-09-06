namespace RepositoryTemplateTest.Lib
{
    public class Class1
    {
        public static void SayHello(string[] args)
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
}
