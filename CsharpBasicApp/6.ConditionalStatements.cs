using System;
class ConditionalStatements
{

    //Think as per client mindset....

    //if elseif else switch

    // yes -> then go head
    // no  -> you are not allowed

    static void Main()
    {
        //string studentName = "sbdjkvasdfas";

        // //5 < 10   5

        // if(studentName == "Siva")
        // {
        //     Console.WriteLine("Hey!!!! I am siva");
        // }
        // else if(studentName == "Karthik")
        // {
        //     Console.WriteLine("Hey!!!! I am Karthik");
        // }
        // else if(studentName == "Keerthi")
        // {
        //     Console.WriteLine("Hey!!!! I am Keerthi");
        // }
        // else
        // {
        //     Console.WriteLine("Expected Student was not found!!!!!!");
        // }

        // Console.WriteLine("Completed Task!!!");




        string studentName = "12345";

        switch (studentName)
        {
            case "Keerthi":
                {
                    Console.WriteLine("Hey !! iam keerthi");
                    break;
                }
            case "Karthik":
                {
                    Console.WriteLine("Hey !! iam Karthik");
                    break;
                }
            case "Siva":
                {
                    Console.WriteLine("Hey !! iam Siva");
                    break;
                }
            default:
                {
                    Console.WriteLine("no student found");
                    break;
                }


        }


        Console.WriteLine("Completed Task!!!");


        Console.ReadLine();

    }


    // > < == != 



}

