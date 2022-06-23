using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_11.Models
{
    class CareerItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
    }
}
