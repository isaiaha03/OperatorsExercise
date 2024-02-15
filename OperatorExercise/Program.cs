namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Beginning of Exercise 1
            // Part 1
            int a = 17;
            int b = 4;
            // Part 2
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            // Part 3
            int quotient = a / b;
            int remainder = a % b;
            // Part 4
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            // Beginning of Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is " + AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
    }
}
