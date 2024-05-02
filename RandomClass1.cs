internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("생성할 랜덤 수의 갯수를 입력하시오. : ");
        int[] intArray = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < intArray.Length; i++) 
        {
            intArray[i] = r.Next(1, 11);
            for (int j = 0; j < i; j++)
            {
                if (intArray[j] == intArray[i])
                {
                    i--;
                    break;
                }
            }
        }
        Console.WriteLine($"생성된 {intArray.Length}개의 랜덤한 숫자 출력");
        foreach (int value in intArray)
        {
            Console.Write("{0, 5}", value);
        }
    }
}