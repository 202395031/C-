internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("생성할 랜덤 수의 갯수를 입력하시오. : ");
        int[] intArray = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = r.Next(1, 100);
            for (int j = 0; j < i; j++)
            {
                if (intArray[j] == intArray[i])
                {
                    i--;
                    break;
                }
            }
        }
        Console.Write("랜덤값 출력 :");
        foreach (int value in intArray)
        {
            Console.Write("{0, 4}", value);
        }
        int max = 0, min = 1000;
        for (int k = 0; k < intArray.Length; k++)
        {
            if (intArray[k] > max)max = intArray[k];
            if (intArray[k] < min)min = intArray[k];
        }
        Console.WriteLine($"\n최댓값 : {max}");
        Console.WriteLine($"최소값 : {min}");
    }
}