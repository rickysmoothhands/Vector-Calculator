using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(-1, 2, -3);
            
            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2) +"  <--- this is Vectors added");
            Console.WriteLine(Vector.Subtract(test1, test2) + "  <--- this is Vectors subtracted");
        }
    }
}
