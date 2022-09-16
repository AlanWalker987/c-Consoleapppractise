using System;
namespace AccessSpecifierDemo
{
    public class Customer
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }

    public class MainClass
    {
        public static void Main(String[] args)
        {
            Customer CustomerInstance = new Customer();
            CustomerInstance.Id = 101;
            Console.WriteLine(CustomerInstance.Id);
         //   Console.WriteLine(CustomerInstance.id);
            // Compiler Error: 'Customer._id' is inaccessible due to its protection level
            // CustomerInstance._id = 101;
        }
    }
}