using System.Security.Cryptography;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



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
