using System;

namespace Part_2_lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Houses houses = new Houses(1, 2, 3, 5);
            houses.Show();
            houses.TakesDoors();
            houses.CreatBulild(1, 2, 3, 4);
            Console.WriteLine();
           
            
           
        }
    }
}
