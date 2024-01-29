
// Namespace
namespace Class.Static;

//Class
public class Dog
{
    //  camelCase, PascalCase, snake_case, _case

    // Instance Variables
    public static string Name;
    static string Breed;
    static int Age;
    static string Color;

    // Constructor Declaration of Class - Parameterised Constructor
    public Dog(string name, string breed,int age, string color)
    {
        // local variable, parameter always lower or camelCase

        Name = name;
        Breed = breed;
        Age = age;
        Color = color;
    }

    // Property 1  - Pascal Case
    static string GetName()
    {
        return Name;
    }

    // Property 2
    static string GetBreed()
    {
        return Breed;
    }

    // Property 3
    static int GetAge()
    {
        return Age;
    }

    // Property 4
    static string GetColor()
    {
        return Color;
    }

    // Method 1
    public static bool Display()
    {
        Console.WriteLine("Hi my name is {3}  My breed is: {0}, age is {1} and color is {2} ", GetBreed(),
                GetAge() ,GetColor(), GetName());

        return true;
    }
}

