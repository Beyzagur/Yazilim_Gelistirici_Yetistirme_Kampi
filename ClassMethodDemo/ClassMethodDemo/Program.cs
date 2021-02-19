using System;
using System.Collections;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            bool firstRun = true;
            bool secondRun = true;

            Console.WriteLine("\tWelcome to the Bank ");

            while (run)
            {
                try
                {
                    CustomerManager cm = new CustomerManager();
                    while (firstRun)
                    {
                        Console.Write("1 Add customer\n2 Delete customer\n3 List customers' information \n4 Exit \nSelect the action you want to carry out: ");
                        int choose = Convert.ToInt32(Console.ReadLine());

                        switch (choose)
                        {
                            case 1:
                                while (secondRun)
                                {
                                    Console.Write("Enter the number of customers to add: ");
                                    try
                                    {
                                        int count = Convert.ToInt32(Console.ReadLine());
                                        for (int i = 1; i <= count; i++)
                                        {
                                            Customer customer = new Customer();
                                            Console.Write("\nPlease write your name: ");
                                            customer.CustomerName = Console.ReadLine();
                                            Console.Write("Please write your surname: ");
                                            customer.CustomerSurname = Console.ReadLine();
                                            Console.Write("Please write your age: ");
                                            customer.CustomerAge = Convert.ToInt32(Console.ReadLine());

                                            cm.Add(customer);
                                            secondRun = false;

                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("\n***You entered the wrong format! \n");
                                    }
                                }
                                break;
                            case 2:
                                Customer deleteCustomer = new Customer();
                                Console.Write("\nPlease write your name: ");
                                deleteCustomer.CustomerName = Console.ReadLine();
                                Console.Write("Please write your surname: ");
                                deleteCustomer.CustomerSurname = Console.ReadLine();

                                cm.Delete(deleteCustomer);

                                break;
                            case 3:
                                cm.List();
                                break;
                            case 4:
                                firstRun = false;
                                Console.WriteLine("\nHave a nice day");
                                break;
                            default:
                                Console.WriteLine("\nYou did not choose one of these options !!!\n ");
                                break;
                        }
                    }
                    run = false;

                }
                catch
                {
                    Console.WriteLine("\n***You entered the wrong format!\n");
                }
            }
            
        }
    }
}
