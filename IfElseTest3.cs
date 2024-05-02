internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫 번째 정수 입력 : ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("두 번째 정수 입력 : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("세 번째 정수 입력 : ");
        int num3 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            if (num3 < num2)
            {
                Console.WriteLine("중간 값은 : " + num2);
            }
            else
            {   
                if(num1 > num3)
                {
                    Console.WriteLine("중간 값은 : " + num3);
                }
                else
                {
                    Console.WriteLine("중간 값은 : " + num1);
                }
            }
        }
        else
        {
            if (num3 < num1)
            {
                Console.WriteLine("중간 값은 : " + num1);
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine("중간 값은 : " + num2);
                }
                else
                {
                    Console.WriteLine("중간 값은 : " + num3);
                }
            }
        }
    }
}