using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Lens_Management.Classes
{
    public static class Cryptography
    {
        public static string ToMD5(string password)
        {
            string md5result = null;
            using (MD5 md5 = MD5.Create())
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(passwordBytes);
                md5result = Convert.ToBase64String(hashBytes);
            }

            return md5result;
        }

    }
}
