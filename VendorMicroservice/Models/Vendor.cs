﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendorMicroservice.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public double DeliveryCharge { get; set; }
        public int Rating { get; set; }
        public int ExpectedDateOfDelivery { get; set; }
    }
}
