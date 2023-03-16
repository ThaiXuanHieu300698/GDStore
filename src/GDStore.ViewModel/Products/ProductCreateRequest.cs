using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Products
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public List<IFormFile> ThumbnailImage { get; set; }
        public int BrandId { get; set; }
        public IList<int> CategoryIds { get; set; }
    }
}
