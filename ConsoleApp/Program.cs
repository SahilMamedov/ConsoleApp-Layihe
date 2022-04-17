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
                "11: Quit Program");
                string num = Console.ReadLine();
                int input;

                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input <= 10 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extention.Menu.CreateHotel:
                            hotelController.CreateHotel();

                            break;
                        case (int)Extention.Menu.RemoveHotel:
                            hotelController.Remove();
                            break;
                        case (int)Extention.Menu.UpdateHotel:
                            hotelController.UpdateHotel();
                            break;
                                case (int)Extention.Menu.GetAllHotel:
                            hotelController.GetAllHotel();
                            break;
                        case (int)Extention.Menu.GetHotelandEmployee:
                            employeeController.GetAllEmployee();
                            break;
                        case (int)Extention.Menu.AddEmployee:
                            employeeController.AddEmployee();
                            break;
                        case (int)Extention.Menu.RemoveEmployee:
                            employeeController.RemoveEmployee();
                            break;
                        case (int)Extention.Menu.UpdateEmployee:
                            employeeController.UpdateEmployee();
                            break;
                        case (int)Extention.Menu.RemoveAllEmployee:
                            employeeController.RemoveAllEmployee();
                            break;
                        case (int)Extention.Menu.GetEmployee:
                            employeeController.GetEmployee();
                            break;
                      
                    }

                }
                if (input == (int)Extention.Menu.QuitProgram)
                {
                    break;
                }

            }
            



        }
    }
}
