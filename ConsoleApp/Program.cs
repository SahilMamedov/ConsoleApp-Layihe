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
            EmployeeController employeeController = new EmployeeController();
            Extention.Print(ConsoleColor.Green, "Xosh gelmisiniz");
            Console.WriteLine();
            while (true)
            {
                Extention.Print(ConsoleColor.Green, "1: Hotel Yaradin");
                string num = Console.ReadLine();
                int numm;
               bool control = int.TryParse(num, out numm);

                   


                if (control&&numm==1)
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
                "9: Remove All Employee \n" +
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
                            hotelController.Remove();
                            break;
                        case 3:
                            hotelController.UpdateHotel();
                            break;
                                case 4:
                            hotelController.GetAllHotel();
                            break;
                        case 5:
                            employeeController.GetAllEmployee();
                            break;
                        case 6:
                            employeeController.AddEmployee();
                            break;
                        case 7:
                            employeeController.RemoveEmployee();
                            break;
                        case 8:
                            employeeController.UpdateEmployee();
                            break;
                        case 9:
                            employeeController.RemoveAllEmployee();
                            break;
                        case 10:
                            employeeController.GetEmployee();
                            break;
                      
                    }
                   
                }
                if (input == 0)
                {
                    break;
                }
            }
            



        }
    }
}
