﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);
            
            Console.WriteLine("give me the radius of your circle.");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput !);
            
            Console.WriteLine(AreaOfCircle(radius));
            


        }
        public static double AreaOfCircle(double radius)
        {
         var area = Math.PI * Math.Pow(radius, 2);


            return area;

        } 
    

    }
}
