using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace GDStore.ViewModel.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
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
