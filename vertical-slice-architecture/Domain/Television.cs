namespace vertical_slice_architecture.Domain
{
    public class Television
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public decimal Inch { get; set; }
    }
}
