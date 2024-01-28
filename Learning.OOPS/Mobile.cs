using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace
namespace Classes;

//Class
public class Mobile
{
    // Property
    string phoneModel;

    // Constructor - constructor name and class name should be same
    public Mobile()
    {
        phoneModel = "Samsung";
    }
    // Method
    public void Display()
    {
        Console.WriteLine(phoneModel);
    }
        


}
