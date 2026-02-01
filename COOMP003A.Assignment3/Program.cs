namespace COOMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Academic & Personal Readiness Evalutor ===");

            Console.Write("\nCurrent Year: ");
            string year = Console.ReadLine();

            Console.Write("Enter your birth year: ");          
            string birth = Console.ReadLine();
            

            //For calculated age
            double num1 = double.Parse(year);
            double num2 = double.Parse(birth);

            double sum = num1 - num2;

            Console.Write("\nCalculated Age: " + sum);
            Console.Write("\nReadiness Category: ");
            if (sum >= 18)
            {
                Console.WriteLine("Adult");
            }

            Console.Write("\nDo you have a valid ID? (yes/no): ");

            Console.Write("\nReadiness Status: ");

            Console.WriteLine("\nSelect a guidance option:");

            Console.WriteLine("1 - Academic Planning");

            Console.WriteLine("2 - Personal Planning");

            Console.WriteLine("3 - Career Planning");

            Console.Write("Enter choice: ");

            Console.WriteLine("\nGuidance:");
            Console.WriteLine("Meet with an academic advisor to plan your next term.");
        }
    }
}
