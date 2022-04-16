using System;

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
    //    public static int AgeCheck(this int age)
    //    {
    //       Enterage:
            
    //        int num;
    //        bool v = int.TryParse(age, out num);
    //        // bool result = false;

    //        if (v)
    //        {
    //            if (num >= 18 && num <= 40)
    //            {
    //                return true;
    //            }
    //        }
           


    //        else
    //        {
    //            Extention.Print(ConsoleColor.Red, "Age 18-den boyuk ve 40-dan kicik olmalidir");
    //            goto Enterage;
    //        }


    //        return age;
    //    }
    }
}
