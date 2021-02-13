using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTasks
{
    class Program
    {

        public static double CalculateAge(int birthmonth,int year)
        {
            int pyear = 2021;
            int pmonth = 2;
            if (birthmonth < 0 || year < 0)
            {
                return -1;
            }
            if (birthmonth > pmonth && year > pyear)
            {
                return -2;
            }
            double count = 0;

            for (int i = year; i < pyear; i++)
            {
                count++;
            }

            int months = birthmonth - pmonth;
            double totalMonths = (count * 12) - months;
            double age = totalMonths / 12;

            return age;




        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAge(0,-17));
        }
    }
}
