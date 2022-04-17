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
        Hotel UpdateHotelName(string name,string newname );
        Hotel UpdateHotelAdress(string name, string adress);
        Hotel DeleteHotel(string name);

    

        List<Hotel> GetAllHotel(string name = null);
    }
}
