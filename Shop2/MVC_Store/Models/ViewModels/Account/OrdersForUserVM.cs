﻿using System;
using System.Collections.Generic;


namespace MVC_Store.Models.ViewModels.Account
{
    public class OrdersForUserVM
    {
        public int OrderNumber { get; set; }
        public decimal Total { get; set; }
        public Dictionary<string, int> ProductsAndQty { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}