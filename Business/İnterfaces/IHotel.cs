using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.İnterfaces
{
   public interface IHotel
    {
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(int Id, Hotel hotel);

        Hotel DeleteHotel(string name);

        Hotel GetHotel(int id);

        List<Hotel> GetAllHotel(string name = null);
    }
}
