using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { set; get; }
        public Guid UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsShowOnHome { get; set; }
        public IList<ProductCategory> ProductCategories { get; private set; } = new List<ProductCategory>();
    }
}
