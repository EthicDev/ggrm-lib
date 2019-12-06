﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGRMLib.Models
{
    public class OrderLine
    {
        public int ID { get; set; }

        public decimal ColPrice { get; set; }

        public int ColQuantity { get; set; }

        public bool ColOrderReq { get; set; }

        public string ColNote { get; set; }

        public int InventoryID { get; set; }

        public int OrderID { get; set; }

        public int ProdOrderID { get; set; }
    }
}