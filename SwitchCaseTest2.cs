// $ == 파이썬기준 print(f"{a}")랑 같음

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫번째 정수를 입력하세요 : ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("연산자를 입력하세요(+,-,*,/,%) : ");
        char oper = Char.Parse(Console.ReadLine());
        Console.Write("두번째 정수를 입력하세요 : ");
        int num2 = int.Parse(Console.ReadLine());

        switch(oper)
        {
            case ('+'):
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                break;
            case ('-'):
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                break;
            case ('/'):
                Console.WriteLine($"{num1} / {num2} = {num1/(Double)num2 :F3}");
                break;
            case ('%'):
                Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
                break;
            case ('*'):
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                break;
            default:
                Console.WriteLine("잘못된 연산자입니다.");
                break;
        }
    }
}
