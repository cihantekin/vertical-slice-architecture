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
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Television>> GetTelevisionsForBrand(int brandId)
        {
            return await _dataContext.Televisions.Where(x => x.BrandId == brandId).ToListAsync();
        }

        public async Task RemoveTelevision(Domain.Television television)
        {
            _dataContext.Remove(television);
            await _dataContext.SaveChangesAsync();
        }
    }
}
