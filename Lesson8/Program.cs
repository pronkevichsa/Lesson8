using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace RunningString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string s = Console.ReadLine();
            Console.Clear();
            StringBuilder sb = new StringBuilder(s);
            int index = 0;
            while (true)
            {                
                Console.WriteLine(sb);
                Thread.Sleep(200);
                Console.Clear();
                sb.Remove(0, 1);
                sb.Append(s[index]);
                index++;
                index = (index == s.Length) ? 0 : index;
            }
        }
    }
}
