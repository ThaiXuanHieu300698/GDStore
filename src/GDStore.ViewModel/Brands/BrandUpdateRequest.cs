using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Brands
{
    public class BrandUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
