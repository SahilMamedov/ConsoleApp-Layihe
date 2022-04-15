using ConsoleApp.Controllers;
using System;
using Utilities.Helper;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelController hotelController = new HotelController();
            Extention.Print(ConsoleColor.Green, "Xosh gelmisiniz");
            while (true)
            {
                Extention.Print(ConsoleColor.Green, "1: Hotel Yaradin");
                int num = int.Parse(Console.ReadLine());
                
               
                
                if (num == 1)
                {
                    hotelController.CreateHotel();
                    break;
                }
            }
            
        }
    }
}
