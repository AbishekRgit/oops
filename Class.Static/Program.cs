// C# program to illustrate the
// Initialization of an Reference
using Class.Static;

// Class Declaration
public class Program
{
    // Main Method
    public static void Main(string[] args)
    {

        // Creating object
        Dog tuffy = new Dog("tuffy", "papillon", 5, "white");

        //tuffy.Display();


        // Call properties without object.
        Dog.Name = "CAT";
        Dog.Display();

    }
}
