using System;

namespace copyconstructorv2{
    
    class Employee{
        
        public int Id, Age;
        public string Address, Name;
        public bool isPermanent;
        
        public Employee(int id, int age, string address, string name, bool ispermanent){
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            isPermanent = ispermanent;
        }
        
        public Employee(Employee emp){
            Id = emp.Id;
            Age = emp.Age;
            Address = emp.Address;
            Name = emp.Name;
            isPermanent = emp.isPermanent;
        }
        
        public void display(){
            Console.WriteLine("Employee ID : " + Id);
            Console.WriteLine("Employee Age : " + Age);
            Console.WriteLine("Employee Address : " + Address);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Employee Role : " + isPermanent);
        }
    }
    
    class Program{
        
        static void Main(String[] args){
         Employee emp1 = new Employee(001, 23, "Mysuru", "Karthik", true);
         emp1.display();
         
         Console.WriteLine();
         
         Employee emp2 = new Employee(emp1);
         emp2.display();
        }
        
    }
}