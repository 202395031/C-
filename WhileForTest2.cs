internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("시작문자 입력 : ");
        char char1 = char.Parse(Console.ReadLine());
        Console.Write("끝문자 입력 : ");
        char char2 = char.Parse(Console.ReadLine());


        for(int i = char1; i <= char2; i++)
        {
            Console.Write($"{(char)i, -3}"); // 3은 왼쪽 정렬, -3은 오른쪽 정렬
        }
    }
}