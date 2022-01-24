using Ahoy.Domain.Base;
using Ahoy.Domain.Models.Hotels;
using System.Threading.Tasks;

namespace Ahoy.Domain.Interfaces.Hotels
{
    public interface IHotelRepository
    {
        Task<HotelList> HotelList();
        Task<MultiResponse> SearchHotel();
        Task<ResponseBase> BookingHotel(Booking booking);
    }
}
