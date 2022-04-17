using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace ConsoleApp.Controllers
{
    public class HotelController
    {
        public HotelService hotelService;
        public HotelController()
        {
            hotelService = new HotelService();
        }
        public void CreateHotel()
        {
            try
            {
            EnterName:
                Extention.Print(ConsoleColor.Green, "Hotel Name daxil edin");
                string name = Console.ReadLine();
                Extention.Print(ConsoleColor.Green, "Hotel Adress daxil edin");
                string adress = Console.ReadLine();



                bool y = char.IsNumber(name[0]);


                if (y != true)
                {

                    Hotel hotel = new Hotel
                    {
                        Name = name,
                        Adress = adress,

                    };

                    hotelService.CreateHotel(hotel);
                    Extention.Print(ConsoleColor.Yellow, $"ID:{hotel.Id} \n" +
                        $"HotelName:{hotel.Name} \n" +
                        $"Adress:{hotel.Adress} \n" +
                        $"ShareData {hotel.ShareData} Yarandi");
                }
                else
                {
                    Extention.Print(ConsoleColor.Red, "Ilk herif Reqem olmaz");
                    goto EnterName;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public void Remove()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Silmey Istediyiniz Hotelin Adin yazin");
                string name = Console.ReadLine();
                hotelService.DeleteHotel(name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
        public void UpdateHotelName()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Name-in Deyishmek istediyiniz Hotelin Name-in daxil edin");
                string name = Console.ReadLine();
                Extention.Print(ConsoleColor.Green, "New Name-i daxin edin");
                string newname = Console.ReadLine();
                hotelService.UpdateHotelName(name, newname);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateHotelAdress()
        {
            try
            {
                Extention.Print(ConsoleColor.Green, "Adress-in Deyishmek istediyiniz Hotelin Name-in daxil edin");
                string name = Console.ReadLine();
                Extention.Print(ConsoleColor.Green, "New Adress-i daxin edin");
                string newadress = Console.ReadLine();
                hotelService.UpdateHotelAdress(name, newadress);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateHotel()
        {
            try
            {
                while (true)
                {
                    Extention.Print(ConsoleColor.Cyan, "1: Update Hotel Name: \n" +
                        "2: Update Hotel Adress: \n" +
                        "3: Quit");

                    string num = Console.ReadLine();
                    int input;

                    bool IsNum = int.TryParse(num, out input);
                    if (IsNum && input <= 3 && input > 0)
                    {
                        switch (input)
                        {
                            case (int)Extention.MenuUpdateHotel.UpdateHotelName:
                                UpdateHotelName();
                                break;
                            case (int)Extention.MenuUpdateHotel.UpdateHotelAdress:
                                UpdateHotelAdress();
                                break;
                        }
                    }
                    if (input == (int)Extention.MenuUpdateHotel.Quit)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
        public void GetAllHotel()
        {
            try
            {
                foreach (var item in hotelService.GetAll())
                {
                    Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                        $"HotelName: {item.Name} \n" +
                        $"HotelAdress: {item.Adress} \n" +
                        $"ShareData: {item.ShareData}");


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }







    }
}
