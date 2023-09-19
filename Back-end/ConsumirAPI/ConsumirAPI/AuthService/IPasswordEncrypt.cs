namespace ConsumirAPI.AuthService
{
    public interface IPasswordEncrypt
    {
        string HashPassword(string password);
        bool VerifyPassword(string enteredPassword, string hashedPassword);
    }
}