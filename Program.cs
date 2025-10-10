using System;
delegate void greet();
class program
{
    static void method1()
    {
        Console.WriteLine("hi");
    }
    static void method2()
    {
        Console.WriteLine("hello");
    }
    static void Main()
    {
        greet g = method1;
        g += method2;
        g();
    }
}