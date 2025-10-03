using System;
class Animal
{
    protected void MakeSound()
    {
        Console.WriteLine("animal");

    }
}
class Dog : Animal
{
    public void bark()
    {
        MakeSound();
        Console.WriteLine("dog is barking");
    }
}
class Program
{
    static void Main()
    {
        Dog d = new Dog();
    }
}