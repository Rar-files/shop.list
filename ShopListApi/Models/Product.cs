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
        public string Grams { get; set; }
        public List<QuantitieType> QuantitieTypes { get; set; }
        public string Description { get; set; }
        public List<Product> Categories { get; set; }
    }
}