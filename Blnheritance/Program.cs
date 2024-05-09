
using Blnheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

        foreach (var item in Dogs)
        {
            item.Eat();
            item.Sleep();
            item.Bark();
        }

        foreach (var item in Cats)
        {
            item.Eat();
            item.Sleep();
            item.Meow();
        }



        Console.WriteLine("\n\n다형성");

        List<Animal> animals = new List<Animal>() { new Dog(), new Cat(), new Dog(), new Cat() };

        foreach (var item in animals)
        {
            item.Eat();
            item.Sleep();
            
            if (item is Dog) { ((Dog)item).Bark(); }
            if (item is Cat) { ((Cat)item).Meow(); }
        }
        
        
    }
}