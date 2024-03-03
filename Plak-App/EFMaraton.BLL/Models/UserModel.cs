using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(value));
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in hashedBytes)
                    {
                        sb.Append(item.ToString("x2"));
                    }
                    _Password = sb.ToString();
                }
            }
        }

    }
}
