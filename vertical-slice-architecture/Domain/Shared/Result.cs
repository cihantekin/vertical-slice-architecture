namespace vertical_slice_architecture.Domain.Shared
{
    public class Result<T>
    {
        public Result() { }
        public Result(T? data)
        {
            Data = data;
        }
        //public static implicit operator Result<T>(T value) => new Result<T>(value);

        public bool IsFailed { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public T? Data { get; set; }

    }
}
