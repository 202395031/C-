internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;
        int[] intArray = new int[5];

        while(i < intArray.Length)
        {
            Console.Write($"{i+1}번째 정수를 입력하세요. : ");
            intArray[i] = int.Parse(Console.ReadLine());
            i++;
        }
        Console.WriteLine("\n[출력]");
        for(i=0; i < intArray.Length; i++)
        {
            Console.WriteLine($"{i+1}번째 값 : {intArray[i]}");
        }
    }
}