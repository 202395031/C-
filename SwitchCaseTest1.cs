internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("점수 입력 : ");
        int input = int.Parse(Console.ReadLine());

        int score = input / 10;

        switch (score)
        {
            case 6:
                Console.WriteLine("D학점");
                break;
            case 7:
                Console.WriteLine("C학점");
                break;
            case 8:
                Console.WriteLine("B학점");
                break;
            case 9:
                Console.WriteLine("A학점");
                break;
            default:
                if(input == 100)
                {
                    Console.WriteLine("A학점");
                    break;
                }
                Console.WriteLine("재수강으로 분발하세요.");
                break;
        }
    }
}