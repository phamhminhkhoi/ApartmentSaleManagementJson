using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer.JsonModel
{
    public class Property
    {   
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int SizeSqFt { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
