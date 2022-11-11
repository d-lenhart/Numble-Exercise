using GSF;
using GSF.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadaxCodingAssessment
{
    public class Methods
    {
        Char[] validNumbers = new Char[6] { '1', '2', '3', '4', '5', '6' };
        public bool IsValidNumber(string userGuess)
        {
            bool success = false;

            foreach (char c in userGuess)
            {
                if (!this.validNumbers.Contains(c))
                {
                    Console.WriteLine("Invalid entry, please try again.");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    success = true;
                }
            }
            return success;

        }

        public string CheckGuess(string userGuess, string generatedAnswer)
        {
            string userResult = "";

            for (int i = 0; i < 4; i++)
            {
                if (userGuess[i] == generatedAnswer[i])
                {
                    userResult += "+";
                }
                else if ((userGuess[i] != generatedAnswer[i]) && (generatedAnswer.Contains(userGuess[i])))
                {
                    userResult += "-";
                }
                else
                {
                    userResult += " ";
                }
            }
            return userResult;
        }
    }
}
