using AutoMapper;
using Example1.Data;
using Example1.Models;
using Microsoft.EntityFrameworkCore;

namespace Example1.Services.Hotels
{
    public class HotelServ : IHotel
    {
        private readonly ExampleDbContext _context;
        private readonly IMapper _mapper;

        public HotelServ(ExampleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<HotelDto> GetHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);

            return _mapper.Map<HotelDto>(hotel);
        }

        public IList<HotelDto> GetHotels()
        {
            var hotels = _context.Hotels;

            return _mapper.Map<IList<HotelDto>>(hotels);
        }

        public async Task<HotelDto> CreateHotel(HotelDto dto)
        {
            var hotel = new Example1.Models.Hotels
            {
                Name = dto.Name,
                Adress = dto.Adress,
                Rating = dto.Rating,
                CountryId = dto.CountryId,
            };

            await _context.AddAsync(hotel);
            await _context.SaveChangesAsync();

            return _mapper.Map<HotelDto>(hotel);
        }


        public async Task<HotelDto> UpdateHotel(HotelDto dto)
        {
            var hotel = _context.Hotels.Find(dto.Id);

            if (hotel == null)
            {
                throw new InvalidDataException("Ne postoji takav hotel");
            }

            hotel.Adress = dto.Adress;
            hotel.Rating = dto.Rating;
            hotel.CountryId = dto.CountryId;
            hotel.Name = dto.Name;

            _context.Attach(hotel);
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return _mapper.Map<HotelDto>(hotel);
        }

        public async Task<HotelDto> DeleteHotel(int id)
        {
            var hotel = _context.Hotels.FindAsync(id);

            _context.Remove(hotel);
            await _context.SaveChangesAsync();

            return _mapper.Map<HotelDto>(hotel);
        }

       

       

    }
}
