using System.Runtime.CompilerServices;

internal class Program
{
    class Box
    {
        private int width;
        private int height;
        
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); width = -value; }
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); height = -value; }
            }
        }
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area() 
        {
            if (width < 0 && height < 0) { return width * height; }
            else if (height < 0) { return width * -height; }
            else if (width < 0) { return  height * -width; }
            else { return width * height; }
        }
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }
        public void SetWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 양수를 입력해주세요"); this.width = width; }
        }
        public void SetHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 양수를 입력해주세요"); this.height = height; }
        }
    }
    private static void Main(string[] args)
    {
        //Box box = new Box();
        //Console.Write("너비를 적으시오 : ");
        //box.SetWidth(int.Parse(Console.ReadLine()));
        //Console.Write("높이를 적으시오 : ");
        //box.SetHeight(int.Parse(Console.ReadLine()));
        //Console.WriteLine($"면적 : {box.Area()}");

        Box box = new Box(-5, 5);
        Console.Write("높이를 적으시오 : ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("너비를 적으시오 : ");
        int height = int.Parse(Console.ReadLine());

        box.Width = width;
        box.Height = height;
        Console.WriteLine($"{box.Width} x {box.Height} = {box.Area()}");
    }
}