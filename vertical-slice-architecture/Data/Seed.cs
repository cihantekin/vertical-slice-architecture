namespace vertical_slice_architecture.Data
{
    public class Seed
    {
        public void SeedData(DataContext dataContext)
        {
            // Brands
            dataContext.Brands.Add(new Domain.Brand
            {
                Id = 1,
                Name = "Samsung",
                Origin = "South Korean"
            });

            dataContext.Brands.Add(new Domain.Brand
            {
                Id = 2,
                Name = "LG",
                Origin = "South Korean"
            });

            dataContext.Brands.Add(new Domain.Brand
            {
                Id = 2,
                Name = "Sony",
                Origin = "Japanese"
            });
        }
    }
}
