using System;
delegate void remote();
class program
{
    static void tv ()
    {
        Console.WriteLine("say hello");
    }
    static void Main()
    {
        remote R = tv;
        R();
    }
}