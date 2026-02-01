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

            double age = num1 - num2;

            Console.Write("\nCalculated Age: " + age);
            Console.Write("\nReadiness Category: ");
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }

            Console.Write("\nDo you have a valid ID? (yes/no): ");
            string input = Console.ReadLine();
            bool isValid = true;

            Console.Write("Have you completed orientation? (yes/no): ");
            string inputt = Console.ReadLine();
            bool isCompleted = false;

            Console.Write("\nReadiness Status: ");
            if (isValid && isCompleted)
            {
                Console.WriteLine("Ready");
            }
            else if (isValid || isCompleted)
            {
                Console.WriteLine("Conditionally Ready");
            }
            else
            {
                Console.WriteLine("Not Ready");
            }

            Console.WriteLine("\nSelect a guidance option:");

            Console.WriteLine("1 - Academic Planning");

            Console.WriteLine("2 - Personal Planning");

            Console.WriteLine("3 - Career Planning");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nGuidance:");
                Console.WriteLine("Meet with an academic advisor to plan your next term.");
            }
            if (choice == 2)
            {
                Console.WriteLine("\nGuidance:");
                Console.WriteLine("Good luck lil bro");
            }
        }
    }
}
