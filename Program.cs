using System.ComponentModel.Design;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n === Academic & Personal Readiness Evaluation ===");
            int currentyear = DateTime.Now.Year;
            Console.Write("Current Year:");
            Console.ReadLine();
            Console.Write("Enter your birth year:");
            Console.ReadLine();
            Console.WriteLine($"calculate your age:");
            string readinessCategory;
            Console.Write("Do you have a valid ID? (yes/no): ");
            bool hasValidID = Console.ReadLine().ToLower() == "yes";
            Console.Write("Have you completed orientation? (yes/no):");
            bool completedOrientation = Console.ReadLine().ToLower() == "yes";

            Console.WriteLine("select a guidance option:");
            Console.WriteLine("1 - Academic planning");
            Console.WriteLine("2 - Personal planning");
            Console.WriteLine("3 - Career planning");
            Console.Write("Enter choice:");
            string choice = Console.ReadLine();
            Console.WriteLine("\n Guidance:");

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Meet with an academic advisor to plan your next term");
                    break;
                case "2":
                    Console.WriteLine("Focus on time management and personal goal setting");
                    break;
                case "3":
                    Console.WriteLine("Explore internships and build a professional resume");
                    break;
                default:
                    Console.WriteLine("Invalid selection. please restart and choose a valid option");
                    break;
            }
            
        }
    }
}
