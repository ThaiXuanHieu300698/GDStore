using System;
using System.Collections.Generic;
using System.Text;

namespace GDStore.Domain.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public Guid UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
