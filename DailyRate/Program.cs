using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        void Run()
        {
            double DailyRate = ReadDouble("Enter your daily rate: ");
            int NoOfDays = ReadInt("Enter the number of days: ");
            WriteFee(CalculateFee(DailyRate, NoOfDays));
        }

        private void WriteFee(double v) => Console.WriteLine($"The consultant`s fee is: {v * 1.1}");

        private double CalculateFee(double DailyRate, int NoOfDays) => DailyRate * NoOfDays;

        private int ReadInt(string v)
        {
            Console.Write(v);
            string Line = Console.ReadLine();
            return int.Parse(Line);
        }

        private double ReadDouble(string v)
        {
            Console.Write(v);
            string Line = Console.ReadLine();
            return double.Parse(Line);
        }
    }
}
   
