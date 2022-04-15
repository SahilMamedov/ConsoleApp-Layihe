﻿using Business.İnterfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class HotelService : IHotel
    {
        public int ID { get; set; }
        private HotelRepasitory _hotelRepasitory;
        EmployeeService employeeService;
        public HotelService()
        {
            _hotelRepasitory = new HotelRepasitory();   
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            ID++;
            hotel.Id = ID;
            _hotelRepasitory.Create(hotel);
            return hotel;
        }

        public Hotel DeleteHotel(string name)
        {
            Hotel isExist = _hotelRepasitory.GetOne(h => h.Name == name);
            if (isExist == null)
            {
                return null;
            }
            _hotelRepasitory.Delete(isExist);
            employeeService.DeletAllEmployee(name);
            return isExist;
        }

        public List<Hotel> GetAllHotel(string name = null)
        {
            throw new NotImplementedException();
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
