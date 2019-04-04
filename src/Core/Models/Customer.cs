﻿using System.Collections.Generic;

namespace Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
