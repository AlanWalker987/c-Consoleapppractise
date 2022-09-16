using System;

namespace AbstractClassDemo{
    
    public abstract class Shape{
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double GetArea();
    } 
    
    public class Rectangle : Shape {
        
        public Rectangle(double height, double width){
            this.Height = height;
            this.Width = width;
        }
        
        public override double GetArea(){
            return Width * Height;
        }
    }
    
    public class Triangle : Shape {
        
        public Triangle(double height, double width){
            this.Width = width;
            this.Height = height;
        }
        
        public override double GetArea(){
            return (Height * Width) / 2;
        }
    }
    
    public class Circle : Shape{
        
        public Circle(double radius){
            this.Radius = radius;
        }
        
        public override double GetArea(){
            return PI * Radius * Radius;
        }
    }
    
    public class Cone : Shape{
        public Cone(double height, double radius){
            this.Height = height;
            this.Radius = radius;
        }
        
        public override double GetArea(){
            return PI * Radius * (Radius + Math.Sqrt(Radius * Radius + Height * Height));
        }
    }
    
    public class MainProgram{
        public static void Main(String[] args){
            
            Rectangle rect = new Rectangle(5,10);
            Console.WriteLine($"Area of Rectangle is {rect.GetArea()}");
            
            Circle cl = new Circle(5);
            Console.WriteLine($"Area of Circle is {cl.GetArea()}");
            
            Triangle tl = new Triangle(2,4);
            Console.WriteLine($"Area of Triangle is {tl.GetArea()}");
            
            Cone cn = new Cone(3,6);
            Console.WriteLine($"Area of Cone is {cn.GetArea()}");
        }
    }
}