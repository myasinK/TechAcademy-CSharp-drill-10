using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional Array of strings. 
            // Ask the user to input some text. 
            // Create a loop that goes through each string in the Array, 
            // adding the user’s text to the string. 
            // Then create a loop that prints each string in the Array on a separate line.
            // string[] strArray = new string[10];
            string[] strArray = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            Console.WriteLine("Please enter some text: ");
            string userStr = Console.ReadLine();
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i] + userStr;
                // Console.WriteLine(strArray[i]);
            }

            // separate loop for practice?
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            // The following is an infinite loop. To fix it, 
            // uncomment commented line inside while loop
            //int init = 0;
            //while (init < 5)
            //{
            //    Console.WriteLine("This is an infinite loop");
            //    // init++;
            //}

            // Create a loop where the comparison used to determine 
            // whether to continue iterating the loop is a “<” operator.
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("x is less than 5");
                x++;
            }

            // Create a loop where the comparison used to determine 
            // whether to continue iterating the loop is a “<=” operator.
            x = 0;
            while (x <= 5)
            {
                Console.WriteLine("x is less than, or equal to 5");
                x++;
            }

            // Create a List of strings where each item in the list is unique. 
            // Ask the user to select text to search for in the List. 
            // Create a loop that iterates through the loop and then displays 
            // the index of the array that contains matching text on the screen.
            // Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> list = new List<string>();
            for (int j = 0; j < strArray.Length; j++)
            {
                list.Add( strArray[j] );
            }
            Console.WriteLine("Enter text to find its corresponding index in the list: ");
            string strToSearch = Console.ReadLine();
            bool found = false;
            int init = 0;
            foreach (string text in list)
            {
                if (strToSearch == text)
                {
                    Console.WriteLine("Index of your text is " + Convert.ToString(init));
                    found = true;
                    // Add code that stops it from executing once a match has been found
                    break;
                }
                init++;
            }
            if (!found)
            {
                Console.WriteLine("Your text was not found in the list");
            }

            // Create a List of strings that has at least two identical strings in the List. 
            // Ask the user to select text to search for in the List. Create a loop that 
            // iterates through the loop and then displays the indices of the array that 
            // contain matching text on the screen.
            // Add code to that above loop that tells a user if they put in text that isn’t in the List.
            // Using previous list:

            // Make a duplicate item in the list 
            list.Add(list[4]);

            Console.WriteLine("Enter text to find its corresponding index in the list: ");
            strToSearch = Console.ReadLine();
            found = false;
            init = 0;
            foreach (string text in list)
            {
                // Console.WriteLine(text);
                if (strToSearch == text)
                {
                    if (found)
                    {
                        Console.WriteLine("This text is also at index "+ Convert.ToString(init)); 
                    }
                    else
                    {
                        Console.WriteLine("Index of your text is " + Convert.ToString(init));
                        found = true;
                    }

                }
                init++;
            }
            if (!found)
            {
                Console.WriteLine("Your text was not found in the list");
            }

            // Create a List of strings that has at least two identical strings in the List. 
            // Create a foreach loop that evaluates each item in the list, and displays 
            // a message showing the string and whether or not it has already appeared in the list.
            // Using previous list
            init = 0;
            foreach (string text in list)
            {
                Console.WriteLine(text);
                if ( list.GetRange(0, init).Contains( text ) && init > 0 )
                {
                    Console.WriteLine("This has already appeared in the list");
                }
                init++;
            }
            Console.ReadLine();
        }
    }
}
