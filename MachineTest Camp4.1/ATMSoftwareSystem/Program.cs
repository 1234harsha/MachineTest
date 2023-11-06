//Create an interface called IPayable.
//This is the interface that will be used by the ATM software
//The IPayable interface should contain three functions:
//1.Deposit amount
//2.Withdraw amount
//3.check balance.
//A class Employee should implement the IPayable interface.  
//The implementation of the functions should make sense.
//Get the choice from the user.
//Retrieve the account details  into a suitable collection
//Handle all exceptions at runtime


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareSystem
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            int choice;
            do
            {
                Console.WriteLine("1. Create Employee Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                 choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Account number: ");
                        int empid = int.Parse(Console.ReadLine());
                        Console.Write("Enter Employee Name: ");
                        string empname = Console.ReadLine();
                        //Console.WriteLine("Enter Initial Balance:");
                        //double initialBalance = double.Parse(Console.ReadLine());
                        employees[empid] = new Employee();
                        Console.WriteLine("Employee account created successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee Id:");
                        int empid1 = int.Parse(Console.ReadLine());
                        if (employees.ContainsKey(empid1))
                        {
                            Console.WriteLine("Enter Amount to deposited:");
                            double depositAmount = double.Parse(Console.ReadLine());
                            employees[empid1].Deposit(depositAmount);
                            Console.WriteLine("Deposited successful.");
                        }
                        else
                        {
                            Console.WriteLine("Employee account not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id:");
                        int empid2 = int.Parse(Console.ReadLine());
                        if (employees.ContainsKey(empid2))
                        {
                            Console.WriteLine("Enter Amount to Withdraw:");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            employees[empid2].Withdraw(withdrawAmount);
                            Console.WriteLine("Amount withdrawed successful.");
                        }
                        else
                        {
                            Console.WriteLine("Employee account not found.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Employee Id:");
                        int empid3 = int.Parse(Console.ReadLine());
                        if (employees.ContainsKey(empid3))
                        {

                            employees[empid3].CheckBalance();
                           
                        }
                        else
                        {
                            Console.WriteLine("Employee account not found.");
                        }
                        break;
                    case 5:
                                   Console.WriteLine("Exiting the program.");
                                   break;
                   default:
                                   Console.WriteLine("Invalid choice. Please try again.");
                                   break;




                }
            } while (choice != 0);
        }
    }
}
