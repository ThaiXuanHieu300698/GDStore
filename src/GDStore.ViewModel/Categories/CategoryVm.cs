using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Categories
{
    public class CategoryVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsShowOnHome { get; set; }

        public CategoryVm()
        {

        }

        public CategoryVm(int id, string name, string description, DateTime? createdDate, bool? isShowHome)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
            IsShowOnHome = isShowHome;
        }
    }
}
