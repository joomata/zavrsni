﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test10
{
    public class AppSettings
    {
        public int PageSize { get; set; } = 10;
        public int PageOffset { get; set; } = 10;
        public string ConnectionString { get; set; }
    }
}
