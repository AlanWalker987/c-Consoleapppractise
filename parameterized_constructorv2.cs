using System;
namespace parameterized_constructor{
    
    class ParameterizedConstructor{
        
        public int x;
        public ParameterizedConstructor(int i){
            x = i;
            Console.WriteLine("Value of constructor parameter is " + i);
            Console.WriteLine("Value of X is " + x);
        }
    }
    
    class Program{
        static void Main(String[] args){
            
            ParameterizedConstructor pc1 = new ParameterizedConstructor(10);
            
            ParameterizedConstructor pc2 = new ParameterizedConstructor(20);
        }
    }
}