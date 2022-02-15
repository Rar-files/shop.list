using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopListApi.Models
{
    public class Product
    {  
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Grams { get; set; }
        public IEnumerable<QuantitieType> QuantitieTypes { get; set; }
        public string Description { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}