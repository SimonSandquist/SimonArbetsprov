using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public static String GetTimeStamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmss");
        }


        static void Main(string[] args)
        {
            string word = "";
            string time = "";
            Console.WriteLine("Type a word: ");
            word = Console.ReadLine();
            time = GetTimeStamp(DateTime.Now);
            Console.WriteLine(time);
            Console.WriteLine(word);
            

        }


    }
}
