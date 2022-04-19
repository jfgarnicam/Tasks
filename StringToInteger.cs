using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class StringToInteger
    {
        /*
        The function takes a string as the only argument and returns an integer.
        characters: string with white spaces and + sign
        returns int.
        */
        public static int stringToInteger(string characters)
        {
            // Flag that remains false if "-" or "+" signal is not detected 
            bool flagSign = false;
            // Number found in the string after the + or - sign
            string foundNumber = "";

            // Empty character string
            if (characters.Count() == 0)
            {
                return 0;
            }

            // Iterate for each character, when the sign (+ or -) is found,
            // concatenate the digits in the string foundNumber.
            foreach (char c in characters)
            {
                if (c.Equals('+') || c.Equals('-') && flagSign == false)
                {
                    flagSign = true;
                    foundNumber += c;
                    continue;
                }
                if (flagSign == true)
                {
                    if (char.IsDigit(c))
                    {
                        foundNumber += c;
                    }
                    else
                    {
                        //the next characters are irrelevant if no digit is found immediately after the sign.
                        break;
                    }
                }

            }

            // If no digits were found, the length of founnumber is 0, or 1 if only the sign was found.
            if (foundNumber.Count() == 0 || foundNumber.Count() == 1)
            {
                return 0;
            }

            return int.Parse(foundNumber);

        }
    }
}