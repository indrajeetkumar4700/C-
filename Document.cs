using System;
 
class IfSelect
{
    public static void Main()
    {
        string myInput;
        int myInt;

        Console.Write ("Please enter a number: ");
        myInput = Console.ReadLine();
        myInt = Int32.Parse(myInput);

        if (myInt > 0)
        {
            Console.WriteLine ("Your number {0} is greater than zero.", myInt);
        }
 
        if (myInt < 0)
            Console.WriteLine ("Your number {0} is less than zero.", myInt);

        if (myInt != 0)
        {
            Console.WriteLine ("Your number {0} is not equal to zero.", myInt);
        }
        else
        {
            Console.WriteLine ("Your number {0} is equal to zero.",myInt);
        }

        if (myInt < 0 || myInt == 0)
        {
            Console.WriteLine ("Your number {0} is less than or equal to zero.", myInt);
        }
        else if (myInt > 0 && myInt < 10)
        {
            Console.WriteLine ("Your number {0} is between 1 and 10.", myInt);
        }
        else if (myInt > 11 && myInt < 20)
        {
            Console.WriteLine ("Your number {0} is between 11 and 20.", myInt);
        }
        else if (myInt > 21 && myInt < 30)
        {
            Console.WriteLine ("Your number {0} is between 21 and 30.", myInt);
        }
        else
        {
            Console.WriteLine ("Your number {0} is greater than 30.", myInt);
        }
    }
}