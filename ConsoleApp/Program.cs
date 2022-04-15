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
            Console.WriteLine();
            while (true)
            {
                Extention.Print(ConsoleColor.Green, "1: Hotel Yaradin");
                string num = Console.ReadLine();
                int numm;
               bool v= int.TryParse(num, out numm);

                   


                if (v&&numm==1)
                {
                    hotelController.CreateHotel();
                    break;
                }
            }
            while (true)
            {
                Extention.Print(ConsoleColor.Cyan, "        Menyu \n" +
                "1: Create Hotel \n" +
                "2: Remove Hotel \n" +
                "3: Update Hotel \n" +
                "4: Get All Hotel \n" +
                "5: Get Hotel and Employee \n" +
                "6: Add Employee \n" +
                "7: Remove Employee \n" +
                "8: Update Employe \n" +
                "9: Get All Employee \n" +
                "10: Get Employee \n" +
                "0: Quit Program");
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input <= 10 && input > 0)
                {
                    switch (input)
                    {
                        case 1:
                            hotelController.CreateHotel();

                            break;
                        case 2:

                            break;
                    }
                }
            }
            



        }
    }
}
