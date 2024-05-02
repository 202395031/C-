/*class Car
{
   int carNumber;
   public DateTime inTime;
   public DateTime outTime;

   public void SetInTime() 
   { 
       this.inTime = DateTime.Now;
       Console.WriteLine(inTime.ToString());
   }
   public void SetOutTime()
   {
       this.outTime = DateTime.Now;
       Console.WriteLine(outTime.ToString());
   }
}*/

using ClassTest1;
internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.SetInTime();
        car.SetOutTime();
        Console.WriteLine($"출입시간 : {car.inTime}\n출차시간 : {car.outTime}");
    }
}