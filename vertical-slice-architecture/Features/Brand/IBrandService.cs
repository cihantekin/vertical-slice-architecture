namespace vertical_slice_architecture.Features.Brand
{
    public interface IBrandService
    {
        Task<IEnumerable<Domain.Brand>> GetAllBrands();
    }
}
