using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_consoleagain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓名:");
            string Name = Console.ReadLine();
            Console.WriteLine( "歡迎來到C#!"+Name);
            Console.ReadKey();
        }
    }
}
