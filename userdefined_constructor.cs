using System;
namespace UserdefinedConstructor
{
    class Employee {
        
        public int Id, Age;
        public string Address, Name;
        public bool isPermanent;
        
        public Employee()
        {
            Id = 25;
            Age = 40;
            Address = "Mysuru";
            Name = "Rocky";
            isPermanent = true;
        }
        
        public void display(){
            Console.WriteLine("Employee ID " + Id);
            Console.WriteLine("Employee Age " + Age);
            Console.WriteLine("Employee Address " + Address);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee ISpermanent " + isPermanent);
        }
    }
    
    class Program{
        static void Main(String[] args){
            Employee e1 = new Employee();
            
            e1.display();
        }
    }
}
