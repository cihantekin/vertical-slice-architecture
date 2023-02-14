namespace vertical_slice_architecture.Domain.Shared
{
    public class Result<T>
    {
        public Result() { }
        public Result(T? data)
        {
            Data = data;
        }

        public bool IsFailed { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T? Data { get; set; }

    }
}
