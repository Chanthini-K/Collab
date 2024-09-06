// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
namespace basics;
class G1
{
    public static void Main(String[] args)
    {
        //    Console.WriteLine("********Parameterized method***********");
        //    value(1, 2);
        //    Console.WriteLine("********non-Parameterized method***********");
        //    simple();
        //    Console.WriteLine("********Method Overloading***********");
        //    Console.WriteLine(add(3, 4));
        //    Console.WriteLine(add(3, 4, 5));
        //    Console.WriteLine(add(3, 4, 5, 1));
        //    Console.WriteLine("********Parameterized and No argument constructor ***********");
        //    G1 avi1 = new G1();
        //    G1 avi2 = new G1(43.2);

        //**************ENCAPSULATION*****************

        person p= new person();
        p.SetName("Chanthini");
        p.SetAge(22);

        Console.WriteLine("name : "+p.GetName());
        Console.WriteLine("Age : " + p.GetAge());




    }

    //public static void simple()
    //{
    //    Console.WriteLine("No argument method");
    //}

    //public static int value(int a, int b)
    //{
    //    Console.WriteLine(a + b);
    //    return a;
    //}
    ////METHOD OVERLOADING
    //public static int add(int a, int b)
    //{
    //    return (a + b);
    //}
    //public static int add(int a, int b, int c)
    //{
    //    return (a + b + c);
    //}
    //public static int add(int a, int b, int c, int d)
    //{
    //    return (a + b + c + d);
    //}
    //public G1()
    //{
    //    Console.WriteLine("This is no argument constructor");
    //}
    //public G1(double d)
    //{
    //    Console.WriteLine("This is Parameterized Constructor: " + d);
    //}
}


//**************ENCAPSULATION*****************
public class person
{
   
    //private fields -- Encapsulated data 
    private String name;
    private int age;

    //public method to set the name
    public void SetName(String name)
    {
        this.name = name;
    }

    public String GetName()
    {
        return name;

    }

    public void SetAge(int age)
    {
        this.age = age;

    }
    public int GetAge()
    {
        return age;
    }

}











