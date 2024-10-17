using System;

class DatatypeConversation
{
    static void Main()
    {

        string age = "25";
        //int cage = int.Parse(age);
        int cage = Convert.ToInt32(age);
        Console.WriteLine(cage);

        double value   = 3.99;
        int cvalue = (int)value;   //convert
        Console.WriteLine(cvalue);


        int salary = 20000;
        string ssalary = salary.ToString();


        Console.WriteLine(DateTime.Now);
        string todayDate = DateTime.Now.ToString();


        string sName = null;

        //int cName1 = int.Parse(sName);
        //Console.WriteLine(cName1);

        int cName2 = Convert.ToInt32(sName);
        Console.WriteLine(cName2);
        //int cage = Convert.ToInt32(age);

        Console.ReadLine();


    }
}

