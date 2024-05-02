internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("2자리 정수 입력(10~99) : ");
        int num = int.Parse(Console.ReadLine());

        if (num > 99 || num < 10)
        {
            Console.WriteLine("10~99 사이의 정수만 입력하세요.");
        }
        else
        {
            if (num / 10 == num % 10)
            {
                Console.WriteLine("Yes! 10의 자리와 1의 자리가 같습니다.");
            }
            else
            {
                Console.WriteLine("10의 자리와 1의 자리가 다릅니다.");
            }
        }
    }
}