using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Catering
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public string Address { get; set; }
       public decimal  DiscountPercent { get; set; }
       public decimal Rate { get; set; }

       public CategoryType Category { get; set; }
    }
}
