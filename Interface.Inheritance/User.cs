namespace Interface.Inheritance;

internal class User : IUserManager
{
    public string UserName;

    public string Password;

    private bool IsSuper = false;

    public User()
    {
        UserName = "Abhishek";
        Password = "pass@1234";
    }

    public void Display()
    {
        Console.WriteLine("IsSuper : {0}", IsSuper);
    }

    public void IsAdmin()
    {
        if(UserName == "Abhishek" &&  Password == "pass@123")
            IsSuper = true;
    }
}
