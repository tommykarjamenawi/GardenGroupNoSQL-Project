using System.Web.Helpers;

namespace GardenGroupLogic
{
    public class HashWithSalt
    {
        public string hashedPassword;
        public string salt;
        public HashWithSalt(string pass)
        {
            salt = Crypto.GenerateSalt(); // salt key generator
            string password = pass + salt;
            hashedPassword = Crypto.HashPassword(password); // Hash (password + salt)
        }
    }
}
