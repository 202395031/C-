internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫번째 정수를 입력하시오 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("두번째 정수를 입력하시오 : ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1-num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + ((float)num1 / num2).ToString("0.00"));
        Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));

    }
}