using System;
namespace InheritanceDemo{
    
    class A {
        
        public A(int num){
            Console.WriteLine($"Constructor from class A is called {num}");
            Console.WriteLine();
        }
        
        public void Method1(){
            Console.WriteLine("Method 1 from Class A");
            Console.WriteLine();
        }
        
        public void Method2(){
            Console.WriteLine("Method 2 from Class A");
            Console.WriteLine();
        }
    }
    
    class B : A {
        
        public B(int num) : base(num){
            Console.WriteLine("Constructor from class B is called");
            Console.WriteLine();
        }
        
        public static void Main(String[] args){
          
          /*  
            B Bobj = new B();
        //    A Aobj = new A(); 
            Bobj.Method1();
            Console.WriteLine();
            Bobj.Method2();
            Bobj.Method3();
         //   Aobj.Method3(); // parent can't access child
         
         */
         
         /*
           A p;
           B Bobj = new B();
           p = Bobj;
           p.Method1();
           p.Method2();
          // p.Method3(); // cannot call class B member
          */
          
          /*
          Object obj1 = new Object();
          Console.WriteLine($"Obj1 type is ${obj1.GetType()}");
          Console.WriteLine();
          A obj2 = new A();
          Console.WriteLine($"Obj2 type is ${obj2.GetType()}");
          Console.WriteLine();
          B obj3 = new B();
          Console.WriteLine($"Obj3 type is ${obj3.GetType()}");
          Console.WriteLine();
          */
          
          B bObj = new B(20);
          B obj2 = new B(456);
          bObj.Method3();
        }
        
        public void Method3(){
            Console.WriteLine("Method 3 from Class B");
        }
    }
}