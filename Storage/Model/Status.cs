using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Model
{
    [Table("Statuses")]
    public class Status
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Status() { }

        public Status(string title) 
        {
            Title = title;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
