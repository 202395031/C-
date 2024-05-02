internal class Program
{
    class AddNum
    {
        public long Add(int i)
        {
            if (i == 0) { return 0; }
            return i+Add(i-1);
        }
    }
    private static void Main(string[] args)
    {
        AddNum addNum = new AddNum();
        Console.Write("정수를 입력하시오. : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"1부터 {num}까지의 합은 : {addNum.Add(num)}"); 
    }
}