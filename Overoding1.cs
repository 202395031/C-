internal class Program
{
    class MyMath
    {
        public void Abs(int input)
        {
            if (input < 0)Console.WriteLine(-input);
            else Console.WriteLine(input);
        }
        public void Abs(double input)
        {
            if (input < 0) Console.WriteLine(-input);
            else Console.WriteLine(input);
        }
        public void Abs(long input)
        {
            if (input < 0) Console.WriteLine(-input);
            else Console.WriteLine(input);
        }
        
    }
    private static void Main(string[] args)
    {
        MyMath myMath = new MyMath();
        myMath.Abs(52);
        myMath.Abs(-273);
        myMath.Abs(52.273);
        myMath.Abs(-32.103);
        myMath.Abs(21474836470);
        myMath.Abs(-21474836470);
    }
}