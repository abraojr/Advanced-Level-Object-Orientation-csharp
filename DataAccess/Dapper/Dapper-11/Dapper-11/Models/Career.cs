using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper_11.Models
{
    class Career
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IList<CareerItem> Items { get; set; }

        public Career()
        {
            Items = new List<CareerItem>();
        }

    }
}
