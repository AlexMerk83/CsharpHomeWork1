bool isWork = true;

while (isWork)
{
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Task 2: Max of two");
    System.Console.WriteLine("2 - Task 4: Max of three");
    System.Console.WriteLine("3 - Task 6: Is even");
    System.Console.WriteLine("4 - Task 8: Even numbers");
    System.Console.WriteLine("0 - Exit");
    System.Console.Write("Enter a number of task: ");

    if (int.TryParse(Console.ReadLine(), out int taskNo))
    {
        switch (taskNo)
            {
                case 1:
                {
                    System.Console.WriteLine("Enter two numbers");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a > b)
                    {
                        System.Console.Write("Max = ");
                        System.Console.WriteLine(a);
                    }
                    else
                    {
                        System.Console.Write("Max = ");
                        System.Console.WriteLine(b);
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter three numbers");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());

                    if (a > b && a > c)
                    {
                        System.Console.Write("Max = ");
                        System.Console.WriteLine(a);
                    }
                    else if (b > c)
                    {
                        System.Console.Write("Max = ");
                        System.Console.WriteLine(b);
                    }
                    else
                    {
                        System.Console.Write("Max = ");
                        System.Console.WriteLine(c);                       
                    }
                    break;                    
                }
                case 3:
                {
                    System.Console.Write("Enter a number: ");
                    int a = int.Parse(Console.ReadLine());    

                    if (a%2==0) System.Console.WriteLine("The number is even");
                    else System.Console.WriteLine("The number is odd");

                    break;                 
                }
                case 4:
                {
                    System.Console.Write("Enter a number: ");
                    int N = int.Parse(Console.ReadLine()); 

                    int i = 2;

                    while (i <= N)
                    {
                        if (i > 2) System.Console.Write(", ");
                        System.Console.Write(i);
                        i+=2;
                    }

                    break;                                        
                }
                case 0:
                {
                    isWork = false;
                    break;
                }
            }
    }
    else
    {
        System.Console.WriteLine("Wrong selection");
    }
}
