using System;

namespace MobileBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Start Time");
            string startTimeString = Console.ReadLine();

            Console.WriteLine("Please Enter End Time");
            string endTimeString = Console.ReadLine();
            
            TimeSpan startTime = TimeSpan.Parse(startTimeString.Split(' ')[1]);
            TimeSpan endTime = TimeSpan.Parse(endTimeString.Split(' ')[1]);

            TimeSpan pickStart = TimeSpan.Parse("9:00:00");
            TimeSpan pickEnd = TimeSpan.Parse("23:59:59");

            TimeSpan offPickOneStart = TimeSpan.Parse("12:00:00");
            TimeSpan offPickOneEnd = TimeSpan.Parse("21:59:59");

            TimeSpan offPickTwoStart = TimeSpan.Parse("23:00:00");
            TimeSpan offPickTwoEnd = TimeSpan.Parse("23:59:59");

            TimeSpan pulse = TimeSpan.Parse("00:00:20");
         
            int amount = 0;
           
            do
            {
                if (startTime >= pickStart && startTime <= pickEnd)
                {
                    amount += 30;
                }
                else if (startTime >= offPickOneStart && startTime <= offPickOneEnd)
                {
                    amount += 20;
                }
                else if (startTime >= offPickTwoStart && startTime <= offPickTwoEnd)
                {
                    amount += 20;
                }
                startTime.Add(pulse);
            } while (startTime <= endTime);

            double total = amount / 100;
            Console.WriteLine($"Total bill: {total}Tk");

        }
    }
}
