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
        public enum Menu
        {
            CreateHotel = 1,
            RemoveHotel,
            UpdateHotel,
            GetAllHotel,
            GetHotelandEmployee,
            AddEmployee,
            RemoveEmployee,
            UpdateEmployee,
            RemoveAllEmployee,
            GetEmployee,
            QuitProgram
        }
        public enum MenuUpdateHotel
        {
            UpdateHotelName = 1,
            UpdateHotelAdress,
            Quit
        }
        public enum MenuUpdateEmployee
        {
            UpdateEmployeePosition = 1,
            UpdateEmployeeSalary,
            UpdateEmployeeHotelName,
            Quit
        }
        public static string StringName()
        {
        Entername:
            string stringname = Console.ReadLine();
            if (!string.IsNullOrEmpty(stringname))
            {
                return stringname;

            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Zehmet olmasa duzgun yazin..!");
                goto Entername;
            }




        }
        public static string HotelnameCheck()
        {
        EnterName:
            string name = Console.ReadLine();
            if (name.Length >= 4 && name.Length <= 15 && !char.IsNumber(name[0]))
            {
                return name;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Zehmet olmasa duzgun daxil edin..!");
                goto EnterName;
            }


        }
        public static int IntNum()
        {
        Enterage:
            string num = Console.ReadLine();
            int age;
            int.TryParse(num, out age);
            if (age >= 18 && age <= 40)
            {
                return age;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Duzgun daxil edin Age-i 18-den boyuk 40-dan kicik. ");
                goto Enterage;
            }
        }
        public static int IntCheck()
        {
        Enterage:
            string num = Console.ReadLine();
            int num1;
            bool y = int.TryParse(num, out num1);
            if (y)
            {
                return num1;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Zehmet Olmasa Duzgun Daxil edin..!");
                goto Enterage;
            }
        }




    }
}
