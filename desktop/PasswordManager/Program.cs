using PasswordManager.Services;

namespace PasswordManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            UserService userService = new UserService();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage(userService));
        }
    }
}