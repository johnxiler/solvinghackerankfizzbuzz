using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * used any number in the test cases like 150
     * The function accepts INTEGER n as parameter.
     */
    
    public static void fizzBuzz(int n)
    {
        int i = 0;
        while (i < n)
        {  
            i = n + 1;

            if (n % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else if (n % 15 == 0)
            {
                Console.WriteLine("fizzbuzz"); // for multiples of both 3 and 5  
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
