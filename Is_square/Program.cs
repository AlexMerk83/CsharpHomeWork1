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

System.Console.WriteLine();
