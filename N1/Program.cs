// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
namespace basics;
class G1
{
    public static void Main(String[] args)
    {
        Console.WriteLine("********Parameterized method***********");
        value(1, 2);
        Console.WriteLine("********non-Parameterized method***********");
        simple();
        Console.WriteLine("********Method Overloading***********");
        Console.WriteLine(add(3, 4));
        Console.WriteLine(add(3, 4, 5));
        Console.WriteLine(add(3, 4, 5, 1));
        Console.WriteLine("********Parameterized and No argument constructor ***********");
        G1 avi1 = new G1();
        G1 avi2 = new G1(43.2);




    }
    public static int value(int a, int b)
    {
        Console.WriteLine("parameterized method");
        Console.WriteLine(a + ", " + b);
        return a;
    }
    public static void simple()
    {
        Console.WriteLine("No argument method");
    }
    //METHOD OVERLOADING
    public static int add(int a, int b)
    {
        return (a + b);
    }
    public static int add(int a, int b, int c)
    {
        return (a + b + c);
    }
    public static int add(int a, int b, int c, int d)
    {
        return (a + b + c + d);
    }
    public G1()
    {
        Console.WriteLine("This is no argument constructor");
    }
    public G1(double d)
    {
        Console.WriteLine("This is Parameterized Constructor: " + d);
    }
    
   
}


