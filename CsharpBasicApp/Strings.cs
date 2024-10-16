using System;

class Strings
{
    static void Main()
    {
        string strName = "Csharp";

        Console.WriteLine("first " + strName);

        string strName1 = "\"Csharp\"";
        Console.WriteLine("second " + strName1);

        string strName2 = "One\n Two \n Three";
        Console.WriteLine(strName2);

    

        //string path = "D:\\Teaching\\GrowTech\\CSharp\\CsharpBasicApp";

        string path = @"D:\Teaching\GrowTech\CSharp\CsharpBasicApp";
        Console.WriteLine(path);

        //string interpolation

        int age = 30;
        string clientName = "Alice";

        string details = $"{clientName} and {age}";   // 30 Aliice
        Console.WriteLine(details);

        /*
            string is class which contains the set of the members
            properties  : used for data access
            methods     : used for exectues the actions followed by()
         */


        string text = "This is a sample string.";
        int length = text.Length;
        Console.WriteLine($"Length of string is {length}");


        string studetn3 = "KeerThaNa";
        string lowerCasestudent3 = studetn3.ToLower();
        Console.WriteLine(lowerCasestudent3);





        //compare two strings.

        string student1 = "Karthik";
        string student2 = "Karthik";
        bool isOk = false;

       bool isEqual = student1.Equals(student2);
       Console.WriteLine(isEqual);

        //student2 == student2


       string text1 = "Thisisasamplestring.";
       string startText1 = text1.Substring(7, 5);
       Console.WriteLine(startText1);


        string student4 = "Siva";

       int indexOfStudent4  = student4.IndexOf('v');
        Console.WriteLine(indexOfStudent4);

     





        Console.ReadLine();


    }
}

