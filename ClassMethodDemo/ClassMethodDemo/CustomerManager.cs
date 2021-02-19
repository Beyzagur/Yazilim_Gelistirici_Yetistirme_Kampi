using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("\n"+customer.CustomerName+" "+customer.CustomerSurname+" customer has been added !\n");
        }

        public void Delete(Customer deleteCustomer)
        {
            foreach (Customer customer in customers)
            {
                if(deleteCustomer.CustomerName.Equals(customer.CustomerName) & deleteCustomer.CustomerSurname.Equals(customer.CustomerSurname))
                {
                    customers.Remove(customer);
                    Console.WriteLine("\n" + deleteCustomer.CustomerName + " " + deleteCustomer.CustomerSurname + " customer has been deleted !!!\n");
                   
                }
                else
                {
                    Console.WriteLine("\nThere is no customer you want to delete !!!\n");
                }
            }
            if (customers.Count == 0)
            {
                Console.WriteLine("\nThere is no customer you want to delete !!!\n");

            }

        }

        public void List()
        {
            if (customers.Count > 0)
            {
                Console.WriteLine("\n----------List of Customers Information----------");
                foreach (var customer in customers)
                {
                    Console.WriteLine(customers.IndexOf(customer)+1+")"+customer.CustomerName + " " + customer.CustomerSurname + "   \nCustomer Age: "+ customer.CustomerAge);
                }
            }
            else
            {
                Console.WriteLine("\nDoes not have a customer !!!\n");
            }
           
        }
    }
}
