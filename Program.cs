using System.Security.Cryptography.X509Certificates;

namespace LineComparisonProblem
{
    internal class CompareLines
    {
        public static double UC1(double x1, double y1, double x2, double y2) //Calculate the length of a line
        {
            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            return length;
        }

        public static string UC3(double length1, double length2)
        {
            string result;

            if(length1 == length2) 
                result="Both the lines are of same length";
            else if(length1>length2)
                result="Line1 is greater than Line2";
            else 
                result="Line2 is greater than Line1";
            
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the points for Line1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the points for Line2");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            double length1 = UC1(x1, y1, x2, y2);
            double length2 = UC1(a1, b1, a2, b2);

            Console.WriteLine("After comparing both the lines " + UC3(length1, length2));
        }
    }
}
