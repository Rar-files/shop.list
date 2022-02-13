using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopListApi.Dtos
{
    public class QuantitieTypeDto
    {
        public string Name {get; set; }
        public string ShortCut {get; set; }
        public int HowManyGrams {get; set; }
    }
}