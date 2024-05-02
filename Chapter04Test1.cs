internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("입력할 숫자의 개수 : ");
        int num = int.Parse(Console.ReadLine());
        int input;
        int sum = 0;
        for (int i = 1; i < num+1; i++)
        {
            Console.Write($"{i} 번째 : ");
            input = int.Parse(Console.ReadLine());
            if (input < 0 || input > 10)
            {
                Console.WriteLine("유효한 수가 아님! 다시 입력");
                i--;
            }
            else
            {
                sum += input;
            }
        }
        Console.WriteLine($"합계 : {sum}, 평균 : {(float)sum/num:F2}");
    }
}