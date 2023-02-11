namespace vertical_slice_architecture.Domain.Shared
{
    public abstract class Result
    {
        public bool IsFailed { get; set; }
        public string ErrorMessage { get; set; }
    }
}
