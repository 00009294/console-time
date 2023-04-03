using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Security
{
    public class Crypt
    {
        public const byte _key = 4;
        public string EnCrypt(string message)
        {
            StringBuilder stringBuilder= new StringBuilder();
            foreach(var letter in message)
            {
                var crypted = (char)(letter + _key);
                stringBuilder.Append(crypted);
            }
            return stringBuilder.ToString();
        }
        public string DeCrypt(string message)
        {
            StringBuilder stringBuilder= new StringBuilder();
            foreach(var letter in message)
            {
                var deCrypted = (char)(letter - _key);
                stringBuilder.Append(deCrypted);
            }
            return stringBuilder.ToString();
        }
    }
}
