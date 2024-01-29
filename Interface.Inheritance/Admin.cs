namespace Interface.Inheritance;

public class Admin : IUserManager
{
    public string UserName;

    public string Password;

    private bool IsSuper = false;

    private int isAuth;

    public Admin()
    {
        UserName = "Abhishek";
        Password = "pass@1234";
        isAuth = 0; // GetCall to  Database set this
    }

    public void Display()
    {
        Console.WriteLine("IsSuper : {0}", IsSuper);
    }

    public void IsAdmin()
    {
        if (UserName == "Abhishek" && Password == "pass@1234" && isAuth == 0) 
            IsSuper = true;
    }
}
