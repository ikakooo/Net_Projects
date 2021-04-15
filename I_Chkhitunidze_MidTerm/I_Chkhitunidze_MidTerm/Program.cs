using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Chkhitunidze_MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

            calculator();



            ///Task 2
            Student student1 = new Student();

            student1.cars.Add("Mersedes");
            student1.cars.Add("Wolwo");
            student1.cars.Add("BMW");
            student1.cars.Add("Mersedes");

            student1.banckAcounts.bog = true;
            student1.banckAcounts.liberti = true;
            student1.banckAcounts.tbc = true;
            ///Task 1
            Console.WriteLine( GetHostingCountry("google.com"));
            Console.ReadKey();
        }



        ///Task 1
        static String GetHostingCountry(string URL)
        {
            if (URL.Contains("ge"))
            {
                return "GEORGIA";
            }else if(URL.Contains("us")){
                return "USA";
            }
            else if (URL.Contains("fr"))
            {
                return "France";
            }
            else if (URL.Contains("tr"))
            {
                return "Turkey";
            }
            else if (URL.Contains("pl"))
            {
                return "Poland ";
            }
            else if (URL.Contains("com"))
            {
                return "GLOBAL ";
            }
            else
            {
                return "Not detected!";
            }
        }

        // TASK 3  Calculator
        public static void calculator()
        {

            try
            {   Console.WriteLine("input for calculation");
            string textForCalculation = Console.ReadLine();
            textForCalculation = textForCalculation.Replace(" ", String.Empty);

            string value = new DataTable().Compute(textForCalculation, null).ToString();
            Console.WriteLine(value);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
            }
         
        }

    }
}
