using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new int[3];

            try
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
                    Console.WriteLine(arrays[3]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something went wrong :(");
            }
            finally
            {
                Console.WriteLine("It's over");
            }
            Save("");
        }

        static void Save(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("The text can't be null or empty.");
            }
        }
    }
}