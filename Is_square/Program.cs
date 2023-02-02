System.Console.WriteLine("Choose the task:");
System.Console.WriteLine("1 - Is square");
System.Console.WriteLine("2 - Day of the week");

if (int.TryParse(Console.ReadLine(), out int taskNo))
{
    if (taskNo == 1)
    {
        System.Console.WriteLine("Enter two numbers");

        if (double.TryParse(Console.ReadLine(), out double a) & double.TryParse(Console.ReadLine(), out double b))
        {
            if (Math.Pow(b, 2) == a)
            {
                System.Console.WriteLine("Yes");
            }
            else
            {
                System.Console.WriteLine("No");
            }
        }
        else
        {
            System.Console.WriteLine("These are not numbers");
        }
    }
    else if (taskNo == 2)
    {
        System.Console.WriteLine("Enter number of the day 1..7");
        if (int.TryParse(Console.ReadLine(), out int dayNo))
        {
            if (dayNo == 1) System.Console.WriteLine("Monday");
            if (dayNo == 2) System.Console.WriteLine("Tuesday");
            if (dayNo == 3) System.Console.WriteLine("Wednesday");
            if (dayNo == 4) System.Console.WriteLine("Thirsday");
            if (dayNo == 5) System.Console.WriteLine("Friday");
            if (dayNo == 6) System.Console.WriteLine("Satturday");
            if (dayNo == 7) System.Console.WriteLine("Sunday");
            if (dayNo < 1 || dayNo > 7) System.Console.WriteLine("There is no such day of the week");
        }
        else
        {
            System.Console.WriteLine("There is no such day of the week");  
        }
    }
    else
    {
        System.Console.WriteLine("There is no such option");
    }
}
else
{
    System.Console.WriteLine("There is no such option");   
}
