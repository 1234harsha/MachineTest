using System;
using System.Collections.Generic;

public interface IPayable
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    decimal CheckBalance();
}

public class Employee : IPayable
{
    public decimal Balance { get; private set; }

    public Employee(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Invalid deposit amount.");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            throw new ArgumentException("Invalid withdrawal amount.");
        }

        Balance -= amount;
    }

    public decimal CheckBalance()
    {
        return Balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        while (true)
        {
            Console.WriteLine("1. Create Employee Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter initial balance: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal initialBalance))
                        {
                            Console.Write("Enter employee ID: ");
                            if (int.TryParse(Console.ReadLine(), out int employeeId))
                            {
                                employees[employeeId] = new Employee(initialBalance);
                                Console.WriteLine("Employee account created successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid employee ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid initial balance.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter employee ID: ");
                        if (int.TryParse(Console.ReadLine(), out int depositEmployeeId))
                        {
                            if (employees.ContainsKey(depositEmployeeId))
                            {
                                Console.Write("Enter deposit amount: ");
                                if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                                {
                                    employees[depositEmployeeId].Deposit(depositAmount);
                                    Console.WriteLine("Deposit successful.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid deposit amount.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Employee account not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid employee ID.");
                        }
                        break;

                    case 3:
                        // Implement withdrawal logic similar to deposit
                        break;

                    case 4:
                        // Implement balance check logic
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
            }
        }
    }
}
