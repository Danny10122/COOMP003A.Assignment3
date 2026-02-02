namespace COOMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("=== Academic & Personal Readiness Evalutor ===");
            
            //For current year
            Console.Write("\nCurrent Year: ");
            string year = Console.ReadLine();

            //For birth year
            Console.Write("Enter your birth year: ");          
            string birth = Console.ReadLine();
            

            //For calculated age
            double num1 = double.Parse(year);
            double num2 = double.Parse(birth);

            double age = num1 - num2;

            //For age
            Console.Write("\nCalculated Age: " + age);
            Console.Write("\nReadiness Category: ");
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else 
            {
                Console.WriteLine("Not an adult");
            }
            
            //For ID and orientation
            Console.Write("\nDo you have a valid ID? (yes/no): ");
            string input = Console.ReadLine();
            bool isValid = true;

            Console.Write("Have you completed orientation? (yes/no): ");
            string inputt = Console.ReadLine();
            bool isCompleted = false;

            //For status
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

            //For selecting an option
            Console.WriteLine("\nSelect a guidance option:");

            Console.WriteLine("1 - Academic Planning");

            Console.WriteLine("2 - Personal Planning");

            Console.WriteLine("3 - Career Planning");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            //For the choices
            if (choice == 1)
            {
                Console.WriteLine("\nGuidance:");
                Console.WriteLine("Meet with an academic advisor to plan your next term.");
            }
            if (choice == 2)
            {
                Console.WriteLine("\nGuidance:");
                Console.WriteLine("Good luck lil bro.");
            }
            if (choice == 3)
            {
                Console.WriteLine("\nGuidance:");
                Console.WriteLine("Make sure you enjoy what you're doing before it's late.");
            }
        }
    }
}
