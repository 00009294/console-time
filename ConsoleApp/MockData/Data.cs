using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MockData
{
    public class Data
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User() { Id = 1, Name = "Muhammad", Email = "muhammad@gmail.com", Password = "123456"},
            new User() { Id = 2, Name = "Umar", Email = "umar@gmail.com", Password = "123456"},
            new User() { Id = 3, Name = "Kholid", Email = "kholid@gmail.com", Password = "123456"},
            new User() { Id = 4, Name = "Valid", Email = "valid@gmail.com", Password = "123456"}
        };
    }
}
