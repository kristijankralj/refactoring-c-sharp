using System;
namespace MakingMethodCallsSimpler
{
    public class Practice
    {
        public static void CountDigitsInNumber()
        {
            int numValue = -1;

            Console.WriteLine("Enter a positive int number: ");
            string input = Console.ReadLine();

            try
            {
                numValue = Convert.ToInt32(input);
            }
            catch (FormatException)
            {
                throw new Exception("Input string is not in integer.");
            }
            finally
            {
                int digits = GetDigits(numValue, 0);
                Console.WriteLine("number of lines:" + digits);
            }
        }

        public static int GetDigits(int n1, int nodigits)
        {
            if (n1 == 0)
            {
                return nodigits;
            }
            return GetDigits(n1 / 10, ++nodigits);
        }
    }
}
