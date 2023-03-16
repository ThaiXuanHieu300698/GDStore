using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Brands
{
    public class BrandVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public BrandVm()
        {
        }

        public BrandVm(int id, string name, string logo)
        {
            Id = id;
            Name = name;
            Logo = logo;
        }
    }
}
