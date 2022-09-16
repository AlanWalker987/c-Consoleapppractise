using System;

namespace inheritanceHasADemo{
    
    class Address{
        public string addressLine, city, state;
        
        public Address(string adLine, string cityName, string stateName){
            addressLine = adLine;
            city = cityName;
            state = stateName;
        }
    }
    
    class Employee{
        public Address address;
        public int Id;
        public string Name;
        
        public Employee(int id, string name, Address addres){
            Id = id;
            Name = name;
            address = addres;
        }
        
        public void display(){
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"AddressLine: {address.addressLine}");
            Console.WriteLine($"City: {address.city}");
            Console.WriteLine($"State: {address.state}");
        }
    }
    
    class MainProgram{
        public static void Main(String[] args){
            Address adres = new Address("09-Vietnam", "california", "USA");
            Employee emp = new Employee(007, "Rocky", adres);
            emp.display();
        }
    }
}