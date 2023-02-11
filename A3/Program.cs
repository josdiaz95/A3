namespace A3;
class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        var myDay = $"{today:dddd}";
        var myTime = $"{today:hh}:{today:mm}{today:tt}";
        var myDate = $"{today:MMMM} {today:dd},{today:yyyy}";



        Console.WriteLine($"1.{myDate,40}");
        Console.WriteLine($"2.{today:yyyy}.{today:MM}.{today:dd}");
        Console.WriteLine($"3.Day {today:dd} of {today:MMMM},{today:yyyy}");
        Console.WriteLine($"4.Year:{today:yyyy},Month:{today:MM},Day:{today:dd}");
        Console.WriteLine($"5.{myDay,10}");
        Console.WriteLine($"6.{myTime,10}{myDay,10}");
        Console.WriteLine($"7.h:{today:hh},m:{today:mm},s:{today:ss}");
        Console.WriteLine($"8.{today:yyyy}.{today:MM}.{today:dd}.{today:hh}.{today:mm}.{today:ss}");
        var pi = Math.PI;
        Console.WriteLine($"{pi:C}");
        Console.WriteLine($"{pi,10:f3}");


    }
}