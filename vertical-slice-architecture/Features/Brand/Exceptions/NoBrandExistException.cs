namespace vertical_slice_architecture.Features.Brand.Exceptions
{
    public class NoBrandExistException : Exception
    {
        public NoBrandExistException() : base("No brand was found in database!") { }
        public NoBrandExistException(int brandId) : base($"No brand with id: {brandId}") { }
    }
}
