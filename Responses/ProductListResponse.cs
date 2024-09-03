using AngularSlideShowApi.Models;

namespace AngularSlideShowApi.Responses
{
    public class ProductListResponse
    {
        public List<Product> Items { get; set; } = new List<Product>();
    }
}
