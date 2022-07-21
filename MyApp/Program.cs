using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(2022, 10, 6, 8, 34, 22);
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.DayOfWeek);

            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNenosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNenosegundos);

            var data = DateTime.Now;

            var formatada = String.Format("{0:dd/MM/yyyy}", data);
            var formatada2 = String.Format("{0:r}", data);
            var formatada3 = String.Format("{0:s}", data);
            var formatada4 = String.Format("{0:u}", data);
            Console.WriteLine(formatada);
            Console.WriteLine(formatada2);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);


            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", CultureInfo.CurrentCulture));

            var dateTime = DateTime.UtcNow;

            Console.WriteLine(dateTime);

            Console.WriteLine(dateTime.ToLocalTime());
            Console.WriteLine(dateTime.ToUniversalTime());
        }
    }
}