using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_8
    {
        static void Main1(string[] args)
        {
            Console.Write("생일 입력(yyyy/mm/dd) : ");
            string birth = Console.ReadLine();
            string[] bArr = birth.Split("/");

            int bYear = int.Parse(bArr[0]);
            int bMonth = int.Parse(bArr[1]);
            int bDay = int.Parse(bArr[2]);

            int tYear = DateTime.Today.Year;
            int tMonth = DateTime.Today.Month;
            int tDay = DateTime.Today.Day;


            int totalDays = 0;

            totalDays += DayOfYear(tYear, tMonth, tDay);

            int yearsDays = IsLeapYear(bYear) ? 366 : 365;
            totalDays += yearsDays - DayOfYear(bYear, bMonth, bDay);

            for (int year = bYear + 1; year < tYear; year++)
            {
                if (IsLeapYear(year))
                    totalDays += 366;
                else
                    totalDays += 365;
            }

            Console.WriteLine(totalDays);
            

        }
       static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        static int DayOfYear(int year, int month, int day)
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
        static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
