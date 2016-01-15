using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0, minutes, seconds;
            Console.Write("Please. Enter time as second:");
            seconds = int.Parse(Console.ReadLine());
            if (seconds >= 60) ;
            {
                minutes = seconds / 60;
                seconds = seconds % 60;
                hours = minutes / 60;
                minutes = minutes % 60;
                Console.Write("{0}hours {1}minutes {2}seconds", hours, minutes, seconds);
            }
            




        }
    }
}
