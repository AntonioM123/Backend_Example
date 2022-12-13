using AutoMapper;
using Example1.Data;
using Example1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Example1.Services.Country
{
    public class CountryServ : ICountry
    {
        private readonly ExampleDbContext _context;
        private readonly IMapper _mapper;

        public CountryServ(ExampleDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CountryDto> GetCountry(int id)
        {
            var country = await _context.Countries.Include(a => a.Hotels).FirstOrDefaultAsync(a => a.Id == id);

            if (country == null) return null;

            return _mapper.Map<CountryDto>(country);
        }

        public async Task<IList<CountryDto>> GetCountries()
        {
            var countries = await _context.Countries.ToListAsync();

            return _mapper.Map<IList<CountryDto>>(countries);   
        }

        public async Task<CountryDto> CreateCountry(CountryDto dto)
        {
            var country = new Example1.Models.Country()
            {
                Name = dto.Name,
                ShortName = dto.ShortName,
            };

            await _context.AddAsync(country);
            await _context.SaveChangesAsync();

            return _mapper.Map<CountryDto>(country);
        }

        public async Task<CountryDto> UpdateCountry(CountryDto dto)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(a => a.Id == dto.Id);

            country.Name = dto.Name;
            country.ShortName = dto.ShortName;

            _context.Attach(country);
            _context.Entry(country).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return _mapper.Map<CountryDto>(country);
        }

        public async Task<CountryDto> DeleteCountry(int id)
        {
            var country = _context.Countries.FirstOrDefault(a => a.Id == id);

            if (country == null) return null;

            _context.Remove(country);

            await _context.SaveChangesAsync();

            return _mapper.Map<CountryDto>(country);

        }

       

   

    }
}
