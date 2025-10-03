using System;

class Myclass
{
    private int age;
    public void ShowAge()
    {
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("my age is" +age);
        
        
    }
}
class Program
    {
        static void Main()
        {
            Myclass a = new Myclass();
            a.ShowAge();
        }
    }

         