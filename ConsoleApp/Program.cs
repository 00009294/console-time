using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Security;
using ConsoleApp.Services;
using System.Net;

class Program
{
    public static void Main()
    {
       Crypt crypt = new Crypt();
        var str = crypt.EnCrypt("Rizq");
        Console.WriteLine(str);
        Console.WriteLine(crypt.DeCrypt(str));
    }
   
}