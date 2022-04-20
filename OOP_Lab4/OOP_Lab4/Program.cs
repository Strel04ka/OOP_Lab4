using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{

    class Data 
    {
        private int day;
        private int month;
        private int year;

        public void setDay(int a) { if (a < 1 || a > 31) { day = 1; } else { this.day = a; } }
        public void setMonth(int a) { if (a < 1 || a > 12) { month = 1; } else { this.month = a; } }
        public void setYear(int a) { if (a < -10000 || a > 2077) { year = 1; } else { this.year = a; } }
        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }
        public void Read() 
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
        public void Read(string a)
        {
            string Smonth = " ";
            if (month == 1) Smonth = "січня"; if (month == 2) Smonth = "лютого"; if (month == 3) Smonth = "березень"; if (month == 4) Smonth = "квітеня";
            if (month == 5) Smonth = "травеня"; if (month == 6) Smonth = "червеня"; if (month == 7) Smonth = "липеня"; if (month == 8) Smonth = "серпеня";
            if (month == 9) Smonth = "вересня"; if (month == 10) Smonth = "жовтня"; if (month == 11) Smonth = "листопада"; if (month == 12) Smonth = "грудня";
            Console.WriteLine($"{day} {Smonth} {year} року");
        }
        public void Write() 
        {
            Console.Write($"Day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Data a = new Data();
            a.setDay(23);
            a.setMonth(8);
            a.setYear(2003);
            a.Read();
            a.Write();
            a.Read("-t");

            Console.ReadKey();
        }
    }
}
