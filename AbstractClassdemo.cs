using System;

namespace AbstractClassDemo{
    
    public abstract class ParentClass{
        
        public void add(int a, int b){
            Console.WriteLine($"Sum of {a} and {b} is {a+b}");
        }
        
        public void sub(int a, int b){
            Console.WriteLine($"Difference of {a} and {b} is {a-b}");
        }
        
        public abstract void mul(int a, int b);
        
        public abstract void div(int a, int b); 
    } 
    
    public class ChildClass : ParentClass{
        
        public override void mul(int a, int b){
            Console.WriteLine($"Multiplication of {a} and {b} is {a*b}");
        }
        
        public override void div(int a, int b){
            Console.WriteLine($"Division of {a} and {b} is {a/b}");
        }
    }
    
    public class MainProgram{
        public static void Main(String[] args){
            
            ChildClass cc = new ChildClass();
            cc.add(2,4);
            cc.sub(4,2);
            cc.mul(2,4);
            cc.div(4,2);
        }
    }
}