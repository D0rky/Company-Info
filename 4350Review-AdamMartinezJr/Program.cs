using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4350Review_AdamMartinezJr
{
    class Program
    {
        private static readonly double totalPay = 0;
        private static int i = 0;


        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees in the company: ");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter information for Employee {i + 1}");
                Console.Write("First Name: ");
                string firstN = Console.ReadLine();
                Console.Write("Last Name: ");
                string lastN = Console.ReadLine();
                Console.Write("Hourly Wage: ");
                double wage = double.Parse(Console.ReadLine());

                employees.Add(new Employee(firstN, lastN, wage));
            }

            while (true)
            {
                Console.WriteLine("\nEmployee Menu:");
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {employees[i].GetFirstName()} {employees[i].GetLastName()}");
                }
                Console.WriteLine("0. Exit");

                Console.Write("Enter the employee number to display information (0 to exit): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
                else if (choice >= 1 && choice <= employees.Count)
                {
                    int selectedEmployeeIndex = choice - 1;
                    Employee selectedEmployee = employees[selectedEmployeeIndex];

                    Console.Write($"Enter the weekly hours worked for {selectedEmployee.GetFirstName()} {selectedEmployee.GetLastName()}: ");
                    double weekHrsWkd = double.Parse(Console.ReadLine());

                    selectedEmployee.SetWeekHrsWkd(weekHrsWkd); // Set the weekly hours worked

                    Console.WriteLine($"Employee {selectedEmployee.GetFirstName()} {selectedEmployee.GetLastName()}");
                    Console.WriteLine($"Total Pay: {selectedEmployee.GetTotalPay()}");
                }
                else
                {
                    Console.WriteLine("Invalid employee number. Please try again.");
                }
            }

        }
    }












}

