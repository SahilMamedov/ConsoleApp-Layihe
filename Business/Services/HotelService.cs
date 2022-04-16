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

        public Hotel GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Hotel UpdateHotel(int Id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
