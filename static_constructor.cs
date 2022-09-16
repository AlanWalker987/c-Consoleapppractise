using System;

namespace staticConstructor{
    
    class StaticDemo{
        
        public int i;
        static int j;
        
        public StaticDemo(){
            i = 100;
            Console.WriteLine("Default Constructor is called");
        }
        
        static StaticDemo(){
            j = 100;
            Console.WriteLine("Static Constructor is called");
        }
        
        public void increment(){
            i++;
            j++;
        }
        
        public void display(){
            Console.WriteLine("Value of i : " + i);
            Console.WriteLine("Value of j : " + j);
        }
    }
    
    class Program{
        static void Main(String[] args){
            StaticDemo sd1 = new StaticDemo();
            sd1.increment();
            sd1.display();
            sd1.increment();
            sd1.display();
            StaticDemo sd2 = new StaticDemo();
            sd2.increment();
            sd2.display();
            sd2.increment();
            sd2.display();
        }
    }
}