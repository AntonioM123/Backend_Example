using Example1.Data;

namespace Example1.Services.Hotels
{
    public interface IHotel
    {
        public Task<HotelDto> GetHotel(int id);

        public IList<HotelDto> GetHotels();

        public Task<HotelDto> CreateHotel(HotelDto dto);

        public Task<HotelDto> UpdateHotel(HotelDto dto);

        public Task<HotelDto> DeleteHotel(int id);

    }
}
