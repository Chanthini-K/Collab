// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Transactions;
namespace N1;
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

        //Person p = new Person();
        //p.SetName("Chanthini");
        //p.SetAge(22);

        //Console.WriteLine("name : " + p.GetName());
        //Console.WriteLine("Age : " + p.GetAge());

        //**************INHERITANCE*****************
        //Apple obj = new Apple();
        //obj.DisplayApple();

        //**************POLYMORPHISM*****************
        //Shapes[] s= new Shapes[] {new Square(),new Circle()};

        //foreach (Shapes shapes in s)
        //{
        //    shapes.Drawn();
        //}
        //**************ABSTRACTION*****************
        //Vehicle car = new Cars();
        //Vehicle Bike = new Bike();

        ////calling abstract method
        //Console.WriteLine("*********Abstract method***********");
        //car.StartEngine();
        //Bike.StartEngine();

        ////calling regular method
        //Console.WriteLine("**********Regular method************");
        //car.DisplayType();
        //Bike.DisplayType();

        //**************INTERFACE*****************
        //Payment credit = new Creditcard();
        //Payment debit = new Debitcard();
        //credit.paypayment(100);
        //debit.paypayment(200);

        Level myVar = Level.Medium;
        Console.WriteLine(myVar);



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
public class Person
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

//**************INHERITANCE*****************
public class Fruit
{
   public String Origin = "Kashmir";
    protected double price = 100;

    public void DisplayFruit()
    {
        Console.WriteLine("Fruit Origin: " + Origin);
        Console.WriteLine("Fruit Price: "+price);
    }
}
public class Apple:Fruit
{
    
    String taste = "Sweet";
    String color ="red";

    public void DisplayApple()
    {
        Console.WriteLine("Apple Origin : " + Origin);
        Console.WriteLine("Apple Price : " + price);
        Console.WriteLine("Apple taset : " + taste);
        Console.WriteLine("Apple Color : " + color);    

    }

}

//**************POLYMORPHISM*****************
public class Shapes
{
    public virtual void Drawn()
    {
        Console.WriteLine("Shape is drawn");
    }
}
public class Square : Shapes
{
    public override void Drawn()
    {
       Console.WriteLine("Square is drawn");
    }
}
public class Circle : Shapes 
{
    public override void Drawn()
    {
        Console.WriteLine("Circle  is drawn");
    }
}

//**************ABSTRACTION*****************
public abstract class Vehicle
{
    //abstarct method
    public abstract void StartEngine();
    public void DisplayType()
    {
        Console.WriteLine("This is a vehicle");
    }


}
public class Cars : Vehicle
{
    public override void StartEngine()
    {
        
       Console.WriteLine("Car engine started");
    }
}
public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }
}

//**************INTERFACE*****************
public interface Payment
{
    void paypayment(float amount);

}

//Implementation of interface
public class Creditcard : Payment 
{
    public void paypayment(float amount)
    {
        Console.WriteLine("Processing Credit card Payment : "+ amount);

    }
}
public class Debitcard : Payment
{
    public void paypayment(float amount)
    {
        Console.WriteLine("Processing Debit card Payment : "+ amount);
    }
}

enum Level
{
    Low,
    Medium,
    High
}


















