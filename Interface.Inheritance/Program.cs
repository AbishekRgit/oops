
namespace Interface.Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        //User user = new User();

        //user.Display();
        //user.IsAdmin();
        //user.Display();


        //Admin admin = new Admin();

        //admin.Display();
        //admin.IsAdmin();
        //admin.Display();

        IUserManager userManager = new User();
        userManager.Display();
        userManager.IsAdmin();
        userManager.Display();

        userManager = new Admin();
        userManager.Display();
        userManager.IsAdmin();
        userManager.Display();
    }
}