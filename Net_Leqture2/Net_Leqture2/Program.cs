﻿using System;


namespace Net_Leqture2
{
    class Program
    {
        public static void parceString()
        {
            int number = 0;
            bool isParsed = false;
            while (!isParsed)
            {
                String s = Console.ReadLine();
                
                  isParsed = int.TryParse(s, out number);

                if (isParsed)
                {
                    Console.WriteLine("parsed: "+ number);
                }
                else
                {
                    Console.WriteLine("Can't parce String,try again");
                }

               

            }

        }

        static void Main(string[] args)
        {

            //String s = Console.ReadLine();
            //int d = int.Parse("123334");
            //int i = 0;

            //bool isParsed = int.TryParse(s, out d);
            //Console.WriteLine(d);


            //if (int.TryParse(s, out i))
            //{
            //    Console.WriteLine("parsed");
            //}
            //else
            //{
            //    Console.WriteLine("Can't parce");
            //}

            parceString();
            Console.ReadLine();
           
        }
    }
}
