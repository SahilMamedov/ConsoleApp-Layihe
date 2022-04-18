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

                Extention.Print(ConsoleColor.Green, "Hotel Name daxil edin");
                string name = Extention.HotelnameCheck();
                Extention.Print(ConsoleColor.Green, "Hotel Adress daxil edin");
                string adress = Extention.StringName();



                Hotel hotel = new Hotel
                {
                    Name = name.ToLower(),
                    Adress = adress.ToLower(),

                };

                hotelService.CreateHotel(hotel);
                Extention.Print(ConsoleColor.Yellow, $"ID:{hotel.Id} \n" +
                    $"HotelName:{hotel.Name} \n" +
                    $"Adress:{hotel.Adress} \n" +
                    $"ShareData {hotel.ShareData} Yarandi");

                Extention.Print(ConsoleColor.Red, "Ilk herif Reqem olmaz");


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
                string name = Extention.StringName();
                hotelService.DeleteHotel(name.ToLower());
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
                string name = Extention.StringName();
                Extention.Print(ConsoleColor.Green, "New Name-i daxin edin");
                string newname = Extention.StringName();

                hotelService.UpdateHotelName(name.ToLower(), newname.ToLower());
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
                string name = Extention.StringName();
                Extention.Print(ConsoleColor.Green, "New Adress-i daxin edin");
                string newadress = Extention.StringName();
                hotelService.UpdateHotelAdress(name.ToLower(), newadress.ToLower());
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

                    int num = Extention.IntCheck();


                    ;
                    if (num <= 3 && num > 0)
                    {
                        switch (num)
                        {
                            case (int)Extention.MenuUpdateHotel.UpdateHotelName:
                                UpdateHotelName();
                                break;
                            case (int)Extention.MenuUpdateHotel.UpdateHotelAdress:
                                UpdateHotelAdress();
                                break;
                        }
                    }
                    if (num == (int)Extention.MenuUpdateHotel.Quit)
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
