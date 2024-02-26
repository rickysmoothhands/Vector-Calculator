using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the test of josh's vector calculator");
            Console.WriteLine(" please give one vector in the format of x,y,z");
            
            Vector userinput = InuputVector();
            
            Console.WriteLine("another one would help same format");
            Vector userinput2 = InuputVector();
           



            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(userinput, userinput2) +"  <--- this is Vectors added");
            Console.WriteLine(Vector.Subtract(userinput, userinput2) + "  <--- this is Vectors subtracted");
            Console.WriteLine(userinput.GetMagnitude() + " <--- this is the Magnitude of your first vector");
            Console.WriteLine(userinput2.GetMagnitude() + " <--- this is the Magnitude of your second vector");
            Console.WriteLine(userinput.GetDirection ()+ " <--- this is the Direction");
            Console.WriteLine(userinput2.GetDirection() + " <--- this is the Direction of the second vector");
            Console.WriteLine(Vector.Negate(userinput) + "<--- this is the negated your frist vector");
            Console.WriteLine(Vector.Negate(userinput2) + "<--- this is the negated your second vector");
            Console.WriteLine(Vector.Scale(userinput,2) + "<--- this is your first  Scaled by 2");
            Console.WriteLine(Vector.Scale(userinput2,2) + "<--- this is your second  Scaled by 2");
            Console.WriteLine(Vector.Normalize(userinput) + " <--- this is the unit vector of your frist vector");
            Console.WriteLine(Vector.Normalize(userinput2) + " <--- this is the unit vector of your second vector");
            Console.WriteLine(Vector.DotProduct(userinput, userinput2) + " <--- this is you dot product");
            Console.WriteLine(Vector.CrossProduct(userinput, userinput2) + "  <--- this is Vectors cross product");
            Console.WriteLine(Vector.AngleBetween(userinput, userinput2) + "  <--- this is Vectors cross product");
            Console.WriteLine(Vector.ProjectOnto(userinput, userinput2) + "  <--- this is your vector projected");
        }
        static Vector InuputVector()
        {
            string UserInput = Console.ReadLine();
            //userInput x,y,z
            float x = Convert.ToInt32(UserInput.Split(',')[0]);
            float y = Convert.ToInt32(UserInput.Split(',')[1]);
            float z = Convert.ToInt32(UserInput.Split(',')[2]);
            return new Vector(x, y, z);
        }

        static void Scaler()
        {
            string UserScaler = Console.ReadLine();

           double UserScalerInt = Convert.ToInt32(UserScaler);



        }
    }
}
