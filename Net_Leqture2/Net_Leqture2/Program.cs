using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Leqture2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int i = int.Parse("123334");
           
            bool isParsed = int.TryParse(s, out i);
            Console.WriteLine(i);
           

            if (isParsed)
            {
                Console.WriteLine("parsed");
            }
            else
            {
                Console.WriteLine("Can't parce");
            }
             Console.ReadLine();

        }
    }
}
