// See https://aka.ms/new-console-template for more information
using System.Timers;

Console.WriteLine("Timer Example");

System.Timers.Timer myTimer =new System.Timers.Timer(2000);

myTimer.Elapsed += MyTimer_Elapsed;

myTimer.Elapsed += MyTimer_Elapsed1;

myTimer.Start();

Console.WriteLine("Press Enter to remove the green event");
Console.ReadLine();

myTimer.Elapsed -= MyTimer_Elapsed1;

Console.ReadLine();

void MyTimer_Elapsed1(object? sender, ElapsedEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);

    myTimer.Start();
    Console.ReadLine();

}
    void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
    }
