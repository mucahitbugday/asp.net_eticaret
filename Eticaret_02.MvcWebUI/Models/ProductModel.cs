using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret_02.MvcWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Star { get; set; }

        public string StocCode { get; set; }

        public double PriceOld { get; set; }

        public double PriceNew { get; set; }

        public int Stock { get; set; }

        public string ImageSmall { get; set; }

        public string ImageLarge { get; set; }

        public bool IsHome { get; set; }

        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }

    }
}