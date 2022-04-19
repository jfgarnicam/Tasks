using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class TestStringToInteger
    {
        /*Function to test theStringToInt function according to certain input strings.
         */
        public static void testStringToInteger()
        {
            string charactersTest1 = "";
            string charactersTest2 = "      ";
            string charactersTest3 = "   +56kfjhfh";

            if(StringToInteger.stringToInteger(charactersTest1).Equals(0))
            {
                Console.WriteLine("Empty string test passed");
            }
            else
            {
                Console.WriteLine("Empty string test failed");
            }

            if (StringToInteger.stringToInteger(charactersTest2).Equals(0))
            {
                Console.WriteLine("Whitespaces string test passed");
            }
            else
            {
                Console.WriteLine("Whitespaces string test failed");
            }

            if (StringToInteger.stringToInteger(charactersTest3).Equals(+56))
            {
                Console.WriteLine("Whitespaces string test passed");
            }
            else
            {
                Console.WriteLine("Whitespaces string test failed");
            }
        }

    }
}