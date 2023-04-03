using ConsoleApp.Interfaces;
using ConsoleApp.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class AudentificationManger : IAudentificationManager
    {
        public bool Verify(string email, string password)
        {
            foreach(var user in Data.Users)
            {
                if(user.Email== email && user.Password == password)
                {
                    return true;
                }              
            }
            return false;
        }
    }
}
