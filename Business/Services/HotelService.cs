using Business.İnterfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace Business.Services
{
   public class HotelService : IHotel
    {
        public static int ID { get; set; }
        private HotelRepasitory _hotelRepasitory;
       public EmployeeService employeeService;
        public HotelService()
        {
            _hotelRepasitory = new HotelRepasitory();
            employeeService = new EmployeeService();
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            ID++;
            hotel.Id = ID;
            hotel.ShareData = DateTime.Now;
            _hotelRepasitory.Create(hotel);
            return hotel;
            
        }

        public Hotel DeleteHotel(string name)
        {
            try
            {
                Hotel isExist = _hotelRepasitory.GetOne(h => h.Name == name);
                if (isExist == null)
                {
                    Extention.Print(ConsoleColor.Red, "Silmey istediyiniz add Otel Tapilmadi..!");
                    return null;
                   
                }
                
                employeeService.DeletAllEmployee(name);
                _hotelRepasitory.Delete(isExist);

                return isExist;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public List<Hotel> GetAll()
        {
            return _hotelRepasitory.GetAll();
        }

        public List<Hotel> GetAllHotel(string name = null)
        {
            return _hotelRepasitory.GetAll(h => h.Name == name);
        }

        public Hotel UpdateHotelName(string name, string newname)
        {
            Hotel isExist = _hotelRepasitory.GetOne(h => h.Name == name.ToLower());
            if (isExist != null)
            {
                isExist.Name = newname;
                
                foreach (var item in employeeService.GetAllEmployee(name))
                {
                    
                        item.HotelName = isExist.Name;
                    
                   
                }
                Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id}");
                Extention.Print(ConsoleColor.Blue, $"NewName: {isExist.Name}");
                Extention.Print(ConsoleColor.Yellow, $"Adress: {isExist.Adress}");
                return isExist;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, $"Bu Name-de Hotel Taapilmadi..!");
                
            }
            return null;

        }

        public Hotel UpdateHotelAdress(string name, string adress)
        {
            Hotel isExist = _hotelRepasitory.GetOne(h => h.Name == name);
            if (isExist != null)
            {
                isExist.Adress = adress;
                Extention.Print(ConsoleColor.Yellow, $"ID: {isExist.Id} \n" +
                    $"Name: {isExist.Name}");
                Extention.Print(ConsoleColor.Blue, $"Adress: {isExist.Adress}");
                return isExist;
            }
            else
            {
                Extention.Print(ConsoleColor.Red, $"Bu Name-de Hotel Taapilmadi..!");

            }
            return null;
        }

       


    }
}
