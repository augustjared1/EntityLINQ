﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLINQ.DataModels
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
