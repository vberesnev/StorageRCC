using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public DateTime StatusChangeTime { get; set; }

        public Product() { }

        public Product(string name, ProductType productType, Status status)
        {
            Name = name;
            ProductType = productType;
            Status = status;
            StatusChangeTime = DateTime.Now;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
