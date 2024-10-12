using System;

class Program
{
    public static void Main()
    {
        double D = 0, E = 0, F = 0, Total = 0;
        char salesman;
        while (true)
        {
            Console.WriteLine("Enter the salesman's initial. Z to exit program: ");
            salesman = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if (salesman == 'Z')
            {
                break;
            }
            if (salesman != 'D' && salesman != 'E' && salesman != 'F')
            {
                Console.WriteLine("Invalid salesman initial. Enter a different initial.");
                continue;
            }
            Console.WriteLine("Enter the salesman's sales: $");
            double sales = Convert.ToDouble(Console.ReadLine());
            switch (salesman)
            {
                case 'D':
                    D += sales;
                    break;
                case 'E':
                    E += sales;
                    break;
                case 'F':
                    F += sales;
                    break;
            }
            Total += sales;

        }
        Console.WriteLine("Total sales: $" + Total);

        if (D > E && D > F)
        {
            Console.WriteLine("Danielle is the highest seller.");
        }
        else if (E > D && E > F)
        {
            Console.WriteLine("Edward is the highest seller.");
        }
        else if (F > D & F > E)
        {
            Console.WriteLine("Francis is the highest seller.");
        }
        else
        {
            Console.WriteLine("There was a tie.");
        }
    }
}