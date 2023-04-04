
using Baseline.Reflection;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using ConsoleApp.Security;
using ConsoleApp.Services;
using ImTools;
using Newtonsoft.Json;
using System.Collections;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        
        string path = "D:/user.json";
        List<User> users = new List<User>()
        {
            new User()
            {
                Name = "Ali",
                Email = "Email"
            },
            new User()
            {
                Name = "Javlonbek",
                Email = "Email"
            },
            new User()
            {
                Name = "Abdurohman",
                Email = "Email"
            }

    }
}