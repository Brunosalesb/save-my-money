using SaveMyMoney.Domain.ValueObjects;
using System;
using System.Text;

namespace SaveMyMoney.Domain.Entities
{
    public class User
    {

        protected User() { }
        public User(string email, Name name, string password)
        {
            Email = email;
            Name = name;
            Password = EncryptPassword(password);
            SignUpDate = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public Name Name { get; private set; }
        public string Password { get; private set; }
        public DateTime SignUpDate { get; private set; }

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return "";
            var password = (pass += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}
