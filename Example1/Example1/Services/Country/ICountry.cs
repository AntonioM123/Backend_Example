using Example1.Data;

namespace Example1.Services.Country
{
    public interface ICountry
    {
        public Task<CountryDto> GetCountry(int id);

        public Task<IList<CountryDto>> GetCountries();

        public Task<CountryDto> CreateCountry(CountryDto dto);

        public Task<CountryDto> UpdateCountry(CountryDto dto);

        public Task<CountryDto> DeleteCountry(int id);
    }
}
