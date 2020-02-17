using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ProductType() { }
        public ProductType(string text)
        {
            Title = text;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
