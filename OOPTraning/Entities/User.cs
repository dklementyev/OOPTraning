using System;
using System.Security.Cryptography;
namespace OOPTraning.Entities
{
    public abstract class User
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string UserName { get; private set; }

        //Some auth things
        private string Hash { get; set; }
        private string Salt { get; set; }
 
        /*  Use this manual: https://medium.com/@mehanix/lets-talk-security-salted-password-hashing-in-c-5460be5c3aae
         *  For Salting and Hashing methodology.
         */
        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var tokenDate = new byte[32];

                rng.GetBytes(tokenDate);

                return tokenDate;
            }
        }

        private void HashPassword(string pwd, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(pwd, salt, 10000);

            var hash = pbkdf2.GetBytes(20);

            var hashBytes = new byte[53];
            Array.Copy(salt, 0, hashBytes, 0, 32);
            Array.Copy(hash, 0, hashBytes, 32, 20);

            //Save Hash and Salt in private props. Until i have no db ofc :D
            Hash = Convert.ToBase64String(hashBytes);
            Salt = Convert.ToBase64String(salt);
        }

        public User(string name, string surName, string userName, string pwd)
        {
            Name = name;
            Surname = surName;
            UserName = userName;
            HashPassword(pwd, GenerateSalt());
        }

        public void ShowInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Name:\t\t{Name}");
            Console.WriteLine($"Sur name:\t{Surname}");
            Console.WriteLine($"Username:\t{UserName}");
            Console.WriteLine($"Hash:\t\t{Hash}");
            Console.WriteLine($"Salt:\t\t{Salt}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
