using System;
 
class OutputClass 
{
    string myString = "Initnal value";

    public void printString() 
    {
        Console.WriteLine("Printing from printString method: {0}", myString);
    }
 
    public string getString() 
    {
        return myString;
    }
 
    public void setString(string inpString) 
    {
        myString = inpString;
    }
 
}
 
class ExampleClass 
{
    public static void Main() 
    {
        OutputClass outCl = new OutputClass();
 
        outCl.printString();
 
        Console.WriteLine("The string is: " + outCl.getString());
 
        outCl.setString("Modified string");

        outCl.printString();
 
        Console.WriteLine("The string is: " + outCl.getString());
    }
}
