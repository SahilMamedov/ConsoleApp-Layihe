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




    }




}
