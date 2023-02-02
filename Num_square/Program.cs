System.Console.Write("Enter integer number: ");
if (int.TryParse(Console.ReadLine(), out int i))
{
    int res = (int)Math.Pow(i, 2);
    Console.WriteLine(res);
}
else
{
    System.Console.WriteLine("You entered not integer number");
}
