using Microsoft.EntityFrameworkCore;
using vertical_slice_architecture.Data;

namespace vertical_slice_architecture.Features.Brand
{
    public class BrandService : IBrandService
    {
        private readonly DataContext _dataContext;

        public BrandService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Domain.Brand>> GetAllBrands()
        {
            return await _dataContext.Brands.ToListAsync();
        }
    }
}
    