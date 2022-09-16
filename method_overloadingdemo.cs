using System;
namespace PolymorphismDemo
{
    class Program
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float x, float y, float z)
        {
            Console.WriteLine(x + y + z);
        }
        public void add(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.add(10, 20);
            obj.add(10.5f, 20.5f, 9.8f);
            obj.add("pranaya", "kumar");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}