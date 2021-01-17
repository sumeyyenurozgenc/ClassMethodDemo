using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add_Customer(Customer customer)
        {
            Console.WriteLine("Customer was added in the system");
           
        }

        public void Get_All_Customer(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: " + customer.Name + " " + customer.Surname);
            }
            Console.WriteLine();
        }

        public void Delete_Customer(int id)
        {
            Console.WriteLine("Customer was deleted.");
        }
    }
}
