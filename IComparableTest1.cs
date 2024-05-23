using System.Diagnostics;
using System.Net.Cache;

internal class Program
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object? obj)
        {
            // Name을 Price로 하면 Price기준으로 정렬 됨
            return this.Name.CompareTo((obj as Product).Name);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }


    class Student : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object obj)
        {
            if (obj is Student otherStudent)
            {
                return this.Age.CompareTo(otherStudent.Age);
            }
            // 예외 처리
            throw new ArgumentException("Object is not Student");
        }
    }
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>()
        {
            new Product() { Name = "고구마", Price = 1500},
            new Product() { Name = "사과", Price = 2400},
            new Product() { Name = "바나나", Price = 1000},
            new Product() { Name = "배", Price = 3000}
        };
        list.Sort();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        List<Student> students = new List<Student>
        {
            new Student{Name="Alice", Age=25},
            new Student{Name="Charlie", Age=28},
            new Student{Name="Bob", Age=22}
        };
        students.Sort();

        foreach (var item in students)
        {
            Console.WriteLine(item.Name + " : " + item.Age + "살");
        }
    }
}