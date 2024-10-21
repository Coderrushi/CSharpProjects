namespace Abstraction
{
    public abstract class Animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Dog makes sound");
        }
    }

    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog eats pedigre");
        }
    }

    internal class Abstraction
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
            dog.sound();
        }
    }
}
