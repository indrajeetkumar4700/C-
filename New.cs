using System;
 
class InteractiveWelcome
{
    public static void Main()
    {
        Console.WriteLine("tea");
        Console.WriteLine("coffe");
        Console.WriteLine("Dosa");
        Console.WriteLine("pizza");
        Console.WriteLine("burger");
        Console.Write("What Do uyou wanna order?: ");
        Console.Write("Thanks for ordering from here, {0}! ", Console.ReadLine());
        Console.WriteLine("Have a great time.thanks!");
        Console.ReadLine();
    }
}

