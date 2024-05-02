internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("나이 입력 : ");
        // Console.ReadLine()은 int.Parse를 해야 정수로 입력받을 수 있다.
        int age = int.Parse(Console.ReadLine());

        if (age >= 9)
        {
            Console.Write("키 입력 : ");
            int height = int.Parse(Console.ReadLine());
            if (height >= 130)
            {
                Console.WriteLine("고속 롤러코스트 입장 가능");
            }
            else
            {
                Console.WriteLine("저속 롤러코스트 입장 가능");
            }
        }
        else
        {
            Console.WriteLine("입장 불가!");
        }
    }
}