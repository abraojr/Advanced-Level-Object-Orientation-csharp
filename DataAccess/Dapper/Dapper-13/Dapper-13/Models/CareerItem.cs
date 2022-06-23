using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_13.Models
{
    class CareerItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Course Course { get; set; }
    }
}
