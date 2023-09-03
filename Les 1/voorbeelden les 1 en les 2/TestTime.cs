using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class TestTime
    {
        public struct Time
        {
            private readonly int minutes;
            public Time(int hh, int mm)
            {
                this.minutes = 60 * hh + mm;
            }
            public int Hour
            {
                get
                {
                    return minutes / 60;
                }
            }

            public int Minute
            {
                get
                {
                    return minutes % 60;
                }
            }

            public override String ToString()
            {
                return minutes.ToString();
            }

            //String.Format
            //public override string ToString()
            // {
            //    return String.Format("{0:D2}:{1:D2}", Hour, Minute);
            //}

            // string interpolatie
            // public string ToStringInterpolated()
            // {
            //     return $"{Hour:D2}:{Minute:D2}";
            // }

            class Program
            {
                static void Main(string[] args)
                {
                    Time time1 = new Time(8, 30);
                    Console.WriteLine("Uur van Tijd 1: " + time1.Hour);
                    Console.WriteLine("Minuut van Tijd 1: " + time1.Minute);
                    Time time2 = new Time(15, 45);
                    Console.WriteLine("Uur van Tijd 2: " + time2.Hour);
                    Console.WriteLine("Minuut van Tijd 2: " + time2.Minute);
                    Time time3 = new Time(21, 0);
                    Console.WriteLine("Uur van Tijd 3: " + time3.Hour);
                    Console.WriteLine("Minuut van Tijd 3: " + time3.Minute);


                    Console.WriteLine("Tijd 1: " + time1);
                    Console.WriteLine("Tijd 2: " + time2);
                    Console.WriteLine("Tijd 3: " + time3);


                    Time invalidTime = new Time(25, 70);
                    // Console.WriteLine("Met String.Format:");
                    // Console.WriteLine("Tijd 1: " + time1.ToString());
                    // Console.WriteLine("Tijd 2: " + time2.ToString());
                    // Console.WriteLine("Tijd 3: " + time3.ToString());

                    // Console.WriteLine("\nMet string interpolatie:");
                    // Console.WriteLine("Tijd 1: " + time1.ToStringInterpolated());
                    // Console.WriteLine("Tijd 2: " + time2.ToStringInterpolated());
                    // Console.WriteLine("Tijd 3: " + time3.ToStringInterpolated());

                }
            }

        }
    }
}
