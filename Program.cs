using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            Console.WriteLine( $"Hello world! {c1.ReturnMessage()}");
        }
    }
}
