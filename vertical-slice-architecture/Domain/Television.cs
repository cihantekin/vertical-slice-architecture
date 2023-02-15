namespace vertical_slice_architecture.Domain
{
    public class Television
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = new();
        public decimal Inch { get; set; }
    }
}
