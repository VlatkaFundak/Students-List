using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Students.Code
{
    /// <summary>
    /// Validation class.
    /// </summary>
    public class Validation
    {
        #region Public methods

        /// <summary>
        /// Validation of operation input.
        /// </summary>
        /// <param name="userInput">Input user.</param>
        /// <returns>True if valid input.</returns>
        static public bool OperationInput(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "enlist":
                    return true;
                case "display":
                    return true;
                default:
                    Console.WriteLine("You have typed non-existing operation, please try again:");
                    return false;
            }
        }

        /// <summary>
        /// Validation of the gpa input.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>True if input is correct.</returns>
        static public bool GPAInput (string userInput)
        {
            double userInputNumber = 0;

            if (!InputEmptySpaces(userInput))
            {
                return true;
            }
            else if (!Double.TryParse(userInput, out userInputNumber))
            {
                Console.WriteLine("You need to insert numerical value.");
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Validation of empty input.
        /// </summary>
        /// <param name="userInput">User input.</param>
        /// <returns>False if user entered empty space or null.</returns>
        static public bool InputEmptySpaces(string userInput)
        {
            if (userInput == String.Empty || userInput == null)
            {
                Console.WriteLine("You need to insert value.");
                return false;
            }
            else
                return true;
        }

        #endregion

    }
}
