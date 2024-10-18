using System;

//put debugger(break point) and use f10 -> step over

class Arrays
{

    static void Main()
    {
        //int a = 1;

        int[] numbers = new int[2];

        numbers[0] = 10;
        numbers[1] = 20;

        //numbers[2] = 30;//error


        int firstNumber = numbers[0];
        Console.WriteLine(firstNumber);


        //  Logic
       
        //                  0   1   2  3    4
        int[] prices = { 10, 20, 30, 40, 50 };
        int secondNumber = prices[1];
        Console.WriteLine(secondNumber);

        int thirdNumber = prices[2]; // 30
        //200
        Console.WriteLine($"Before modify{thirdNumber}");

        prices[2] = 200;

        foreach(int price in prices)
        {
            Console.WriteLine(price);   // 10 , 20 , 200 , 40 , 50;
        }





        // General Example

        //Books  - English , Maths , sanskrt
        ////foreach --> Every
        foreach (int price in prices)
        {
            Console.WriteLine($"fruit price is - {price + 1000}");
        }


        string[] books = { "English", "Maths", "Sanskrit", "Hindi" };

        int length = books.Length;
        Console.WriteLine(length); // 4



        //loop
        //what is our task. print every book. then i need to pick everybook
                               //target
        foreach(string book in books)
        {
            Console.WriteLine(book + "has been completed." );
        }






        Console.ReadLine();

    }

}

