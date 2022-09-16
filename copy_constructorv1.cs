using System;
namespace copyconstructor{
    
    class CopyConstructor{
        int x;
        
        public CopyConstructor(int i){
            x = i;
        }
        
        public CopyConstructor(CopyConstructor obj){
            x = obj.x;
        }
        
        public void display(){
            Console.WriteLine("Value of X is " + x);
        }
    }
    
    class Program{
        static void Main(String[] args){
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.display();
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.display();
        }
    }
}