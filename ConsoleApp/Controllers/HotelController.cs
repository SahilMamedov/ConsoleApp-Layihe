using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace ConsoleApp.Controllers
{
    public class HotelController
    {
        HotelService hotelService;
        public HotelController()
        {
            hotelService = new HotelService();
        }
        public void CreateHotel()
        {
        EnterName:
            Extention.Print(ConsoleColor.Green, "Hotel Name daxil edin");
            string name = Console.ReadLine();
            Extention.Print(ConsoleColor.Green, "Hotel Adress daxil edin");
            string adress = Console.ReadLine();



            bool y = char.IsNumber(name[0]);


            if (y!=true)
            {

                Hotel hotel = new Hotel
                {
                    Name = name,
                    Adress = adress,
                    
                };

                hotelService.CreateHotel(hotel);
                Extention.Print(ConsoleColor.Green, $"ID:{hotel.Id} \n" +
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
    }
}
