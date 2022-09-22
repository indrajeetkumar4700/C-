using System;
 
class MultiArrayProgram 
{
    public static void Main() 
    {
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            Console.Write("{0} ", i);
        }
 
        Console.WriteLine("");
string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },     { "five", "six" } };

int[, ,] array3D = new int[,,] {​ {​ {​ 1, 2, 3 }​, {​ 4, 5, 6 }​ }​, {​ {​ 7, 8, 9 }​, {​ 10, 11, 12 }​ }​ }​;

int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

        // Declare the array of two elements: 

        int[][] arr = new int[2][];         // Initialize the elements:

        arr[0] = new int[5] {​​​​​ 1, 3, 5, 7, 9 }​​​​​;

        arr[1] = new int[4] {​​​​​ 2, 4, 6, 8 }​​​​​;         // Display the array elements: 

        for (int i = 0; i < arr.Length; i++)

        {​​​​​

            System.Console.Write("Element({​​​​​0}​​​​​): ", i);             for (int j = 0; j < arr[i].Length; j++)

            {​​​​​

                System.Console.Write("{​​​​​0}​​​​​{​​​​​1}​​​​​", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");

            }​​​​​

            System.Console.WriteLine();            

        }​​​​​         System.Console.WriteLine("Press any key to exit.");

        System.Console.ReadKey();



        System.Console.WriteLine(array2D[0, 0]);

        System.Console.WriteLine(array2D[0, 1]);

        System.Console.WriteLine(array2D[1, 0]);

        System.Console.WriteLine(array2D[1, 1]);

        System.Console.WriteLine(array3Da[1, 0, 1]);

        System.Console.WriteLine(array3D[1, 1, 2]);




 
        int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
        foreach (int i in numbers2D)
        {
            Console.Write("{0} ", i);
        }
 
        Console.WriteLine("");
 
        // Or use the short form: 
        int[,] numbers2D_1 = { { 9, 99 }, { 3, 33 }, { 5, 55 } }; 
        foreach (int i in numbers2D_1)
        {
            Console.Write("{0} ", i);
        }
 
        Console.WriteLine("");
 
    }
}