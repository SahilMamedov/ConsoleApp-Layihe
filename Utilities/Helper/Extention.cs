using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
   public static class Extention
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static bool AgeCheck(this int age)
        {
            bool result = false;
            if(age >= 18 && age <= 40)
            {
                result = true;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Age 18-den boyuk ve 40-dan kicik olmalidir");
               
            }
           
         
            return result;
        }
    }
}
