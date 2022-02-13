using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopListApi.Models;

namespace ShopListApi.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Grams { get; set; }
        public IEnumerable<QuantitieType> QuantitieTypes { get; set; }
        public string Description { get; set; }
        public IEnumerable<Product> Categories { get; set; }
    }
}