using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.Write("Enter a number: ");
            //n = int.Parse(Console.ReadLine());
            //if (n >= 1 && n <= 100)
            //{
            //    if (n % 3 == 0 && n % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (n % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (n % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            //double a, b;
            //Console.Write("Enter a number 1: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Enter a number 2: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Result: {(a * b) / 100.0}");

            //int a, b, c, d;
            //Console.Write("Enter a number 1: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number 2: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number 3: ");
            //c = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number 4: ");
            //d = int.Parse(Console.ReadLine());
            //int r = (a*1000)+(b*100)+(c*10)+d;
            //Console.WriteLine(r);

            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n / 100000 != 0)
            //{
            //    Console.Write("Enter number 1: ");
            //    int c1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter number 2: ");
            //    int c2 = int.Parse(Console.ReadLine());
            //    int p1 = 1, p2 = 1;
            //    for (int i = 0; i < 6 - c1; i++) { p1 *= 10; }
            //    for (int i = 0; i < 6 - c2; i++) { p2 *= 10; }
            //    int t1 = (n / p1) % 10;
            //    int t2 = (n / p2) % 10;
            //    Console.WriteLine(n + (t2 - t1) * p1 + (t1 - t2) * p2);
            //}
            //else { Console.WriteLine("Error"); }

            //Console.Write("Enter date: ");
            //DateTime a = Convert.ToDateTime(Console.ReadLine());
            //if (a.Month <= 2 || a.Month == 12) { Console.Write("Winter "); }
            //else if (a.Month >= 3 && a.Month <= 5) { Console.Write("Spring "); }
            //else if (a.Month >= 6 && a.Month <= 8) { Console.Write("Summer "); }
            //else { Console.Write("Autumn "); }
            //Console.WriteLine($"{a.DayOfWeek}");

            //Console.Write("Enter a number: ");
            //double n = int.Parse(Console.ReadLine());
            //Console.Write("Choose option (1 - C to F, 2 - F to C): ");
            //double c = int.Parse(Console.ReadLine());
            //switch (c)
            //{
            //    case 1:
            //        n = (n * 9 / 5.0) + 32;
            //        break;
            //    case 2:
            //        n = (n - 32) * 5 / 9.0;
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(n);

            Console.Write("Enter a number 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number 2: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                int t = n1;
                n1 = n2;
                n2 = t;
            }
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0) { Console.Write($"{i} "); }
            }
        }
    }
}
