
//ctrl k+d
using System; //namespace


class Program
{

    // entry point of the project
    // we can use method into another method
    static void Main()
    {
        Console.WriteLine("Hello world");
        Console.WriteLine("------------------------------------");

        method1();
        method2();

        Console.ReadLine();

    }

    static void method1()
    {
        Console.WriteLine("method1");
        method3();
    }

    static void method2()
    {
        Console.WriteLine("method2");
        method3();
    }

    static void method3()
    {
        Console.WriteLine("method3");
    }


    
}

