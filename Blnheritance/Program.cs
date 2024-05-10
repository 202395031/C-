
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
        
        Console.WriteLine("\n\nas키워드로 자료형 변환");

        List<Animal> animals2 = new List<Animal>() { new Dog(), new Cat(), new Dog(), new Cat() };
        
        foreach (var item in animals2)
        {
            item.Eat();
            item.Sleep();
        
            var dog = item as Dog;
            if (dog != null) { dog.Bark(); }
        
            var cat = item as Cat;
            if (cat != null) { cat.Meow(); }
        }
    }
}
