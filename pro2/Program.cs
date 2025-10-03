using System;
class Animal
{
    protected void Makesound()
    {
        Console.WriteLine("animal");
    }
class Dog : animal
    {
        public void bark()
        {
            Makesound();
            Console.WriteLine("dog is barking");        }
    }
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.barking();
    }
}
    