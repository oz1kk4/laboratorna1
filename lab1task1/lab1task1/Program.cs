using System;
using System.Threading;
namespace lab1task1
{
    public delegate void TimerDelegate(int seconds);
    class Program
    {
        static void ShowMessage(int seconds)
        {
            Console.WriteLine($"Таймер вiдлiкував {seconds} секунд");
        }

        static void Main(string[] args)
        {
            Timer timer1 = new Timer(ShowMessage, 5);
            Timer timer2 = new Timer(ShowMessage, 10);

            timer1.Start();
            timer2.Start();

            Thread.Sleep(30 * 1000);

            timer1.Stop();
            timer2.Stop();
        }
    }
}