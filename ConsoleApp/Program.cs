

using System.Diagnostics;

class Program
{
    public static void Main()
    {
        while (true)
        {
            //-------------------------------------------------------------------------------
            //int currentHour = DateTime.Now.Hour;
            //int currentMinute = DateTime.Now.Minute;
            //int currentSecond = DateTime.Now.Second;
            //Console.Clear();
            //Console.WriteLine(currentHour + ":" + currentMinute + ":" + currentSecond);
            //Thread.Sleep(1000);
            //--------------------------------------------------------------------------------
            DateTime dt = DateTime.Now;
            string currentTime = DateTime.Now.ToString("HH:m:ss");
            Console.Clear();
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

    }
}