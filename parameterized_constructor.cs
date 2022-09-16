using System;
namespace parameterized_constructor{
    
    class ParameterizedConstructor{
        
        public ParameterizedConstructor(int i){
            Console.WriteLine("Value of constructor parameter " + i);
        }
    }
    
    class Program{
        static void Main(String[] args){
            
            ParameterizedConstructor pc1 = new ParameterizedConstructor(10);
            
            ParameterizedConstructor pc2 = new ParameterizedConstructor(20);
        }
    }
}