using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class HotelRepasitory : IRepasitory<Hotel>
    {
        public bool Create(Hotel entity)
        {
            try
            {
                DataContext.Hotels.Add(entity);
                
            }
            catch (Exception ex)
            {

                 Console.WriteLine(ex.Message);
            }
            return true;
        }

        public bool Delete(Hotel entity)
        {
            try
            {
                DataContext.Hotels.Remove(entity);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return true;
        }

        public List<Hotel> GetAll(Predicate<Hotel> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Hotels :
                   DataContext.Hotels.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public Hotel GetOne(Predicate<Hotel> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Hotels[0] :
                   DataContext.Hotels.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public bool Update(Hotel entity)
        {
            try
            {
                Hotel isExist = GetOne(h => h.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
