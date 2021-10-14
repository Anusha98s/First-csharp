using System;

namespace First_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("What is your fav snack\n");

            string name = Console.ReadLine();
            Console.WriteLine("How manyPlates you can have it at a time?\n");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine(count);
                            if(count >= 2)
            {
                Console.WriteLine("Too much of snacking is not a healthy sign....!!");
            }
        }
    }
}
