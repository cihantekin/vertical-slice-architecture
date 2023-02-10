namespace vertical_slice_architecture.Features.Television.Exceptions
{
    public class NoTelevisionExistException : Exception
    {
        public NoTelevisionExistException() : base($"No Televisions was found!") { }
        public NoTelevisionExistException(int televisionId) : base($"No Television was found with id: {televisionId}") { }
    }
}
