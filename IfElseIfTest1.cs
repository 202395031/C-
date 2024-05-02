internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("이번 달은 몇 월인가요? ");
        int input = int.Parse(Console.ReadLine());
        
        if (input == 3 || input == 4 || input == 5) 
        {
            Console.WriteLine("봄입니다.");
        }
        else if (input == 6 || input == 7 || input == 8)
        {
            Console.WriteLine("여름입니다.");
        }
        else if(input == 9 || input == 10 || input == 11)
        {
            Console.WriteLine("가을입니다.");
        }
        else if (input == 12 || input == 1 || input == 2)
        {
            Console.WriteLine("겨울입니다.");
        }
        else
        {
            Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
        }
    }
}