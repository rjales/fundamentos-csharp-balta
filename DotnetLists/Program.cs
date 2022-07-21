using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            // int[] meuArray2 = new int[9]; // 2ª forma

            // Console.WriteLine(meuArray.Length);

            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}