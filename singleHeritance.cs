using System;

namespace SingleInheritanceDemo{
    
    class Rectangle{
        
        public int length;
        public int breadth;
        
        public int area(){
            return length * breadth;
        }
        
        public int perimeter(){
            return 2 * (length + breadth);
        }
    }
    
    class Cuboid : Rectangle{
        
        public int height;
        
        public Cuboid(int l, int b, int h){
            length = l;
            breadth = b;
            height = h;
        }
        
        public int volume(){
            return length * breadth * height;
        }
    }
    
    class MainProgram{
        public static void Main(String[] args){
            
            Cuboid cboid = new Cuboid(2,4,6);
            Console.WriteLine($"Area is {cboid.area()}");
            Console.WriteLine($"Perimter is {cboid.perimeter()}");
            Console.WriteLine($"Volume is {cboid.volume()}");
        }
    }
}