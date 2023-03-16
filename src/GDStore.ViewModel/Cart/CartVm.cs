using GDStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.ViewModel.Cart
{
    public class CartVm
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ThumbnailImage { get; set; }
    }
}
