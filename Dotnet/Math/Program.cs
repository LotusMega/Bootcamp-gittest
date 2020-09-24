using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi! Syötä numero:");
            // int a = Convert.ToInt32(Console.ReadLine());
            string a = Console.ReadLine();

            Console.WriteLine("Kiitos! Syötä vielä toinen numero:");
            // int b = Convert.ToInt32(Console.ReadLine());
            string b = Console.ReadLine();

            // int c = a + b;
            int c = int.Parse(a) + int.Parse(b);

            Console.WriteLine("Syöttämiesi numeroiden summa on " + c);
        }
    }
}
