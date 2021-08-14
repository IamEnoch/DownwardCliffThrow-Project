using System;

namespace DownwardCliffThrow_Project
{
    class Program
    {
        //Velocity as a function time
        static double VelocityTime(double a, double b, double c)
        {
            return a + (b * c);
        }
        //Velocoty as a function of distance
        static double VelocityDistance(double a, double b, double c)
        {
            return Math.Sqrt(a * a + (2 * b * c));
        }
        //Test methood that confirms both function return the same velocity
        static void TestVelocity(double a, double b)
        {
            if (a == b)
            {
                Console.WriteLine("Both Functions return the same thing");
            }
            else
            {
                Console.WriteLine("==SOMETHING IS WRONG!!!!! ==");
            }
        }
        static void Main(string[] args)
        {
            const double acc = 9.81;

            Console.Write("Enter the initial valocity: ");
            double InitialVel = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time taken: ");
            double Time = Convert.ToDouble(Console.ReadLine());

            double Dist = InitialVel * Time + (0.5 * acc * Time * Time);
            
            TestVelocity(VelocityTime(InitialVel, acc, Time), VelocityDistance(InitialVel, acc, Dist));
        }
    }
}
