using Microsoft.EntityFrameworkCore;
using vertical_slice_architecture.Data;

namespace vertical_slice_architecture.Features.Television
{
    public class TelevisionService : ITelevisionService
    {
        private readonly DataContext _dataContext;

        public TelevisionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddTelevision(Domain.Television television)
        {
            await _dataContext.AddAsync(television);
        }

        public async Task<IEnumerable<Domain.Television>> GetTelevisionsForBrand(int brandId)
        {
            return await _dataContext.Televisions.Where(x => x.BrandId == brandId).ToListAsync();
        }
    }
}
