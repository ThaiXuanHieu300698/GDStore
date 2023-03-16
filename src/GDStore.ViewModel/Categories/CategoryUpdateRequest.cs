using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Categories
{
    public class CategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { set; get; }
        public Guid UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
