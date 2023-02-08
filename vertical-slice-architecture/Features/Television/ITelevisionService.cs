
namespace vertical_slice_architecture.Features.Television
{
    public interface ITelevisionService
    {
        Task<IEnumerable<Domain.Television>> GetTelevisionsForBrand(int brandId);
        Task AddTelevision(Domain.Television television);
        Task RemoveTelevision(Domain.Television television);
    }
}
