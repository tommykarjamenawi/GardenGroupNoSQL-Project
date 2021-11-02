using GardenGroupModel;
using System.Web.Helpers;

namespace GardenGroupLogic
{
    public class VerifyHashedPassword
    {
        UserService userService;
        public VerifyHashedPassword()
        {
            userService = new UserService();
        }
        public bool VerifyPassword(string PlainPassword, string email)
        {
            User user = userService.GetUserByEmailHashed(email);
            string salt = user.salt; // Salt from the database connected to the account
            string HashedPasswordWithSalt = user.Password; // hashed password with salt from database

            PlainPassword += salt; // append salt key

            bool result = Crypto.VerifyHashedPassword(HashedPasswordWithSalt, PlainPassword); //verify password
            return result;
        }
    }
}
