using System;

namespace PracticProblem
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Before swap a= "+a + " b= "+b);
            a = a * b;
            a = a / b;
            b = b / a;
            Console.WriteLine("After swap a= " +a + " b= "+b);
        }
    }
}
