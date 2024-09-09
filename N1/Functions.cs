using System.Reflection.Metadata;

namespace N1
{
    class Function
    {
        //static void Withoutarg()
        //{
        //    Console.WriteLine("i just call the method");
        //}
        //static void Car(string model = "BMW") {
        //    Console.WriteLine($" A car model is {model}");
        //}
        //static void Calculation(int x, int y)
        //{
        //    int a = x + y;
        //    Console.WriteLine($"Addition:{a}");
        //    int c = x - y;
        //    Console.WriteLine($"Substraction:{c}");
        //    int b = x * y;
        //    Console.WriteLine($"Multipilcation:{b}");
        //}
        ////-------------return-------------------
        //static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        ////------------------Method Overloading----------------------------
        //static string Add(string x)
        //{
        //    return x + "j";
        //}
        ////----------------Different parameter----------------------
        //static int Add(int x, int y,int z)
        //{
        //    return x + y + z;
        //}
        ////---------------Accessing with Key-----------------------
        //static string Vechile( string name,string color)
        //{
        //    return name  +" color is " + color;
        //}
        //----------------------enum---------------------------
        enum days
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday
        }

        static void Main(String[] args)
        {
            //Withoutarg();
            //Car();
            //Car("scoda");
            //Calculation( 5,3);
            //Console.WriteLine(Add(7, 4));
            //Console.WriteLine(Add(7, 4,6));
            //Console.WriteLine(Add("pharaneesh"));
            //Console.WriteLine(Vechile(name: "Bike", color: "Red"));
            //---------------------inher-----------------
            // Car obj1 = new Car();

            //    obj1.Honk();
            //    Console.WriteLine(obj1.brand + " " + obj1.modelName);
            //--------------poly-----------------------
            //college clg = new college();
            //cse cse = new cse();
            //ECE ece = new ECE();
            //EEE eee = new EEE();


            //clg.dept();
            //cse.dept();
            //ece.dept();
            //eee.dept();
            //-------------------abstract----------------------------
            //car car = new car();
            //car.carsound();
            //car.bike();
            //------------------------Interface----------------------
             //domo dg = new domo();    
             //dg.method();
             //dg.anothermethod();
             //----------------------enum---------------------------
             days current = days.sunday;
            Console.WriteLine(current);
        }
    }
}

