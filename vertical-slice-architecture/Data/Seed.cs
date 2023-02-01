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
                Id = 3,
                Name = "Sony",
                Origin = "Japanese"
            });

            //Television
            dataContext.Televisions.Add(new Domain.Television
            {
                Id = 4,
                BrandId = 1,
                Inch = 65,
                Model = "SAMSUNG OLED 65S95B"
            });

            dataContext.Televisions.Add(new Domain.Television
            {
                Id = 5,
                BrandId = 2,
                Inch = 88,
                Model = "LG OLED 88Z29LA"
            });

            dataContext.Televisions.Add(new Domain.Television
            {
                Id = 6,
                BrandId = 3,
                Inch = 65,
                Model = "SONY Bravia XR-65A80K - 4K OLED"
            });

            dataContext.SaveChanges();
        }
    }
}
