using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add_Customer(Customer customer)
        {
            Console.WriteLine("--------Müşteri Ekleme-------");
            Console.WriteLine("Müşteri Id: " + customer.Id);
            Console.WriteLine("Müşteri Tc: " + customer.Tc);
            Console.WriteLine("Müşteri Adı: " + customer.Name);
            Console.WriteLine("Müşteri Soyadı: " + customer.Surname);
            Console.WriteLine("Müşterinin Tüm Varlığı: " + customer.AllAssets);
            Console.WriteLine("Müşteri sisteme eklendi... ");
            Console.WriteLine();
        }
        
        public void Get_All_Customer(Customer[] customers)
        {
            Console.WriteLine("--------Tüm Müşterileri Getirme-------");
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: " + customer.Name + " " + customer.Surname);
            }
            Console.WriteLine();
        }

        public void Delete_Customer(Customer customer)
        {
            Console.WriteLine("--------Müşteri Silme-------");
            Console.WriteLine(customer.Name + " " + customer.Surname + " silindi.");
            Console.WriteLine();
        }
    }
}
