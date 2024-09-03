using AngularSlideShowApi.Models;

namespace AngularSlideShowApi.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Black Hoodie",
                    Image = "assets/images/image1.jpg",
                    Price = "25.5",
                    Rating = 5
                },
                new Product
                {
                    Id = 2,
                    Name = "Branded Shoes",
                    Image = "assets/images/image2.jpg",
                    Price = "13.5",
                    Rating = 4
                },
                new Product
                {
                    Id = 3,
                    Name = "White Shirt",
                    Image = "assets/images/image3.jpg",
                    Price = "85.5",
                    Rating = 5
                },
                new Product
                {
                    Id = 4,
                    Name = "Grey Shirt",
                    Image = "assets/images/image4.jpg",
                    Price = "25.5",
                    Rating = 3
                },
                new Product
                {
                    Id = 5,
                    Name = "Black Shirt",
                    Image = "assets/images/image5.jpg",
                    Price = "45.5",
                    Rating = 4
                },
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }   
}
