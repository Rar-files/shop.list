using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopListApi.Models
{
    public class QuantitieType
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public string ShortCut {get; set; }
        public int HowManyGrams {get; set; }
    }
}