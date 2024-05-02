internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("생성할 랜덤 수의 갯수를 입력하시오. : ");
        int num = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        // list.Add() 리스트에서 마지막에 값을 추가한다.
        for (int i = 0; i < num; i++)
        {
            list.Add(r.Next(1, 100));
        }

        // list.Count 리스트의 크기를 가져오는 메소드
        Console.WriteLine("Count : " + list.Count);
        Console.Write("Item :");
        foreach (var item in list)
        {
            Console.Write("{0, 3}", item);
        }
        Console.WriteLine("\n\n[0번지와 맨앞에서 3개 지운 리스트]");

        // list.RemoveAt() 인덱스 값을 넣어서 해당 되는 인덱스에 있는 걸 지운다.
        list.RemoveAt(0);   // 0을 넣었으므로 0번지의 값이 지워진다.

        // list.RemoveRange(인덱스, 범위) 해당되는 인덱스에서 범위만큼 값을 지운다. 
        list.RemoveRange(0, 3); // (0, 3) 이므로 0번지에서 3만큼 지운다.
        Console.WriteLine("\nCount : " + list.Count);
        Console.Write("Item(remove) :");
        foreach (var item in list)
        {
            Console.Write("{0, 3}", item);
        }
    }
}