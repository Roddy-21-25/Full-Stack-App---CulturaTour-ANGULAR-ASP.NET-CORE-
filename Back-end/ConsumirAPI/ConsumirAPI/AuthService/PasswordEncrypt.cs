using System.Security.Cryptography;
using System.Text;

namespace ConsumirAPI.AuthService
{
    public class PasswordEncrypt : IPasswordEncrypt
    {
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var encryptedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return encryptedPassword;
            }
        }
        public bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            var VerifyDBpassword = HashPassword(enteredPassword) == hashedPassword;
            if (VerifyDBpassword)
            {
                return VerifyDBpassword;
            }
            else
            {
                return false;
            }
        }

    }
}
