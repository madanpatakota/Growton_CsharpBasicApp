using System;

class Operators
{
 

    // As the developer you must aware of the data.

    //void methods
    static void Main()
    {

        //Arthamatic operators + , 1 , * , / , %
        int sum = 5 + 3;
        //Console.WriteLine(sum); //8

        int difference = 10 - 4; // difference is 6

        int product = 3 * 4; // product is 12

        decimal result = 3.17m * 2.17m;

        int result1 = 10 / 2; //5

        decimal remainder = 10 % 3; //1


        //Comparsion operators  ,  == , != , > , < , >= , <=


        //bool isEqual = 5 == 1; // false
        //Console.WriteLine(isEqual);

        // 5 is not equal to 1

        //bool isEqual = 5 != 5;  // true
        //Console.WriteLine(isEqual);

        bool isGreater = (8 > 5); // true

        bool isLess = (3 < 7);    // true

        bool isGreaterOrEqual = (8 >= 8); //true

        bool isLessOrEqual = (3 <= 7);  // true


        //Logical operators  && , !! , !

        /*
         *    True && True -> T 
         *    True && false -> F
         *    false && true -> F
         *    false && false -> f
         *    
         *    
         *    True  || True -> T 
         *    True  || false -> T
         *    false || true  -> T
         *    false || false -> f
         *    
         *    
         *    !T  -> f
         *    !f  -> T
         *    
         */

        //bool isEqual1 = (5 > 100) && (3 == 3); //True && True->T
        //Console.WriteLine($" isequal 1 : {isEqual1}"); //true


        //bool isEqual2 = (5 > 100) || (3 == 3); //True && True->T
        //Console.WriteLine($" isequal 2 : {isEqual2}"); //true

        bool isEqual3 =  !(3 <= 3);
        //Console.WriteLine($" isequal 3 : {isEqual3}");




       //nullbale types

      //  int age = 0;   0-9  0


      // int? age = null;

        int? age = null;
        Console.WriteLine(age);

        bool? nullableBool = null;

        Console.ReadLine();

    }
}

