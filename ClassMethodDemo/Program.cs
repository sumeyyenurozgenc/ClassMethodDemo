using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Tc = "1234858423";
            customer1.Name = "Nur";
            customer1.Surname = "Özgenç";
            customer1.AllAssets = 10045.323;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Tc = "4657687864";
            customer2.Name = "Merve";
            customer2.Surname = "Deniz";
            customer2.AllAssets = 2000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Tc = "8457687864";
            customer3.Name = "Aytaç";
            customer3.Surname = "Kaleci";
            customer3.AllAssets = 212002.345;

            Customer[] allCustomers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Get_All_Customer(allCustomers);


        }
    }
}
