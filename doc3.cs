	using System;
abstract class Animal
 {
     public string Name;
public void SetName(string name)
{
  this.Name = name;
}
public string GetName()
{
    return Name;
}
public abstract void Eat();
}
class Dog : Animal
{
public override void Eat()
{
Console.WriteLine("Dog is eating");
}
}
class program
{
public static void Main()
{
Dog dog = new Dog();
dog.SetName(Console.ReadLine());
Console.WriteLine(dog.GetName());
dog.Eat();
}
}