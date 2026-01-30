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
            int birthyear = DateTime.Now.Year;
            int age = currentyear - birthyear;
            Console.WriteLine("\ncalculate your age:");
            string readinessCategory;
            if (1 < 18) ;
            {
                readinessCategory = "Minor";
            }
            if (19 <= 64);
            {
                readinessCategory = "Adult";
            }
           
            {
                readinessCategory = "senior";
            }
            Console.Write("Do you have a valid ID? (yes/no): ");
            bool hasValidID = Console.ReadLine().ToLower() == "yes";
            Console.Write("Have you completed orientation? (yes/no):");
            bool completedOrientation = Console.ReadLine().ToLower() == "yes";
        }
    }
}
